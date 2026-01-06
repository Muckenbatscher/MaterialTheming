using MaterialTheming.ColorDefinitions;
using MaterialTheming.MaterialDesign.DynamicColors;

namespace MaterialTheming.MaterialDesign.Scheme;

internal class SchemeContent : DynamicScheme
{
    public SchemeContent(HctColor sourceColorHct, bool isDark, double contrastLevel)
        : this(sourceColorHct, isDark, contrastLevel, DefaultPlatform)
    {
    }

    public SchemeContent(
        HctColor sourceColorHct,
        bool isDark,
        double contrastLevel,
        Platform platform)
        : base(
            sourceColorHct: sourceColorHct,
            variant: Variant.Content,
            isDark: isDark,
            contrastLevel: contrastLevel,
            primaryPalette: ColorSpec2025.GetPrimaryPalette(Variant.Content, sourceColorHct, isDark, platform),
            secondaryPalette: ColorSpec2025.GetSecondaryPalette(Variant.Content, sourceColorHct, isDark, platform),
            tertiaryPalette: ColorSpec2025.GetTertiaryPalette(Variant.Content, sourceColorHct, platform),
            neutralPalette: ColorSpec2025.GetNeutralPalette(Variant.Content, sourceColorHct, isDark, platform),
            neutralVariantPalette: ColorSpec2025.GetNeutralVariantPalette(Variant.Content, sourceColorHct, isDark, platform),
            errorPalette: ColorSpec2025.GetErrorPalette(Variant.Content, sourceColorHct, platform),
            platform: platform)
    {
    }
}
