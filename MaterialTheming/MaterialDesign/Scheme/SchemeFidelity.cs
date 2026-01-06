using MaterialTheming.ColorDefinitions;
using MaterialTheming.MaterialDesign.DynamicColors;

namespace MaterialTheming.MaterialDesign.Scheme;

internal class SchemeFidelity : DynamicScheme
{
    public SchemeFidelity(HctColor sourceColorHct, bool isDark, double contrastLevel)
            : this(sourceColorHct, isDark, contrastLevel, DefaultPlatform)
    {
    }

    public SchemeFidelity(
        HctColor sourceColorHct,
        bool isDark,
        double contrastLevel,
        Platform platform)
        : base(
            sourceColorHct: sourceColorHct,
            variant: Variant.Fidelity,
            isDark: isDark,
            contrastLevel: contrastLevel,
            primaryPalette: ColorSpec2025.GetPrimaryPalette(Variant.Fidelity, sourceColorHct, isDark, platform),
            secondaryPalette: ColorSpec2025.GetSecondaryPalette(Variant.Fidelity, sourceColorHct, isDark, platform),
            tertiaryPalette: ColorSpec2025.GetTertiaryPalette(Variant.Fidelity, sourceColorHct, platform),
            neutralPalette: ColorSpec2025.GetNeutralPalette(Variant.Fidelity, sourceColorHct, isDark, platform),
            neutralVariantPalette: ColorSpec2025.GetNeutralVariantPalette(Variant.Fidelity, sourceColorHct, isDark, platform),
            errorPalette: ColorSpec2025.GetErrorPalette(Variant.Fidelity, sourceColorHct, platform),
            platform: platform)
    {
    }
}
