using MaterialTheming.ColorDefinitions;
using MaterialTheming.MaterialDesign;

namespace MaterialTheming
{
    partial class Theme
    {
        private const double SecondaryChromaFactor = (double)TargetChromas.Primary / TargetChromas.Secondary;
        private const double TertiaryChromaFactor = (double)TargetChromas.Primary / TargetChromas.Tertiary;
        private const double ErrorChromaFactor = (double)TargetChromas.Primary / TargetChromas.Error;
        private const double NeutralChromaFactor = (double)TargetChromas.Primary / TargetChromas.Neutral;
        private const double NeutralVariantChromaFactor = (double)TargetChromas.Primary / TargetChromas.NeutralVariant;

        public static Theme CreateFromSinglePrimaryColor(RgbColor primaryColor, ThemeMode mode, ContrastLevel contrastLevel, bool normalizeChroma)
        {
            var primaryColorHct = HctColor.FromRgbColor(primaryColor);
            primaryColorHct.Tone = 50;
            if (normalizeChroma)
                primaryColorHct.Chroma = TargetChromas.Primary;

            var seconaryColorHct = HctColor.From(primaryColorHct.Hue, primaryColorHct.Chroma / SecondaryChromaFactor, 50);
            var tertiaryColorHct = HctColor.From(primaryColorHct.Hue + 60, primaryColorHct.Chroma / TertiaryChromaFactor, 50);
            var errorColorHct = HctColor.From(24, primaryColorHct.Chroma / ErrorChromaFactor, 50);
            var neutralColorHct = HctColor.From(primaryColorHct.Hue, primaryColorHct.Chroma / NeutralChromaFactor, 50);
            var neutralVariantColorHct = HctColor.From(primaryColorHct.Hue, primaryColorHct.Chroma / NeutralVariantChromaFactor, 50);

            var coreColors = new CoreColors()
            {
                Primary = primaryColorHct.ToRgbColor(),
                Secondary = seconaryColorHct.ToRgbColor(),
                Tertiary = tertiaryColorHct.ToRgbColor(),
                Error = errorColorHct.ToRgbColor(),
                Neutral = neutralColorHct.ToRgbColor(),
                NeutralVariant = neutralVariantColorHct.ToRgbColor()
            };
            return Theme.CreateFromCoreColors(coreColors, mode, contrastLevel, normalizeChroma);
        }
    }
}
