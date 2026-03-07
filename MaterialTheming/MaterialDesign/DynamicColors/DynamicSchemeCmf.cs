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
        SpecVersion specVersion = SpecVersion.Spec2026)
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
        var hue = GetErrorHue(sourceColors);
        var sourceColor = sourceColors.First();
        var chroma = Math.Max(sourceColor.Chroma, 50.0);
        return TonalPalette.FromHueAndChroma(hue, chroma);
    }

    private static double GetErrorHue(IEnumerable<HctColor> sourceColors)
    {
        var firstSourceColorHue = sourceColors.First().Hue;
        var tertiaryHue = GetTertiaryPalette(sourceColors).Hue;
        return firstSourceColorHue switch
        {
            <= 8 => tertiaryHue <= 24 ? 28 : tertiaryHue <= 32 ? 16 : 20,
            <= 16 => tertiaryHue <= 24 ? 32 : tertiaryHue <= 32 ? 20 : 24,
            <= 20 => tertiaryHue <= 28 ? 32 : tertiaryHue <= 32 ? 24 : 28,
            <= 28 => tertiaryHue <= 24 ? 32 : 16,
            <= 32 => tertiaryHue <= 20 ? 24 : tertiaryHue <= 28 ? 16 : 20,
            <= 40 => tertiaryHue > 20 && tertiaryHue <= 28 ? 16 : 24,
            <= 152 => tertiaryHue > 24 && tertiaryHue <= 36 ? 20 : 32,
            <= 272 => tertiaryHue > 20 && tertiaryHue <= 28 ? 16 : 24,
            _ => tertiaryHue > 12 && tertiaryHue <= 28 ? 32 : 16
        };
    }
}
