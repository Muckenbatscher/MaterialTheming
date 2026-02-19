using MaterialTheming.MaterialDesign.DynamicColors.ColorSpecs;
using MaterialTheming.MaterialDesign.Palettes;

namespace MaterialTheming.MaterialDesign.DynamicColors;

internal class DynamicSchemeColorSpecPalette : DynamicScheme
{
    public DynamicSchemeColorSpecPalette(Variant variant,
        bool isDark,
        double contrastLevel,
        IEnumerable<HctColor> sourceColors,
        Platform platform = Platform.Phone,
        SpecVersion specVersion = SpecVersion.Spec2021)
        : base(variant, isDark, contrastLevel, sourceColors,
            primaryPalette: GetPrimaryPalette(specVersion, variant, sourceColors, isDark, platform, contrastLevel),
            secondaryPalette: GetSecondaryPalette(specVersion, variant, sourceColors, isDark, platform, contrastLevel),
            tertiaryPalette: GetTertiaryPalette(specVersion, variant, sourceColors, isDark, platform, contrastLevel),
            neutralPalette: GetNeutralPalette(specVersion, variant, sourceColors, isDark, platform, contrastLevel),
            neutralVariantPalette: GetNeutralVariantPalette(specVersion, variant, sourceColors, isDark, platform, contrastLevel),
            errorPalette: GetErrorPalette(specVersion, variant, sourceColors, isDark, platform, contrastLevel),
            platform,
            specVersion)
    {
    }

    public DynamicSchemeColorSpecPalette(Variant variant,
        bool isDark,
        double contrastLevel,
        HctColor sourceColor,
        Platform platform = Platform.Phone,
        SpecVersion specVersion = SpecVersion.Spec2021)
        : this(variant, isDark, contrastLevel, [sourceColor], platform, specVersion)
    {
    }

    private static TonalPalette GetPrimaryPalette(SpecVersion specVersion, Variant variant, IEnumerable<HctColor> sourceColors,
        bool isDark, Platform platform, double contrastLevel)
    {
        var spec = ColorSpecFactory.Create(specVersion);
        var sourceColor = sourceColors.First();
        return spec.GetPrimaryPalette(variant, sourceColor, isDark, platform, contrastLevel);
    }
    private static TonalPalette GetSecondaryPalette(SpecVersion specVersion, Variant variant, IEnumerable<HctColor> sourceColors,
        bool isDark, Platform platform, double contrastLevel)
    {
        var spec = ColorSpecFactory.Create(specVersion);
        var sourceColor = sourceColors.First();
        return spec.GetSecondaryPalette(variant, sourceColor, isDark, platform, contrastLevel);
    }
    private static TonalPalette GetTertiaryPalette(SpecVersion specVersion, Variant variant, IEnumerable<HctColor> sourceColors,
        bool isDark, Platform platform, double contrastLevel)
    {
        var spec = ColorSpecFactory.Create(specVersion);
        var sourceColor = sourceColors.First();
        return spec.GetTertiaryPalette(variant, sourceColor, isDark, platform, contrastLevel);
    }
    private static TonalPalette GetNeutralPalette(SpecVersion specVersion, Variant variant, IEnumerable<HctColor> sourceColors,
        bool isDark, Platform platform, double contrastLevel)
    {
        var spec = ColorSpecFactory.Create(specVersion);
        var sourceColor = sourceColors.First();
        return spec.GetNeutralPalette(variant, sourceColor, isDark, platform, contrastLevel);
    }
    private static TonalPalette GetNeutralVariantPalette(SpecVersion specVersion, Variant variant, IEnumerable<HctColor> sourceColors,
        bool isDark, Platform platform, double contrastLevel)
    {
        var spec = ColorSpecFactory.Create(specVersion);
        var sourceColor = sourceColors.First();
        return spec.GetNeutralVariantPalette(variant, sourceColor, isDark, platform, contrastLevel);
    }
    private static TonalPalette? GetErrorPalette(SpecVersion specVersion, Variant variant, IEnumerable<HctColor> sourceColors,
        bool isDark, Platform platform, double contrastLevel)
    {
        var spec = ColorSpecFactory.Create(specVersion);
        var sourceColor = sourceColors.First();
        return spec.GetErrorPalette(variant, sourceColor, isDark, platform, contrastLevel);
    }
}
