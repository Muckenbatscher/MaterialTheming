using MaterialTheming.MaterialDesign.DynamicColors;
using MaterialTheming.MaterialDesign.DynamicColors.ColorSpecs;
using System.ComponentModel;

namespace MaterialTheming;

internal class ColorPaletteThemeBuilder : IColorPaletteThemeBuilder
{
    /// <summary>
    /// Creates a new instance of a <see cref="IColorPaletteThemeBuilder"/>, 
    /// initialized with the specified source color and the default settings.
    /// <para>
    /// Default settings include:<br/>
    /// <b>Mode </b>- light<br/>
    /// <b>Contrast level </b>- <c>0.0</c> (normal)<br/>
    /// <b>Variant </b>- Tonal Spot<br/>
    /// <b>Spec Version </b>- Spec 2021<br/>
    /// <b>Platform </b>- Phone<br/>
    /// </para>
    /// </summary>
    /// <remarks>The returned builder is preconfigured with default settings.
    /// It can be further customized by chaining additional configuration methods on the returned builder.</remarks>
    /// <param name="color">The source color in HCT representation to use as the basis for the palette.</param>
    /// <returns>An <see cref="IColorPaletteThemeBuilder"/> instance that can be used to further configure and build 
    /// a theme from a color palette based on the provided source color.</returns>
    public static IColorPaletteThemeBuilder CreateFromSourceColor(HctColor color)
        => new ColorPaletteThemeBuilder(color);

    /// <summary><inheritdoc cref="CreateFromSourceColor(HctColor)" path="/summary"/></summary>
    /// <remarks><inheritdoc cref="CreateFromSourceColor(HctColor)" path="/remarks"/></remarks>
    /// <param name="color">The source color in RGB representation to use as the basis for the palette.</param>
    /// <returns><inheritdoc cref="CreateFromSourceColor(HctColor)" path="/returns"/></returns>
    public static IColorPaletteThemeBuilder CreateFromSourceColor(RgbColor color)
    {
        var hctColor = HctColor.FromRgbColor(color);
        return new ColorPaletteThemeBuilder(hctColor);
    }

    /// <summary><inheritdoc cref="CreateFromSourceColor(HctColor)" path="/summary"/></summary>
    /// <remarks><inheritdoc cref="CreateFromSourceColor(HctColor)" path="/remarks"/></remarks>
    /// <param name="htmlColor">The source color to use as the basis for the palette. Formatted either as <c>#FFFFFF</c> or <c>FFFFFF</c></param>
    /// <returns><inheritdoc cref="CreateFromSourceColor(HctColor)" path="/returns"/></returns>
    public static IColorPaletteThemeBuilder CreateFromSourceColor(string htmlColor)
    {
        var rgbColor = RgbColor.FromHtml(htmlColor);
        return CreateFromSourceColor(rgbColor);
    }

    /// <summary>
    /// Creates a new instance of a <see cref="IColorPaletteThemeBuilder"/> initialized 
    /// with the specified first and second source color and the default settings.
    /// <para>
    /// Default settings include:<br/>
    /// <b>Mode </b>- light<br/>
    /// <b>Contrast level </b>- <c>0.0</c> (normal)<br/>
    /// <b>Variant </b>- CMF<br/>
    /// <b>Spec Version </b>- Spec 2026<br/>
    /// <b>Platform </b>- Phone<br/>
    /// </para>
    /// </summary>
    /// <remarks>The returned builder is preconfigured with default settings.
    /// It can be further customized by chaining additional configuration methods on the returned builder.<br/>
    /// The second source color is currently only taken into account when building a theme with <see cref="Variant.CMF"/>. 
    /// If the second source color is provided but the theme is built with a different variant or spec version, the second source color will be ignored."
    /// </remarks>
    /// <param name="firstSourceColor">The first source color in HCT representation to use as the basis for the palette.</param>
    /// <param name="secondSourceColor">The second source color in HCT representation to use as the basis for the palette.</param>
    /// <returns><inheritdoc cref="CreateFromSourceColor(HctColor)" path="/returns"/></returns>
    public static IColorPaletteThemeBuilder CreateFromSourceColors(HctColor firstSourceColor, HctColor secondSourceColor)
        => new ColorPaletteThemeBuilder(firstSourceColor, secondSourceColor)
            .WithVariant(Variant.CMF)
            .WithSpecVersion(SpecVersion.Spec2026);

