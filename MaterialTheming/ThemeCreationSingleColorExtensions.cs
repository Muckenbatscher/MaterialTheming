using M2TWinForms.Themes.MaterialDesign;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2TWinForms.Themes
{
    partial class Theme
    {
        private const double SecondaryChromaFactor = (double)TargetChromas.Primary / TargetChromas.Secondary ;
        private const double TertiaryChromaFactor = (double)TargetChromas.Primary / TargetChromas.Tertiary ;
        private const double ErrorChromaFactor = (double)TargetChromas.Primary / TargetChromas.Error;
        private const double NeutralChromaFactor = (double)TargetChromas.Primary / TargetChromas.Neutral;
        private const double NeutralVariantChromaFactor = (double)TargetChromas.Primary / TargetChromas.NeutralVariant;

        public static Theme CreateFromSinglePrimaryColor(Color primaryColor, ThemeMode mode, ContrastLevel contrastLevel, bool normalizeChroma)
        {
            var primaryColorHct = new HctColor(primaryColor) { Tone = 50 };
            if (normalizeChroma)
                primaryColorHct.Chroma = TargetChromas.Primary;

            var seconaryColorHct = new HctColor(primaryColorHct.Hue, primaryColorHct.Chroma / SecondaryChromaFactor, 50);
            var tertiaryColorHct = new HctColor(primaryColorHct.Hue + 60, primaryColorHct.Chroma / TertiaryChromaFactor, 50);
            var errorColorHct = new HctColor(24, primaryColorHct.Chroma / ErrorChromaFactor, 50);
            var neutralColorHct = new HctColor(primaryColorHct.Hue, primaryColorHct.Chroma / NeutralChromaFactor, 50);
            var neutralVariantColorHct = new HctColor(primaryColorHct.Hue, primaryColorHct.Chroma / NeutralVariantChromaFactor, 50);

            var coreColors = new CoreColors()
            {
                Primary = primaryColorHct.GetColor(),
                Secondary = seconaryColorHct.GetColor(),
                Tertiary = tertiaryColorHct.GetColor(),
                Error = errorColorHct.GetColor(),
                Neutral = neutralColorHct.GetColor(),
                NeutralVariant = neutralVariantColorHct.GetColor()
            };
            return Theme.CreateFromCoreColors(coreColors, mode, contrastLevel, normalizeChroma);
        }
    }
}
