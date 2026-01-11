using MaterialTheming.MaterialDesign.Contrasts;
using MaterialTheming.MaterialDesign.Palettes;

namespace MaterialTheming.MaterialDesign.DynamicColors;

internal class DynamicColorBuilder
{
    private string? name;
    private Func<DynamicScheme, TonalPalette>? palette;
    private Func<DynamicScheme, double>? tone;
    private bool? isBackground = false;
    private Func<DynamicScheme, double?>? chromaMultiplier;
    private Func<DynamicScheme, DynamicColor?>? background;
    private Func<DynamicScheme, DynamicColor?>? secondBackground;
    private Func<DynamicScheme, ContrastCurve?>? contrastCurve;
    private Func<DynamicScheme, ToneDeltaPair?>? toneDeltaPair;
    private Func<DynamicScheme, double?>? opacity;

    private DynamicColorBuilder() { }

    public static DynamicColorBuilder Create() => new DynamicColorBuilder();
    public static DynamicColorBuilder Create(DynamicColor dynamicColor)
    {
        return Create()
            .WithName(dynamicColor.Name)
            .WithPalette(dynamicColor.Palette)
            .WithTone(dynamicColor.Tone)
            .WithIsBackground(dynamicColor.IsBackground)
            .WithChromaMultiplier(dynamicColor.ChromaMultiplier)
            .WithBackground(dynamicColor.Background)
            .WithSecondBackground(dynamicColor.SecondBackground)
            .WithContrastCurve(dynamicColor.ContrastCurve)
            .WithToneDeltaPair(dynamicColor.ToneDeltaPair)
            .WithOpacity(dynamicColor.Opacity);
    }
    public static DynamicColorBuilder Create(DynamicColorBuilder dynamicColorBuilder)
    {
        if (dynamicColorBuilder.name == null)
            throw new InvalidOperationException($"Name must be set in the {nameof(dynamicColorBuilder)}.");

        return Create()
            .WithName(dynamicColorBuilder.name)
            .WithPalette(dynamicColorBuilder.palette)
            .WithTone(dynamicColorBuilder.tone)
            .WithIsBackground(dynamicColorBuilder.isBackground)
            .WithBackground(dynamicColorBuilder.background)
            .WithSecondBackground(dynamicColorBuilder.secondBackground)
            .WithContrastCurve(dynamicColorBuilder.contrastCurve)
            .WithToneDeltaPair(dynamicColorBuilder.toneDeltaPair)
            .WithOpacity(dynamicColorBuilder.opacity);
    }

    public DynamicColor Build()
    {
        if (name == null)
            throw new InvalidOperationException("Name must be set.");
        if (palette == null)
            throw new InvalidOperationException($"Color {name} has no palette set.");

        if (background == null && secondBackground != null)
            throw new InvalidOperationException(
                $"Color {name} has secondBackground defined, but background is not defined.");

        if (background == null && contrastCurve != null)
            throw new InvalidOperationException(
                $"Color {name} has contrastCurve defined, but background is not defined.");

        if (background != null && contrastCurve == null)
            throw new InvalidOperationException(
                $"Color {name} has background defined, but contrastCurve is not defined.");

        return new DynamicColor(name: name,
            palette: palette,
            tone: tone ?? ForegroundToneCalculation.GetInitialToneFromBackground(background),
            isBackground: isBackground ?? false,
            chromaMultiplier: chromaMultiplier,
            background: background,
            secondBackground: secondBackground,
            contrastCurve: contrastCurve,
            toneDeltaPair: toneDeltaPair,
            opacity: opacity);
    }

    public DynamicColorBuilder WithName(string name)
    {
        this.name = name;
        return this;
    }
    public DynamicColorBuilder WithPalette(Func<DynamicScheme, TonalPalette>? palette)
    {
        this.palette = palette;
        return this;
    }
    public DynamicColorBuilder WithTone(Func<DynamicScheme, double>? tone)
    {
        this.tone = tone;
        return this;
    }
    public DynamicColorBuilder WithIsBackground(bool? isBackground)
    {
        this.isBackground = isBackground;
        return this;
    }
    public DynamicColorBuilder WithChromaMultiplier(Func<DynamicScheme, double?>? chromaMultiplier)
    {
        this.chromaMultiplier = chromaMultiplier;
        return this;
    }
    public DynamicColorBuilder WithBackground(Func<DynamicScheme, DynamicColor?>? background)
    {
        this.background = background;
        return this;
    }
    public DynamicColorBuilder WithSecondBackground(Func<DynamicScheme, DynamicColor?>? secondBackground)
    {
        this.secondBackground = secondBackground;
        return this;
    }
    public DynamicColorBuilder WithContrastCurve(Func<DynamicScheme, ContrastCurve?>? contrastCurve)
    {
        this.contrastCurve = contrastCurve;
        return this;
    }
    public DynamicColorBuilder WithToneDeltaPair(Func<DynamicScheme, ToneDeltaPair?>? toneDeltaPair)
    {
        this.toneDeltaPair = toneDeltaPair;
        return this;
    }
    public DynamicColorBuilder WithOpacity(Func<DynamicScheme, double?>? opacity)
    {
        this.opacity = opacity;
        return this;
    }
}
