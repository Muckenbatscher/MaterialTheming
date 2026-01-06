using MaterialTheming.ColorDefinitions;
using MaterialTheming.MaterialDesign.DynamicColors;

namespace MaterialTheming.MaterialDesign.Scheme;

internal class SchemeVibrant : DynamicScheme
{
    public SchemeVibrant(HctColor sourceColorHct, bool isDark, double contrastLevel)
        : this(sourceColorHct, isDark, contrastLevel, DefaultPlatform)
    {
    }

    public SchemeVibrant(
        HctColor sourceColorHct,
        bool isDark,
        double contrastLevel,
        Platform platform)
        : base(
            sourceColorHct: sourceColorHct,
            variant: Variant.Vibrant,
            isDark: isDark,
            contrastLevel: contrastLevel,
            primaryPalette: ColorSpec2025.GetPrimaryPalette(Variant.Vibrant, sourceColorHct, isDark, platform),
            secondaryPalette: ColorSpec2025.GetSecondaryPalette(Variant.Vibrant, sourceColorHct, isDark, platform),
            tertiaryPalette: ColorSpec2025.GetTertiaryPalette(Variant.Vibrant, sourceColorHct, platform),
            neutralPalette: ColorSpec2025.GetNeutralPalette(Variant.Vibrant, sourceColorHct, isDark, platform),
            neutralVariantPalette: ColorSpec2025.GetNeutralVariantPalette(Variant.Vibrant, sourceColorHct, isDark, platform),
            errorPalette: ColorSpec2025.GetErrorPalette(Variant.Vibrant, sourceColorHct, platform),
            platform: platform)
    {
    }
}