using MaterialTheming.ColorDefinitions;
using MaterialTheming.MaterialDesign.DynamicColors;

namespace MaterialTheming.MaterialDesign.Scheme;

internal class SchemeFruitSalad : DynamicScheme
{
    public SchemeFruitSalad(HctColor sourceColorHct, bool isDark, double contrastLevel)
        : this(sourceColorHct, isDark, contrastLevel, DefaultPlatform)
    {
    }

    public SchemeFruitSalad(
        HctColor sourceColorHct,
        bool isDark,
        double contrastLevel,
        Platform platform)
        : base(
            sourceColorHct: sourceColorHct,
            variant: Variant.FruitSalad,
            isDark: isDark,
            contrastLevel: contrastLevel,
            primaryPalette: ColorSpec2025.GetPrimaryPalette(Variant.FruitSalad, sourceColorHct, isDark, platform),
            secondaryPalette: ColorSpec2025.GetSecondaryPalette(Variant.FruitSalad, sourceColorHct, isDark, platform),
            tertiaryPalette: ColorSpec2025.GetTertiaryPalette(Variant.FruitSalad, sourceColorHct, platform),
            neutralPalette: ColorSpec2025.GetNeutralPalette(Variant.FruitSalad, sourceColorHct, isDark, platform),
            neutralVariantPalette: ColorSpec2025.GetNeutralVariantPalette(Variant.FruitSalad, sourceColorHct, isDark, platform),
            errorPalette: ColorSpec2025.GetErrorPalette(Variant.FruitSalad, sourceColorHct, platform),
            platform: platform)
    {
    }
}
