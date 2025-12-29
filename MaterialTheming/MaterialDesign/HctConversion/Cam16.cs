using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2TWinForms.Themes.MaterialDesign.HctConversion
{
    internal class Cam16
    {
        internal static readonly double[][] XYZ_TO_CAM16RGB = {
        new double[] { 0.401288, 0.650173, -0.051461 },
        new double[] { -0.250268, 1.204414, 0.045854 },
        new double[] { -0.002079, 0.048952, 0.953127 }
    };

        // Transforms 'cone'/'RGB' responses in CAM16 to XYZ color space coordinates.
        static readonly double[][] CAM16RGB_TO_XYZ = {
        new double[] { 1.8620678, -1.0112547, 0.14918678 },
        new double[] { 0.38752654, 0.62144744, -0.00897398 },
        new double[] { -0.01584150, -0.03412294, 1.0499644 }
    };

        // CAM16 color dimensions, see getters for documentation.
        private readonly double hue;
        private readonly double chroma;
        private readonly double j;
        private readonly double q;
        private readonly double m;
        private readonly double s;

        // Coordinates in UCS space. Used to determine color distance, like delta E equations in L*a*b*.
        private readonly double jstar;
        private readonly double astar;
        private readonly double bstar;

        // Avoid allocations during conversion by pre-allocating an array.
        private readonly double[] tempArray = new double[] { 0.0, 0.0, 0.0 };

       
        /** Hue in CAM16 */
        public double GetHue()
        {
            return hue;
        }

        /** Chroma in CAM16 */
        public double GetChroma()
        {
            return chroma;
        }

        /** Lightness in CAM16 */
        public double GetJ()
        {
            return j;
        }

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
            double s,
            double jstar,
            double astar,
            double bstar)
        {
            this.hue = hue;
            this.chroma = chroma;
            this.j = j;
            this.q = q;
            this.m = m;
            this.s = s;
            this.jstar = jstar;
            this.astar = astar;
            this.bstar = bstar;
        }

        /**
         * Create a CAM16 color from a color, assuming the color was viewed in default viewing conditions.
         *
         * @param argb ARGB representation of a color.
         */
        public static Cam16 FromInt(int argb)
        {
            return FromIntInViewingConditions(argb, ViewingConditions.DEFAULT);
        }

        /**
         * Create a CAM16 color from a color in defined viewing conditions.
         *
         * @param argb ARGB representation of a color.
         * @param viewingConditions Information about the environment where the color was observed.
         */
        // The RGB => XYZ conversion matrix elements are derived scientific constants. While the values
        // may differ at runtime due to floating point imprecision, keeping the values the same, and
        // accurate, across implementations takes precedence.
        static Cam16 FromIntInViewingConditions(int argb, ViewingConditions viewingConditions)
        {
            // Transform ARGB int to XYZ
            int red = (argb & 0x00ff0000) >> 16;
            int green = (argb & 0x0000ff00) >> 8;
            int blue = (argb & 0x000000ff);
            double redL = ColorUtils.Linearized(red);
            double greenL = ColorUtils.Linearized(green);
            double blueL = ColorUtils.Linearized(blue);
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

            // CAM16-UCS components
            double jstar = (1.0 + 100.0 * 0.007) * j / (1.0 + 0.007 * j);
            double mstar = 1.0 / 0.0228 * Math.Log(1.0 + 0.0228 * m);
            double astar = mstar * Math.Cos(hueRadians);
            double bstar = mstar * Math.Sin(hueRadians);

            return new Cam16(hue, c, j, q, m, s, jstar, astar, bstar);
        }

        /**
         * @param j CAM16 lightness
         * @param c CAM16 chroma
         * @param h CAM16 hue
         * @param viewingConditions Information about the environment where the color was observed.
         */
        private static Cam16 FromJchInViewingConditions(
            double j, double c, double h, ViewingConditions viewingConditions)
        {
            double q =
                4.0
                    / viewingConditions.C
                    * Math.Sqrt(j / 100.0)
                    * (viewingConditions.Aw + 4.0)
                    * viewingConditions.FlRoot;
            double m = c * viewingConditions.FlRoot;
            double alpha = c / Math.Sqrt(j / 100.0);
            double s =
                50.0 * Math.Sqrt((alpha * viewingConditions.C) / (viewingConditions.Aw + 4.0));

            double hueRadians = h * (Math.PI / 180.0);
            double jstar = (1.0 + 100.0 * 0.007) * j / (1.0 + 0.007 * j);
            double mstar = 1.0 / 0.0228 * Math.Log(1.0 + 0.0228 * m);
            double astar = mstar * Math.Cos(hueRadians);
            double bstar = mstar * Math.Sin(hueRadians);
            return new Cam16(h, c, j, q, m, s, jstar, astar, bstar);
        }

        /**
         * ARGB representation of the color. Assumes the color was viewed in default viewing conditions,
         * which are near-identical to the default viewing conditions for sRGB.
         */
        public int ToInt()
        {
            return Viewed(ViewingConditions.DEFAULT);
        }

        /**
         * ARGB representation of the color, in defined viewing conditions.
         *
         * @param viewingConditions Information about the environment where the color will be viewed.
         * @return ARGB representation of color
         */
        int Viewed(ViewingConditions viewingConditions)
        {
            double[] xyz = XyzInViewingConditions(viewingConditions, tempArray);
            return ColorUtils.ArgbFromXyz(xyz[0], xyz[1], xyz[2]);
        }

        internal double[] XyzInViewingConditions(ViewingConditions viewingConditions, double[]? returnArray)
        {
            double alpha =
                (GetChroma() == 0.0 || GetJ() == 0.0) ? 0.0 : GetChroma() / Math.Sqrt(GetJ() / 100.0);

            double t =
                Math.Pow(
                    alpha / Math.Pow(1.64 - Math.Pow(0.29, viewingConditions.N), 0.73), 1.0 / 0.9);
            double hRad = GetHue() * (Math.PI / 180.0);

            double eHue = 0.25 * (Math.Cos(hRad + 2.0) + 3.8);
            double ac =
                viewingConditions.Aw
                    * Math.Pow(GetJ() / 100.0, 1.0 / viewingConditions.C / viewingConditions.Z);
            double p1 = eHue * (50000.0 / 13.0) * viewingConditions.Nc * viewingConditions.Ncb;
            double p2 = (ac / viewingConditions.Nbb);

            double hSin = Math.Sin(hRad);
            double hCos = Math.Cos(hRad);

            double gamma = 23.0 * (p2 + 0.305) * t / (23.0 * p1 + 11.0 * t * hCos + 108.0 * t * hSin);
            double a = gamma * hCos;
            double b = gamma * hSin;
            double rA = (460.0 * p2 + 451.0 * a + 288.0 * b) / 1403.0;
            double gA = (460.0 * p2 - 891.0 * a - 261.0 * b) / 1403.0;
            double bA = (460.0 * p2 - 220.0 * a - 6300.0 * b) / 1403.0;

            double rCBase = Math.Max(0, (27.13 * Math.Abs(rA)) / (400.0 - Math.Abs(rA)));
            double rC =
                Math.Sign(rA) * (100.0 / viewingConditions.Fl) * Math.Pow(rCBase, 1.0 / 0.42);
            double gCBase = Math.Max(0, (27.13 * Math.Abs(gA)) / (400.0 - Math.Abs(gA)));
            double gC =
                Math.Sign(gA) * (100.0 / viewingConditions.Fl) * Math.Pow(gCBase, 1.0 / 0.42);
            double bCBase = Math.Max(0, (27.13 * Math.Abs(bA)) / (400.0 - Math.Abs(bA)));
            double bC =
                Math.Sign(bA) * (100.0 / viewingConditions.Fl) * Math.Pow(bCBase, 1.0 / 0.42);
            double rF = rC / viewingConditions.RgbD[0];
            double gF = gC / viewingConditions.RgbD[1];
            double bF = bC / viewingConditions.RgbD[2];

            double[][] matrix = CAM16RGB_TO_XYZ;
            double x = (rF * matrix[0][0]) + (gF * matrix[0][1]) + (bF * matrix[0][2]);
            double y = (rF * matrix[1][0]) + (gF * matrix[1][1]) + (bF * matrix[1][2]);
            double z = (rF * matrix[2][0]) + (gF * matrix[2][1]) + (bF * matrix[2][2]);

            if (returnArray != null)
            {
                returnArray[0] = x;
                returnArray[1] = y;
                returnArray[2] = z;
                return returnArray;
            }
            else
            {
                return new double[] { x, y, z };
            }
        }
    }
}
