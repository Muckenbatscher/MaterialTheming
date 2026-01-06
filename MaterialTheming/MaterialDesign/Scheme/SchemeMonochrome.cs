using MaterialTheming.ColorDefinitions;
using MaterialTheming.MaterialDesign.DynamicColors;

namespace MaterialTheming.MaterialDesign.Scheme;

internal class SchemeMonochrome : DynamicScheme
{
    public SchemeMonochrome(HctColor sourceColorHct, bool isDark, double contrastLevel)
        : this(sourceColorHct, isDark, contrastLevel, DefaultPlatform)
    {
    }

    public SchemeMonochrome(
        HctColor sourceColorHct,
        bool isDark,
        double contrastLevel,
        Platform platform)
        : base(
            sourceColorHct: sourceColorHct,
            variant: Variant.Monochrome,
            isDark: isDark,
            contrastLevel: contrastLevel,
            primaryPalette: ColorSpec2025.GetPrimaryPalette(Variant.Monochrome, sourceColorHct, isDark, platform),
            secondaryPalette: ColorSpec2025.GetSecondaryPalette(Variant.Monochrome, sourceColorHct, isDark, platform),
            tertiaryPalette: ColorSpec2025.GetTertiaryPalette(Variant.Monochrome, sourceColorHct, platform),
            neutralPalette: ColorSpec2025.GetNeutralPalette(Variant.Monochrome, sourceColorHct, isDark, platform),
            neutralVariantPalette: ColorSpec2025.GetNeutralVariantPalette(Variant.Monochrome, sourceColorHct, isDark, platform),
            errorPalette: ColorSpec2025.GetErrorPalette(Variant.Monochrome, sourceColorHct, platform),
            platform: platform)
    {
    }
}