    /// <summary><inheritdoc cref="CreateFromSourceColors(HctColor, HctColor)" path="/summary"/></summary>
    /// <remarks><inheritdoc cref="CreateFromSourceColors(HctColor, HctColor)" path="/remarks"/></remarks>
    /// <param name="firstSourceColor">The first source color in RGB representation to use as the basis for the palette.</param>
    /// <param name="secondSourceColor">The second source color in RGB representation to use as the basis for the palette.</param>
    /// <returns><inheritdoc cref="CreateFromSourceColors(HctColor, HctColor)" path="/returns"/></returns>
    public static IColorPaletteThemeBuilder CreateFromSourceColors(RgbColor firstSourceColor, RgbColor secondSourceColor)
        => CreateFromSourceColors(HctColor.FromRgbColor(firstSourceColor), HctColor.FromRgbColor(secondSourceColor));

    /// <summary><inheritdoc cref="CreateFromSourceColors(HctColor, HctColor)" path="/summary"/></summary>
    /// <remarks><inheritdoc cref="CreateFromSourceColors(HctColor, HctColor)" path="/remarks"/></remarks>
    /// <param name="firstSourceColorHtml">The first source color to use as the basis for the palette. Formatted either as <c>#FFFFFF</c> or <c>FFFFFF</c></param>
    /// <param name="secondSourceColorHtml">The second source color to use as the basis for the palette. Formatted either as <c>#FFFFFF</c> or <c>FFFFFF</c></param>
    /// <returns><inheritdoc cref="CreateFromSourceColors(HctColor, HctColor)" path="/returns"/></returns>
    public static IColorPaletteThemeBuilder CreateFromSourceColors(string firstSourceColorHtml, string secondSourceColorHtml)
        => CreateFromSourceColors(RgbColor.FromHtml(firstSourceColorHtml), RgbColor.FromHtml(secondSourceColorHtml));

    private ColorPaletteThemeBuilder(HctColor firstSourceColor, HctColor? secondSourceColor)
    {
        sourceColor = firstSourceColor;
        this.secondSourceColor = secondSourceColor;
        WithMode(ThemeMode.Light);
        WithContrastLevel(0.0);
        WithVariant(Variant.TonalSpot);
        WithSpecVersion(SpecVersion.Spec2021);
        WithPlatform(Platform.Phone);
    }
    private ColorPaletteThemeBuilder(HctColor sourceColor) : this(sourceColor, null)
    {
    }

    private HctColor sourceColor;
    private HctColor? secondSourceColor;

    private ThemeMode mode;
    private double contrastLevel;
    private Variant variant;
    private SpecVersion specVersion;
    private Platform platform;

    public IColorPaletteThemeBuilder WithSourceColor(HctColor color)
    {
        sourceColor = color;
        return this;
    }
    public IColorPaletteThemeBuilder WithSourceColor(RgbColor color) => WithSourceColor(HctColor.FromRgbColor(color));
    public IColorPaletteThemeBuilder WithSourceColor(string htmlColor) => WithSourceColor(RgbColor.FromHtml(htmlColor));

    public IColorPaletteThemeBuilder WithSecondSourceColor(HctColor color)
    {
        secondSourceColor = color;
        return this;
    }
    public IColorPaletteThemeBuilder WithSecondSourceColor(RgbColor color) => WithSecondSourceColor(HctColor.FromRgbColor(color));
    public IColorPaletteThemeBuilder WithSecondSourceColor(string htmlColor) => WithSecondSourceColor(RgbColor.FromHtml(htmlColor));

