using MaterialTheming.MaterialDesign.Palettes;

namespace MaterialTheming.MaterialDesign.DynamicColors;

internal class DynamicSchemeCmf : DynamicScheme
{
    public DynamicSchemeCmf(bool isDark,
        double contrastLevel,
        IEnumerable<HctColor> sourceColors,
        Platform platform = Platform.Phone,
        SpecVersion specVersion = SpecVersion.Spec2026)
        : base(Variant.CMF, isDark, contrastLevel, sourceColors,
            primaryPalette: GetPrimaryPalette(sourceColors),
            secondaryPalette: GetSecondaryPalette(sourceColors),
            tertiaryPalette: GetTertiaryPalette(sourceColors),
            neutralPalette: GetNeutralPalette(sourceColors),
            neutralVariantPalette: GetNeutralPalette(sourceColors),
            errorPalette: GetErrorPalette(sourceColors),
            platform,
            specVersion)
    {
        if (specVersion != SpecVersion.Spec2026)
            throw new ArgumentException($"Variant 'CMF' can only be used with SpecVersion 2026.");
    }

    public DynamicSchemeCmf(bool isDark,
        double contrastLevel,
        HctColor sourceColor,
        Platform platform = Platform.Phone,
        SpecVersion specVersion = SpecVersion.Spec2021)
        : this(isDark, contrastLevel, [sourceColor], platform, specVersion)
    {
    }

    private static TonalPalette GetPrimaryPalette(IEnumerable<HctColor> sourceColors)
        => TonalPalette.FromHct(sourceColors.First());
    private static TonalPalette GetSecondaryPalette(IEnumerable<HctColor> sourceColors)
    {
        var sourceColor = sourceColors.First();
        return TonalPalette.FromHueAndChroma(sourceColor.Hue, sourceColor.Chroma * 0.5);
    }
    private static TonalPalette GetTertiaryPalette(IEnumerable<HctColor> sourceColors)
    {
        var sourceColorsMaterialized = sourceColors.ToArray();
        var firstSourceColor = sourceColorsMaterialized[0];
        var secondSourceColor = sourceColorsMaterialized.Length > 1
            ? sourceColorsMaterialized[1]
            : firstSourceColor;

        return firstSourceColor == secondSourceColor
            ? TonalPalette.FromHueAndChroma(firstSourceColor.Hue, firstSourceColor.Chroma * 0.75)
            : TonalPalette.FromHct(secondSourceColor);
    }
    private static TonalPalette GetNeutralPalette(IEnumerable<HctColor> sourceColors)
    {
        var sourceColor = sourceColors.First();
        return TonalPalette.FromHueAndChroma(sourceColor.Hue, sourceColor.Chroma * 0.2);
    }
    private static TonalPalette GetErrorPalette(IEnumerable<HctColor> sourceColors)
    {
        var sourceColor = sourceColors.First();
        var chroma = Math.Max(sourceColor.Chroma, 50.0);
        return TonalPalette.FromHueAndChroma(23.0, chroma);
    }
}
