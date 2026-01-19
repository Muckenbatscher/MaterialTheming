namespace MaterialTheming.MaterialDesign.HctConversion
{
    internal class ColorUtils
    {
        private ColorUtils() { }

        static readonly double[][] SrgbToXyz =
            new double[][] {
            new double[] {0.41233895, 0.35762064, 0.18051042},
            new double[] {0.2126, 0.7152, 0.0722},
            new double[] {0.01932141, 0.11916382, 0.95034478},
            };

        static readonly double[][] XyzToSrgb =
            new double[][] {
            new double[] {
                3.2413774792388685, -1.5376652402851851, -0.49885366846268053,
            },
            new double[] {
                -0.9691452513005321, 1.8758853451067872, 0.04156585616912061,
            },
            new double[] {
                0.05562093689691305, -0.20395524564742123, 1.0571799111220335,
            },
            };

        static readonly double[] WHITE_POINT_D65 = new double[] { 95.047, 100.0, 108.883 };

        /** Converts a color from linear RGB components to RGB format. */
        public static RgbColor RgbFromLinrgb(double[] linrgb)
        {
            var r = (byte)Delinearized(linrgb[0]);
            var g = (byte)Delinearized(linrgb[1]);
            var b = (byte)Delinearized(linrgb[2]);
            return RgbColor.FromRgb(r, g, b);
        }

        /** Converts a color from RGB to XYZ. */
        public static RgbColor RgbFromXyz(double x, double y, double z)
        {
            double[][] matrix = XyzToSrgb;
            double linearR = matrix[0][0] * x + matrix[0][1] * y + matrix[0][2] * z;
            double linearG = matrix[1][0] * x + matrix[1][1] * y + matrix[1][2] * z;
            double linearB = matrix[2][0] * x + matrix[2][1] * y + matrix[2][2] * z;
            var r = (byte)Delinearized(linearR);
            var g = (byte)Delinearized(linearG);
            var b = (byte)Delinearized(linearB);
            return RgbColor.FromRgb(r, g, b);
        }

        /** Converts a color from XYZ to RGB. */
        public static double[] XyzFromRgb(RgbColor rgb)
        {
            double r = Linearized(rgb.Red);
            double g = Linearized(rgb.Green);
            double b = Linearized(rgb.Blue);
            return MathUtils.MatrixMultiply(new double[] { r, g, b }, SrgbToXyz);
        }

        // <summary>
        /// Converts a color represented in Lab color space into an RGB color.
        /// </summary>
        public static RgbColor RgbFromLab(double l, double a, double b)
        {
            double[] whitePoint = WhitePointD65();
            double fy = (l + 16.0) / 116.0;
            double fx = a / 500.0 + fy;
            double fz = fy - b / 200.0;
            double xNormalized = LabInvf(fx);
            double yNormalized = LabInvf(fy);
            double zNormalized = LabInvf(fz);
            double x = xNormalized * whitePoint[0];
            double y = yNormalized * whitePoint[1];
            double z = zNormalized * whitePoint[2];
            return RgbFromXyz(x, y, z);
        }

        /// <summary>
        /// Converts a color from RGB representation to L*a*b* representation.
        /// </summary>
        /// <param name="argb">the RGB representation of a color</param>
        /// <returns>a double array representing the color in Lab space</returns>
        public static double[] LabFromRgb(RgbColor rgb)
        {
            double linearR = Linearized(rgb.Red);
            double linearG = Linearized(rgb.Green);
            double linearB = Linearized(rgb.Blue);
            double[][] matrix = SrgbToXyz;
            double x = matrix[0][0] * linearR + matrix[0][1] * linearG + matrix[0][2] * linearB;
            double y = matrix[1][0] * linearR + matrix[1][1] * linearG + matrix[1][2] * linearB;
            double z = matrix[2][0] * linearR + matrix[2][1] * linearG + matrix[2][2] * linearB;
            double[] whitePoint = WhitePointD65();
            double xNormalized = x / whitePoint[0];
            double yNormalized = y / whitePoint[1];
            double zNormalized = z / whitePoint[2];
            double fx = LabF(xNormalized);
            double fy = LabF(yNormalized);
            double fz = LabF(zNormalized);
            double l = 116.0 * fy - 16;
            double a = 500.0 * (fx - fy);
            double b = 200.0 * (fy - fz);
            return [l, a, b];
        }

        /**
         * Converts an L* value to an RGB representation.
         *
         * @param lstar L* in L*a*b*
         * @return RGB representation of grayscale color with lightness matching L*
         */
        public static RgbColor RgbFromLstar(double lstar)
        {
            var y = YFromLstar(lstar);
            var component = Delinearized(y);
            var componentByte = (byte)component;
            return RgbColor.FromRgb(componentByte, componentByte, componentByte);
        }

        /**
         * Computes the L* value of a color in RGB representation.
         *
         * @param rgb RGB representation of a color
         * @return L*, from L*a*b*, coordinate of the color
         */
        public static double LstarFromRgb(RgbColor rgb)
        {
            double y = XyzFromRgb(rgb)[1];
            return LabF(y / 100.0) * 116.0 - 16.0;
        }

        /**
         * Converts an L* value to a Y value.
         *
         * <p>L* in L*a*b* and Y in XYZ measure the same quantity, luminance.
         *
         * <p>L* measures perceptual luminance, a linear scale. Y in XYZ measures relative luminance, a
         * logarithmic scale.
         *
         * @param lstar L* in L*a*b*
         * @return Y in XYZ
         */
        public static double YFromLstar(double lstar)
        {
            return 100.0 * LabInvf((lstar + 16.0) / 116.0);
        }

        /**
         * Converts a Y value to an L* value.
         *
         * <p>L* in L*a*b* and Y in XYZ measure the same quantity, luminance.
         *
         * <p>L* measures perceptual luminance, a linear scale. Y in XYZ measures relative luminance, a
         * logarithmic scale.
         *
         * @param y Y in XYZ
         * @return L* in L*a*b*
         */
        public static double LstarFromY(double y)
        {
            return LabF(y / 100.0) * 116.0 - 16.0;
        }

        /**
         * Linearizes an RGB component.
         *
         * @param rgbComponent 0 <= rgb_component <= 255, represents R/G/B channel
         * @return 0.0 <= output <= 100.0, color channel converted to linear RGB space
         */
        public static double Linearized(int rgbComponent)
        {
            double normalized = rgbComponent / 255.0;
            return normalized <= 0.040449936
                ? normalized / 12.92 * 100.0
                : Math.Pow((normalized + 0.055) / 1.055, 2.4) * 100.0;
        }

        /**
         * Delinearizes an RGB component.
         *
         * @param rgbComponent 0.0 <= rgb_component <= 100.0, represents linear R/G/B channel
         * @return 0 <= output <= 255, color channel converted to regular RGB space
         */
        public static int Delinearized(double rgbComponent)
        {
            double normalized = rgbComponent / 100.0;
            var delinearized = normalized <= 0.0031308
                ? normalized * 12.92
                : 1.055 * Math.Pow(normalized, 1.0 / 2.4) - 0.055;
            return Math.Clamp((int)Math.Round(delinearized * 255.0), 0, 255);
        }

        /**
         * Returns the standard white point; white on a sunny day.
         *
         * @return The white point
         */
        public static double[] WhitePointD65()
        {
            return WHITE_POINT_D65;
        }

        static double LabF(double t)
        {
            double e = 216.0 / 24389.0;
            double kappa = 24389.0 / 27.0;
            if (t > e)
            {
                return Math.Pow(t, 1.0 / 3.0);
            }
            else
            {
                return (kappa * t + 16) / 116;
            }
        }

        static double LabInvf(double ft)
        {
            double e = 216.0 / 24389.0;
            double kappa = 24389.0 / 27.0;
            double ft3 = ft * ft * ft;
            if (ft3 > e)
            {
                return ft3;
            }
            else
            {
                return (116 * ft - 16) / kappa;
            }
        }
    }
}