    public IColorPaletteThemeBuilder WithSourceColors(HctColor firstSourceColor, HctColor secondSourceColor)
        => WithSourceColor(firstSourceColor).WithSecondSourceColor(secondSourceColor);
    public IColorPaletteThemeBuilder WithSourceColors(RgbColor firstSourceColor, RgbColor secondSourceColor)
        => WithSourceColor(firstSourceColor).WithSecondSourceColor(secondSourceColor);
    public IColorPaletteThemeBuilder WithSourceColors(string firstSourceColorHtml, string secondSourceColorHtml)
        => WithSourceColor(firstSourceColorHtml).WithSecondSourceColor(secondSourceColorHtml);

    public IColorPaletteThemeBuilder WithMode(ThemeMode mode)
    {
        this.mode = mode;
        return this;
    }
    public IColorPaletteThemeBuilder WithContrastLevel(ContrastLevel contrastLevel)
    {
        var contrastLevelValue = contrastLevel switch
        {
            ContrastLevel.Normal => 0.0,
            ContrastLevel.Medium => 0.5,
            ContrastLevel.High => 1.0,
            _ => throw new InvalidEnumArgumentException(nameof(contrastLevel), (int)contrastLevel, typeof(ContrastLevel))
        };
        return WithContrastLevel(contrastLevelValue);
    }
    public IColorPaletteThemeBuilder WithContrastLevel(double contrastLevel)
    {
        this.contrastLevel = contrastLevel;
        return this;
    }

    public IColorPaletteThemeBuilder WithVariant(Variant variant)
    {
        this.variant = variant;
        return this;
    }
    public IColorPaletteThemeBuilder WithPlatform(Platform platform)
    {
        this.platform = platform;
        return this;
    }
    public IColorPaletteThemeBuilder WithSpecVersion(SpecVersion specVersion)
    {
        this.specVersion = specVersion;
        return this;
    }

    public ThemeColors Build() => BuildThemeColors();

    private ThemeColors BuildThemeColors()
    {
        var specVersionToUse = GetFallbackSpecVersionToUse(specVersion, variant);
        var colorSpec = ColorSpecFactory.Create(specVersionToUse);
        bool isDark = mode == ThemeMode.Dark;

        var sourceColors = new List<HctColor> { sourceColor };
        if (secondSourceColor is not null)
            sourceColors.Add(secondSourceColor);

        DynamicScheme dynamicScheme = variant == Variant.CMF
            ? new DynamicSchemeCmf(isDark, contrastLevel, sourceColors, platform, specVersionToUse)
            : new DynamicSchemeColorSpecPalette(variant, isDark, contrastLevel, sourceColor, platform, specVersionToUse);

        return CreateThemeColorFromScheme(dynamicScheme);
    }

    private static SpecVersion GetFallbackSpecVersionToUse(SpecVersion desiredSpecVersion, Variant variant)
    {
        var specVersionToUs = desiredSpecVersion;

        IEnumerable<Variant> spec2026implementedVariants =
            [Variant.CMF];
        IEnumerable<Variant> spec2025implementedVariants =
            [Variant.TonalSpot, Variant.Neutral, Variant.Expressive, Variant.Vibrant];

        specVersionToUs = GetFallbackSpecVersion(specVersionToUs, variant, SpecVersion.Spec2026, spec2026implementedVariants, SpecVersion.Spec2025);
        specVersionToUs = GetFallbackSpecVersion(specVersionToUs, variant, SpecVersion.Spec2025, spec2025implementedVariants, SpecVersion.Spec2021);

        return specVersionToUs;
    }
    private static SpecVersion GetFallbackSpecVersion(SpecVersion desiredSpecVersion, Variant variant,
        SpecVersion validatingSpecVersion,
        IEnumerable<Variant> validatingSpecImplementedVariants,
        SpecVersion fallbackWhenNotImplementedSpecVersion)
    {
        var variantIsImplementedInSpec = validatingSpecImplementedVariants.Contains(variant);
        var fallbackRequired = desiredSpecVersion == validatingSpecVersion && !variantIsImplementedInSpec;

        return fallbackRequired
            ? fallbackWhenNotImplementedSpecVersion
            : desiredSpecVersion;
    }

