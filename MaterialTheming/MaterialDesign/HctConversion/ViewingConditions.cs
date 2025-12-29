using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2TWinForms.Themes.MaterialDesign.HctConversion
{
    internal sealed class ViewingConditions
    {
        /** sRGB-like viewing conditions. */
        public static readonly ViewingConditions DEFAULT =
            ViewingConditions.DefaultWithBackgroundLstar(50.0);

        private readonly double aw;
        private readonly double nbb;
        private readonly double ncb;
        private readonly double c;
        private readonly double nc;
        private readonly double n;
        private readonly double[] rgbD;
        private readonly double fl;
        private readonly double flRoot;
        private readonly double z;

        public double Aw => aw;

        public double N => n;

        public double Nbb => nbb;

        public double Ncb => ncb;

        public double C => c;

        public double Nc => nc;

        public double[] RgbD => rgbD;

        public double Fl => fl;

        public double FlRoot => flRoot;

        public double Z => z;

        /**
         * Create ViewingConditions from a simple, physically relevant, set of parameters.
         *
         * @param whitePoint White point, measured in the XYZ color space. default = D65, or sunny day
         * afternoon
         * @param adaptingLuminance The luminance of the adapting field. Informally, how bright it is in
         * the room where the color is viewed. Can be calculated from lux by multiplying lux by
         * 0.0586. default = 11.72, or 200 lux.
         * @param backgroundLstar The lightness of the area surrounding the color. measured by L* in
         * L*a*b*. default = 50.0
         * @param surround A general description of the lighting surrounding the color. 0 is pitch dark,
         * like watching a movie in a theater. 1.0 is a dimly light room, like watching TV at home at
         * night. 2.0 means there is no difference between the lighting on the color and around it.
         * default = 2.0
         * @param discountingIlluminant Whether the eye accounts for the tint of the ambient lighting,
         * such as knowing an apple is still red in green light. default = false, the eye does not
         * perform this process on self-luminous objects like displays.
         */
        public static ViewingConditions Make(
            double[] whitePoint,
            double adaptingLuminance,
            double backgroundLstar,
            double surround,
            bool discountingIlluminant)
        {
            // A background of pure black is non-physical and leads to infinities that represent the idea
            // that any color viewed in pure black can't be seen.
            backgroundLstar = Math.Max(0.1, backgroundLstar);
            // Transform white point XYZ to 'cone'/'rgb' responses
            double[][] matrix = Cam16.XYZ_TO_CAM16RGB;
            double[] xyz = whitePoint;
            double rW = (xyz[0] * matrix[0][0]) + (xyz[1] * matrix[0][1]) + (xyz[2] * matrix[0][2]);
            double gW = (xyz[0] * matrix[1][0]) + (xyz[1] * matrix[1][1]) + (xyz[2] * matrix[1][2]);
            double bW = (xyz[0] * matrix[2][0]) + (xyz[1] * matrix[2][1]) + (xyz[2] * matrix[2][2]);
            double f = 0.8 + (surround / 10.0);
            double c =
                (f >= 0.9)
                    ? MathUtils.Lerp(0.59, 0.69, ((f - 0.9) * 10.0))
                    : MathUtils.Lerp(0.525, 0.59, ((f - 0.8) * 10.0));
            double d =
                discountingIlluminant
                    ? 1.0
                    : f * (1.0 - ((1.0 / 3.6) * Math.Exp((-adaptingLuminance - 42.0) / 92.0)));
            d = MathUtils.ClampDouble(0.0, 1.0, d);
            double nc = f;
            double[] rgbD =
                new double[] {
                d * (100.0 / rW) + 1.0 - d, d * (100.0 / gW) + 1.0 - d, d * (100.0 / bW) + 1.0 - d
                };
            double k = 1.0 / (5.0 * adaptingLuminance + 1.0);
            double k4 = k * k * k * k;
            double k4F = 1.0 - k4;
            double fl = (k4 * adaptingLuminance) + (0.1 * k4F * k4F * Math.Cbrt(5.0 * adaptingLuminance));
            double n = (ColorUtils.YFromLstar(backgroundLstar) / whitePoint[1]);
            double z = 1.48 + Math.Sqrt(n);
            double nbb = 0.725 / Math.Pow(n, 0.2);
            double ncb = nbb;
            double[] rgbAFactors =
                new double[] {
                Math.Pow(fl * rgbD[0] * rW / 100.0, 0.42),
                Math.Pow(fl * rgbD[1] * gW / 100.0, 0.42),
                Math.Pow(fl * rgbD[2] * bW / 100.0, 0.42)
                };

            double[] rgbA =
                new double[] {
                (400.0 * rgbAFactors[0]) / (rgbAFactors[0] + 27.13),
                (400.0 * rgbAFactors[1]) / (rgbAFactors[1] + 27.13),
                (400.0 * rgbAFactors[2]) / (rgbAFactors[2] + 27.13)
                };

            double aw = ((2.0 * rgbA[0]) + rgbA[1] + (0.05 * rgbA[2])) * nbb;
            return new ViewingConditions(n, aw, nbb, ncb, c, nc, rgbD, fl, Math.Pow(fl, 0.25), z);
        }

        /**
         * Create sRGB-like viewing conditions with a custom background lstar.
         *
         * <p>Default viewing conditions have a lstar of 50, midgray.
         */
        public static ViewingConditions DefaultWithBackgroundLstar(double lstar)
        {
            return ViewingConditions.Make(
                ColorUtils.WhitePointD65(),
                (200.0 / Math.PI * ColorUtils.YFromLstar(50.0) / 100.0),
                lstar,
                2.0,
                false);
        }

        /**
         * Parameters are intermediate values of the CAM16 conversion process. Their names are shorthand
         * for technical color science terminology, this class would not benefit from documenting them
         * individually. A brief overview is available in the CAM16 specification, and a complete overview
         * requires a color science textbook, such as Fairchild's Color Appearance Models.
         */
        private ViewingConditions(
            double n,
            double aw,
            double nbb,
            double ncb,
            double c,
            double nc,
            double[] rgbD,
            double fl,
            double flRoot,
            double z)
        {
            this.n = n;
            this.aw = aw;
            this.nbb = nbb;
            this.ncb = ncb;
            this.c = c;
            this.nc = nc;
            this.rgbD = rgbD;
            this.fl = fl;
            this.flRoot = flRoot;
            this.z = z;
        }
    }
}
