using MaterialTheming.MaterialDesign.Contrasts;
using MaterialTheming.MaterialDesign.Palettes;

namespace MaterialTheming.MaterialDesign.DynamicColors;

internal class DynamicColorBuilder
{
    private DynamicColorBuilder() { }

    public static DynamicColorBuilder Create() => new DynamicColorBuilder();
    public static DynamicColorBuilder Create(DynamicColor dynamicColor)
    {
        return Create()
            .WithName(dynamicColor.Name)
            .WithPalette(dynamicColor.Palette)
            .WithTone(s => dynamicColor.Tone.Invoke(s))
            .WithIsBackground(dynamicColor.IsBackground)
            .WithChromaMultiplier(dynamicColor.ChromaMultiplier)
            .WithBackground(dynamicColor.Background)
            .WithSecondBackground(dynamicColor.SecondBackground)
            .WithContrastCurve(dynamicColor.ContrastCurve)
            .WithToneDeltaPair(dynamicColor.ToneDeltaPair)
            .WithOpacity(dynamicColor.Opacity);
    }

    private string? name;
    private Func<DynamicScheme, TonalPalette>? palette;
    private Func<DynamicScheme, double>? tone;
    private bool isBackground = false;
    private Func<DynamicScheme, double?>? chromaMultiplier;
    private Func<DynamicScheme, DynamicColor?>? background;
    private Func<DynamicScheme, DynamicColor?>? secondBackground;
    private Func<DynamicScheme, ContrastCurve?>? contrastCurve;
    private Func<DynamicScheme, ToneDeltaPair?>? toneDeltaPair;
    private Func<DynamicScheme, double?>? opacity;

    public DynamicColor Build()
    {
        if (name == null)
            throw new InvalidOperationException("Name must be set.");
        if (palette == null)
            throw new InvalidOperationException($"Color {name} has no palette set.");
        if (background == null && secondBackground != null)
        {
            throw new InvalidOperationException(
                $"Color {name} has secondBackground defined, but background is not defined.");
        }
        if (background == null && contrastCurve != null)
        {
            throw new InvalidOperationException(
                $"Color {name} has contrastCurve defined, but background is not defined.");
        }
        if (background != null && contrastCurve == null)
        {
            throw new InvalidOperationException(
                "Color {name} has background defined, but contrastCurve is not defined.");
        }

        var toneFunc = tone ?? ForegroundToneCalculation.GetInitialToneFromBackground(background);
        return new DynamicColor(name: name,
            palette: palette,
            tone: toneFunc,
            isBackground: isBackground,
            chromaMultiplier: chromaMultiplier,
            background: background,
            secondBackground: secondBackground,
            contrastCurve: contrastCurve,
            toneDeltaPair: toneDeltaPair,
            opacity: opacity);
    }

    public DynamicColorBuilder WithSpecExtension(SpecVersion specVersion, DynamicColor extendedColor)
    {
        return Create()
            .WithName(name!)
            .WithIsBackground(isBackground)
            .WithPalette(s =>
            {
                var function = s.ColorSpecVersion == specVersion
                    ? extendedColor.Palette
                    : this.palette;
                return function?.Invoke(s)!;
            })
            .WithTone(s =>
            {
                var function = s.ColorSpecVersion == specVersion
                    ? extendedColor.Tone
                    : this.tone;
                return function?.Invoke(s);
            })
            .WithChromaMultiplier(s =>
            {
                var function = s.ColorSpecVersion == specVersion
                    ? extendedColor.ChromaMultiplier
                    : this.chromaMultiplier;
                return function?.Invoke(s);
            })
            .WithBackground(s =>
            {
                var function = s.ColorSpecVersion == specVersion
                    ? extendedColor.Background
                    : this.background;
                return function?.Invoke(s);
            })
            .WithSecondBackground(s =>
            {
                var function = s.ColorSpecVersion == specVersion
                    ? extendedColor.SecondBackground
                    : this.secondBackground;
                return function?.Invoke(s);
            })
            .WithContrastCurve(s =>
            {
                var function = s.ColorSpecVersion == specVersion
                    ? extendedColor.ContrastCurve
                    : this.contrastCurve;
                return function?.Invoke(s);
            })
            .WithToneDeltaPair(s =>
            {
                var function = s.ColorSpecVersion == specVersion
                    ? extendedColor.ToneDeltaPair
                    : this.toneDeltaPair;
                return function?.Invoke(s);
            })
            .WithOpacity(s =>
            {
                var function = s.ColorSpecVersion == specVersion
                    ? extendedColor.Opacity
                    : this.opacity;
                return function?.Invoke(s);
            });
    }
    private static Func<DynamicScheme, T>? GetFunc<T>(DynamicScheme scheme, SpecVersion specVersion,
        Func<DynamicScheme, T?>? extendedColorFunc,
        Func<DynamicScheme, T?>? thisFunc)
    {
        var function = scheme.ColorSpecVersion == specVersion
            ? extendedColorFunc
            : thisFunc;
        if (function == null)
            return null;

        return s => function.Invoke(s)!;
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
    public DynamicColorBuilder WithTone(Func<DynamicScheme, double?>? tone)
    {
        this.tone = s => tone?.Invoke(s) ?? throw new InvalidOperationException();
        return this;
    }
    public DynamicColorBuilder WithIsBackground(bool isBackground)
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