    private static ThemeColors CreateThemeColorFromScheme(DynamicScheme scheme)
    {
        return new ThemeColors()
        {
            Primary = scheme.Primary.ToRgbColor(),
            OnPrimary = scheme.OnPrimary.ToRgbColor(),
            PrimaryContainer = scheme.PrimaryContainer.ToRgbColor(),
            OnPrimaryContainer = scheme.OnPrimaryContainer.ToRgbColor(),

            Secondary = scheme.Secondary.ToRgbColor(),
            OnSecondary = scheme.OnSecondary.ToRgbColor(),
            SecondaryContainer = scheme.SecondaryContainer.ToRgbColor(),
            OnSecondaryContainer = scheme.OnSecondaryContainer.ToRgbColor(),

            Tertiary = scheme.Tertiary.ToRgbColor(),
            OnTertiary = scheme.OnTertiary.ToRgbColor(),
            TertiaryContainer = scheme.TertiaryContainer.ToRgbColor(),
            OnTertiaryContainer = scheme.OnTertiaryContainer.ToRgbColor(),

            Error = scheme.Error.ToRgbColor(),
            OnError = scheme.OnError.ToRgbColor(),
            ErrorContainer = scheme.ErrorContainer.ToRgbColor(),
            OnErrorContainer = scheme.OnErrorContainer.ToRgbColor(),

            Surface = scheme.Surface.ToRgbColor(),
            SurfaceVariant = scheme.SurfaceVariant.ToRgbColor(),
            OnSurface = scheme.OnSurface.ToRgbColor(),
            OnSurfaceVariant = scheme.OnSurfaceVariant.ToRgbColor(),
            SurfaceDim = scheme.SurfaceDim.ToRgbColor(),
            SurfaceBright = scheme.SurfaceBright.ToRgbColor(),
            SurfaceTint = scheme.SurfaceTint.ToRgbColor(),

            Background = scheme.Background.ToRgbColor(),
            OnBackground = scheme.OnBackground.ToRgbColor(),

            Outline = scheme.Outline.ToRgbColor(),
            OutlineVariant = scheme.OutlineVariant.ToRgbColor(),

            Shadow = scheme.Shadow.ToRgbColor(),
            Scrim = scheme.Scrim.ToRgbColor(),

            InverseSurface = scheme.InverseSurface.ToRgbColor(),
            InverseOnSurface = scheme.InverseOnSurface.ToRgbColor(),
            InversePrimary = scheme.InversePrimary.ToRgbColor(),

            PrimaryFixed = scheme.PrimaryFixed.ToRgbColor(),
            OnPrimaryFixed = scheme.OnPrimaryFixed.ToRgbColor(),
            PrimaryFixedDim = scheme.PrimaryFixedDim.ToRgbColor(),
            OnPrimaryFixedVariant = scheme.OnPrimaryFixedVariant.ToRgbColor(),

            SecondaryFixed = scheme.SecondaryFixed.ToRgbColor(),
            OnSecondaryFixed = scheme.OnSecondaryFixed.ToRgbColor(),
            SecondaryFixedDim = scheme.SecondaryFixedDim.ToRgbColor(),
            OnSecondaryFixedVariant = scheme.OnSecondaryFixedVariant.ToRgbColor(),

            TertiaryFixed = scheme.TertiaryFixed.ToRgbColor(),
            OnTertiaryFixed = scheme.OnTertiaryFixed.ToRgbColor(),
            TertiaryFixedDim = scheme.TertiaryFixedDim.ToRgbColor(),
            OnTertiaryFixedVariant = scheme.OnTertiaryFixedVariant.ToRgbColor(),

            SurfaceContainerLowest = scheme.SurfaceContainerLowest.ToRgbColor(),
            SurfaceContainerLow = scheme.SurfaceContainerLow.ToRgbColor(),
            SurfaceContainer = scheme.SurfaceContainer.ToRgbColor(),
            SurfaceContainerHigh = scheme.SurfaceContainerHigh.ToRgbColor(),
            SurfaceContainerHighest = scheme.SurfaceContainerHighest.ToRgbColor(),
        };
    }
}
