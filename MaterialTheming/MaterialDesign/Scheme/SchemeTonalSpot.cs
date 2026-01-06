using MaterialTheming.ColorDefinitions;
using MaterialTheming.MaterialDesign.DynamicColors;

namespace MaterialTheming.MaterialDesign.Scheme;

internal class SchemeTonalSpot : DynamicScheme
{
    public SchemeTonalSpot(HctColor sourceColorHct, bool isDark, double contrastLevel)
        : this(sourceColorHct, isDark, contrastLevel, DefaultPlatform)
    {
    }

    public SchemeTonalSpot(
        HctColor sourceColorHct,
        bool isDark,
        double contrastLevel,
        Platform platform)
        : base(
            sourceColorHct: sourceColorHct,
            variant: Variant.TonalSpot,
            isDark: isDark,
            contrastLevel: contrastLevel,
            primaryPalette: ColorSpec2025.GetPrimaryPalette(Variant.TonalSpot, sourceColorHct, isDark, platform),
            secondaryPalette: ColorSpec2025.GetSecondaryPalette(Variant.TonalSpot, sourceColorHct, isDark, platform),
            tertiaryPalette: ColorSpec2025.GetTertiaryPalette(Variant.TonalSpot, sourceColorHct, platform),
            neutralPalette: ColorSpec2025.GetNeutralPalette(Variant.TonalSpot, sourceColorHct, isDark, platform),
            neutralVariantPalette: ColorSpec2025.GetNeutralVariantPalette(Variant.TonalSpot, sourceColorHct, isDark, platform),
            errorPalette: ColorSpec2025.GetErrorPalette(Variant.TonalSpot, sourceColorHct, platform),
            platform: platform)
    {
    }
}
