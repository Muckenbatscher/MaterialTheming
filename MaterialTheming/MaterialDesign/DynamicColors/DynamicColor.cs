using MaterialTheming.ColorDefinitions;
using MaterialTheming.MaterialDesign.DynamicColors.ColorSpecs;
using MaterialTheming.MaterialDesign.Palettes;

namespace MaterialTheming.MaterialDesign.DynamicColors;

internal class DynamicColor
{
    public string Name { get; }
    public Func<DynamicScheme, TonalPalette> Palette { get; }
    public Func<DynamicScheme, double> Tone { get; }
    public bool IsBackground { get; }
    public Func<DynamicScheme, double>? ChromaMultiplier { get; }
    public Func<DynamicScheme, DynamicColor?>? Background { get; }
    public Func<DynamicScheme, DynamicColor?>? SecondBackground { get; }
    public Func<DynamicScheme, ContrastCurve?>? ContrastCurve { get; }
    public Func<DynamicScheme, ToneDeltaPair?>? ToneDeltaPair { get; }
    public Func<DynamicScheme, double>? Opacity { get; }

    public DynamicColor(
        string name,
        Func<DynamicScheme, TonalPalette> palette,
        Func<DynamicScheme, double> tone,
        bool isBackground = false,
        Func<DynamicScheme, double>? chromaMultiplier = null,
        Func<DynamicScheme, DynamicColor?>? background = null,
        Func<DynamicScheme, DynamicColor?>? secondBackground = null,
        Func<DynamicScheme, ContrastCurve?>? contrastCurve = null,
        Func<DynamicScheme, ToneDeltaPair?>? toneDeltaPair = null,
        Func<DynamicScheme, double>? opacity = null)
    {
        Name = name;
        Palette = palette;
        Tone = tone;
        IsBackground = isBackground;
        ChromaMultiplier = chromaMultiplier;
        Background = background;
        SecondBackground = secondBackground;
        ContrastCurve = contrastCurve;
        ToneDeltaPair = toneDeltaPair;
        Opacity = opacity;

        // Validation logic ported from Java Builder.build()
        if (background == null && secondBackground != null)
        {
            throw new ArgumentException($"Color {name} has secondBackground defined, but background is not defined.");
        }
        if (background == null && contrastCurve != null)
        {
            throw new ArgumentException($"Color {name} has contrastCurve defined, but background is not defined.");
        }
        if (background != null && contrastCurve == null)
        {
            throw new ArgumentException($"Color {name} has background defined, but contrastCurve is not defined.");
        }
    }

    public HctColor GetHct(DynamicScheme scheme)
    {
        var colorSpec = ColorSpecFactory.Create(scheme.ColorSpecVersion);
        HctColor answer = colorSpec.GetHct(scheme, this);
        return answer;
    }

    public double GetTone(DynamicScheme scheme)
    {
        var colorSpec = ColorSpecFactory.Create(scheme.ColorSpecVersion);
        return colorSpec.GetTone(scheme, this);
    }
}
