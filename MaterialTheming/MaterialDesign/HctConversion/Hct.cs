using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2TWinForms.Themes.MaterialDesign.HctConversion
{
    internal sealed class Hct
    {
        private double hue;
        private double chroma;
        private double tone;
        private int argb;

        /**
         * Create an HCT color from hue, chroma, and tone.
         *
         * @param hue 0 <= hue < 360; invalid values are corrected.
         * @param chroma 0 <= chroma < ?; Informally, colorfulness. The color returned may be lower than
         * the requested chroma. Chroma has a different maximum for any given hue and tone.
         * @param tone 0 <= tone <= 100; invalid values are corrected.
         * @return HCT representation of a color in default viewing conditions.
         */
        public static Hct From(double hue, double chroma, double tone)
        {
            int argb = HctSolver.SolveToInt(hue, chroma, tone);
            return new Hct(argb);
        }

        /**
         * Create an HCT color from a color.
         *
         * @param argb ARGB representation of a color.
         * @return HCT representation of a color in default viewing conditions
         */
        public static Hct FromInt(int argb)
        {
            return new Hct(argb);
        }

        private Hct(int argb)
        {
            SetInternalState(argb);
        }

        public double Hue
        {
            get => hue;
        }

        public double Chroma
        {
            get => chroma;
        }

        public double Tone
        {
            get => tone;
        }

        public int ToRgbInt()
        {
            return argb;
        }
        public Color ToColor()
        {
            return Color.FromArgb(argb);
        }

        /**
         * Set the hue of this color. Chroma may decrease because chroma has a different maximum for any
         * given hue and tone.
         *
         * @param newHue 0 <= newHue < 360; invalid values are corrected.
         */
        public void SetHue(double newHue)
        {
            SetInternalState(HctSolver.SolveToInt(newHue, chroma, tone));
        }

        /**
         * Set the chroma of this color. Chroma may decrease because chroma has a different maximum for
         * any given hue and tone.
         *
         * @param newChroma 0 <= newChroma < ?
         */
        public void SetChroma(double newChroma)
        {
            SetInternalState(HctSolver.SolveToInt(hue, newChroma, tone));
        }

        /**
         * Set the tone of this color. Chroma may decrease because chroma has a different maximum for any
         * given hue and tone.
         *
         * @param newTone 0 <= newTone <= 100; invalid valids are corrected.
         */
        public void SetTone(double newTone)
        {
            SetInternalState(HctSolver.SolveToInt(hue, chroma, newTone));
        }

        public override string ToString()
        {
            return $"HCT({(int)Math.Round(hue)}, {(int)Math.Round(chroma)}, {(int)Math.Round(tone)})";
        }


        /**
         * Translate a color into different ViewingConditions.
         *
         * <p>Colors change appearance. They look different with lights on versus off, the same color, as
         * in hex code, on white looks different when on black. This is called color relativity, most
         * famously explicated by Josef Albers in Interaction of Color.
         *
         * <p>In color science, color appearance models can account for this and calculate the appearance
         * of a color in different settings. HCT is based on CAM16, a color appearance model, and uses it
         * to make these calculations.
         *
         * <p>See ViewingConditions.Make for parameters affecting color appearance.
         */
        public Hct InViewingConditions(ViewingConditions vc)
        {
            // 1. Use CAM16 to find XYZ coordinates of color in specified VC.
            Cam16 cam16 = Cam16.FromInt(ToRgbInt());
            double[] viewedInVc = cam16.XyzInViewingConditions(vc, null);

            // 2. Create CAM16 of those XYZ coordinates in default VC.
            Cam16 recastInVc =
                Cam16.FromXyzInViewingConditions(
                    viewedInVc[0], viewedInVc[1], viewedInVc[2], ViewingConditions.DEFAULT);

            // 3. Create HCT from:
            // - CAM16 using default VC with XYZ coordinates in specified VC.
            // - L* converted from Y in XYZ coordinates in specified VC.
            return Hct.From(
                recastInVc.GetHue(), recastInVc.GetChroma(), ColorUtils.LstarFromY(viewedInVc[1]));
        }

        private void SetInternalState(int argb)
        {
            this.argb = argb;
            Cam16 cam = Cam16.FromInt(argb);
            hue = cam.GetHue();
            chroma = cam.GetChroma();
            this.tone = ColorUtils.LstarFromArgb(argb);
        }
    }
}
