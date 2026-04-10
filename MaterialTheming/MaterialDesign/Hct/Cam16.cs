namespace MaterialTheming.MaterialDesign.HctConversion
{
    internal class Cam16
    {
        internal static readonly double[][] XYZ_TO_CAM16RGB =
        {
            [0.401288,  0.650173, -0.051461],
            [-0.250268, 1.204414, 0.045854],
            [-0.002079, 0.048952, 0.953127]
        };

        // Transforms 'cone'/'RGB' responses in CAM16 to XYZ color space coordinates.
        static readonly double[][] CAM16RGB_TO_XYZ =
        {
            [1.8620678,   -1.0112547, 0.14918678],
            [0.38752654,  0.62144744, -0.00897398],
            [-0.01584150, -0.03412294, 1.0499644]
        };
        /// <summary>
        /// Hue in CAM16
        /// </summary>
        public double Hue { get; private set; }
        /// <summary>
        /// Chroma in CAM16
        /// </summary>
        public double Chroma { get; private set; }
        /// <summary>
        /// Lightness in CAM16
        /// </summary>
        public double J { get; private set; }
        public double Q { get; private set; }
        public double M { get; private set; }
        public double S { get; private set; }

        /**
         * All of the CAM16 dimensions can be calculated from 3 of the dimensions, in the following
         * combinations: - {j or q} and {c, m, or s} and hue - jstar, astar, bstar Prefer using a static
         * method that constructs from 3 of those dimensions. This constructor is intended for those
         * methods to use to return all possible dimensions.
         *
         * @param hue for example, red, orange, yellow, green, etc.
         * @param chroma informally, colorfulness / color intensity. like saturation in HSL, except
         * perceptual accurate.
         * @param j lightness
         * @param q brightness; ratio of lightness to white point's lightness
         * @param m colorfulness
         * @param s saturation; ratio of chroma to white point's chroma
         * @param jstar CAM16-UCS J coordinate
         * @param astar CAM16-UCS a coordinate
         * @param bstar CAM16-UCS b coordinate
         */
        private Cam16(
            double hue,
            double chroma,
            double j,
            double q,
            double m,
            double s)
        {
            this.Hue = hue;
            this.Chroma = chroma;
            this.J = j;
            this.Q = q;
            this.M = m;
            this.S = s;
        }

        /**
         * Create a CAM16 color from a color, assuming the color was viewed in default viewing conditions.
         *
         * @param rgb RGB representation of a color.
         */
        public static Cam16 FromRgbColor(RgbColor rgb)
        {
            return FromRgbColorInViewingConditions(rgb, ViewingConditions.DEFAULT);
        }

        /**
         * Create a CAM16 color from a color in defined viewing conditions.
         *
         * @param rgb RGB representation of a color.
         * @param viewingConditions Information about the environment where the color was observed.
         */
        // The RGB => XYZ conversion matrix elements are derived scientific constants. While the values
        // may differ at runtime due to floating point imprecision, keeping the values the same, and
        // accurate, across implementations takes precedence.
        static Cam16 FromRgbColorInViewingConditions(RgbColor rgb, ViewingConditions viewingConditions)
        {
            // Transform RGB int to XYZ
            double redL = ColorUtils.Linearized(rgb.Red);
            double greenL = ColorUtils.Linearized(rgb.Green);
            double blueL = ColorUtils.Linearized(rgb.Blue);
            double x = 0.41233895 * redL + 0.35762064 * greenL + 0.18051042 * blueL;
            double y = 0.2126 * redL + 0.7152 * greenL + 0.0722 * blueL;
            double z = 0.01932141 * redL + 0.11916382 * greenL + 0.95034478 * blueL;

            return FromXyzInViewingConditions(x, y, z, viewingConditions);
        }

        internal static Cam16 FromXyzInViewingConditions(
        double x, double y, double z, ViewingConditions viewingConditions)
        {
            // Transform XYZ to 'cone'/'rgb' responses
            double[][] matrix = XYZ_TO_CAM16RGB;
            double rT = (x * matrix[0][0]) + (y * matrix[0][1]) + (z * matrix[0][2]);
            double gT = (x * matrix[1][0]) + (y * matrix[1][1]) + (z * matrix[1][2]);
            double bT = (x * matrix[2][0]) + (y * matrix[2][1]) + (z * matrix[2][2]);

            // Discount illuminant
            double rD = viewingConditions.RgbD[0] * rT;
            double gD = viewingConditions.RgbD[1] * gT;
            double bD = viewingConditions.RgbD[2] * bT;

            // Chromatic adaptation
            double rAF = Math.Pow(viewingConditions.Fl * Math.Abs(rD) / 100.0, 0.42);
            double gAF = Math.Pow(viewingConditions.Fl * Math.Abs(gD) / 100.0, 0.42);
            double bAF = Math.Pow(viewingConditions.Fl * Math.Abs(bD) / 100.0, 0.42);
            double rA = Math.Sign(rD) * 400.0 * rAF / (rAF + 27.13);
            double gA = Math.Sign(gD) * 400.0 * gAF / (gAF + 27.13);
            double bA = Math.Sign(bD) * 400.0 * bAF / (bAF + 27.13);

            // redness-greenness
            double a = (11.0 * rA + -12.0 * gA + bA) / 11.0;
            // yellowness-blueness
            double b = (rA + gA - 2.0 * bA) / 9.0;

            // auxiliary components
            double u = (20.0 * rA + 20.0 * gA + 21.0 * bA) / 20.0;
            double p2 = (40.0 * rA + 20.0 * gA + bA) / 20.0;

            // hue
            double atan2 = Math.Atan2(b, a);
            double atanDegrees = atan2 * (180.0 / Math.PI);
            double hue =
                atanDegrees < 0
                    ? atanDegrees + 360.0
                    : atanDegrees >= 360 ? atanDegrees - 360.0 : atanDegrees;
            double hueRadians = hue * (Math.PI / 180.0);

            // achromatic response to color
            double ac = p2 * viewingConditions.Nbb;

            // CAM16 lightness and brightness
            double j =
                100.0
                    * Math.Pow(
                        ac / viewingConditions.Aw,
                        viewingConditions.C * viewingConditions.Z);
            double q =
                4.0
                    / viewingConditions.C
                    * Math.Sqrt(j / 100.0)
                    * (viewingConditions.Aw + 4.0)
                    * viewingConditions.FlRoot;

            // CAM16 chroma, colorfulness, and saturation.
            double huePrime = (hue < 20.14) ? hue + 360 : hue;
            double eHue = 0.25 * (Math.Cos(huePrime * (Math.PI / 180.0) + 2.0) + 3.8);
            double p1 = 50000.0 / 13.0 * eHue * viewingConditions.Nc * viewingConditions.Ncb;
            double t = p1 * Math.Sqrt(a * a + b * b) / (u + 0.305);
            double alpha =
                Math.Pow(1.64 - Math.Pow(0.29, viewingConditions.N), 0.73) * Math.Pow(t, 0.9);
            // CAM16 chroma, colorfulness, saturation
            double c = alpha * Math.Sqrt(j / 100.0);
            double m = c * viewingConditions.FlRoot;
            double s =
                50.0 * Math.Sqrt((alpha * viewingConditions.C) / (viewingConditions.Aw + 4.0));

            return new Cam16(hue, c, j, q, m, s);
        }
    }
}
