using MaterialTheming.MaterialDesign.DynamicColors;
using MaterialTheming.MaterialDesign.DynamicColors.ColorSpecs;
using System.ComponentModel;

namespace MaterialTheming.Creation;

internal class ColorPaletteThemeBuilder : IColorPaletteThemeBuilder
{
    /// <summary>
    /// Creates a new instance of a <see cref="IColorPaletteThemeBuilder"/> with default settings.
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
    /// It can be further customized by chaining additional configuration methods on the returned builder.
    /// A source color is required to be specified.</remarks>
    /// <returns>An <see cref="IColorPaletteThemeBuilder"/> instance that can be used to configure and build a theme from a color palette.</returns>
    public static IColorPaletteThemeBuilder Create()
        => new ColorPaletteThemeBuilder()
        .WithMode(ThemeMode.Light)
        .WithContrastLevel(0.0)
        .WithVariant(Variant.TonalSpot)
        .WithSpecVersion(SpecVersion.Spec2021)
        .WithPlatform(Platform.Phone);

    /// <summary>
    /// Creates a new instance of a <see cref="IColorPaletteThemeBuilder"/> initialized 
    /// with the specified source color and the default settings.
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
        => Create().WithSourceColor(color);

    /// <summary>
    /// Creates a new instance of a <see cref="IColorPaletteThemeBuilder"/> initialized 
    /// with the specified source color and the default settings.
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
    /// <param name="color">The source color in RGB representation to use as the basis for the palette.</param>
    /// <returns>An <see cref="IColorPaletteThemeBuilder"/> instance that can be used to further configure and build 
    /// a theme from a color palette based on the provided source color.</returns>
    public static IColorPaletteThemeBuilder CreateFromSourceColor(RgbColor color)
        => Create().WithSourceColor(color);

    /// <summary>
    /// Creates a new instance of a <see cref="IColorPaletteThemeBuilder"/> initialized 
    /// with the specified source color and the default settings.
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
    /// <param name="htmlColor">The source color to use as the basis for the palette. Formatted either as <c>#FFFFFF</c> or <c>FFFFFF</c></param>
    /// <returns>An <see cref="IColorPaletteThemeBuilder"/> instance that can be used to further configure and build 
    /// a theme from a color palette based on the provided source color.</returns>
    public static IColorPaletteThemeBuilder CreateFromSourceColor(string htmlColor)
        => Create().WithSourceColor(htmlColor);

    private ColorPaletteThemeBuilder()
    {
    }

    private HctColor? sourceColor;

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

    public Theme Build()
    {
        var themeColors = BuildThemeColors();
        return new Theme(
            isDark: mode == ThemeMode.Dark,
            colors: themeColors);
    }

    private ThemeColors BuildThemeColors()
    {
        if (sourceColor == null)
            throw new InvalidOperationException("Source color must be specified.");

        var specVersionToUse = GetFallbackSpecVersionToUse(specVersion, variant);
        var colorSpec = ColorSpecFactory.Create(specVersionToUse);
        bool isDark = mode == ThemeMode.Dark;

        var primaryPalette = colorSpec.GetPrimaryPalette(variant, sourceColor, isDark, platform, contrastLevel);
        var secondaryPalette = colorSpec.GetSecondaryPalette(variant, sourceColor, isDark, platform, contrastLevel);
        var tertiaryPalette = colorSpec.GetTertiaryPalette(variant, sourceColor, isDark, platform, contrastLevel);
        var errorPalette = colorSpec.GetErrorPalette(variant, sourceColor, isDark, platform, contrastLevel);
        var neutralPalette = colorSpec.GetNeutralPalette(variant, sourceColor, isDark, platform, contrastLevel);
        var neutralVariantPalette = colorSpec.GetNeutralVariantPalette(variant, sourceColor, isDark, platform, contrastLevel);

        var scheme = new DynamicScheme(variant, isDark, contrastLevel, sourceColor,
            primaryPalette, secondaryPalette, tertiaryPalette,
            neutralPalette, neutralVariantPalette, errorPalette,
            platform: platform,
            specVersion: specVersionToUse);
        return CreateThemeColorFromScheme(scheme);
    }

    private static SpecVersion GetFallbackSpecVersionToUse(SpecVersion desiredSpecVersion, Variant variant)
    {
        IEnumerable<Variant> spec2025implementedVariants =
            [Variant.TonalSpot, Variant.Neutral, Variant.Expressive, Variant.Vibrant];
        var variantIsImplementedInSpec2025 = spec2025implementedVariants.Contains(variant);

        return desiredSpecVersion == SpecVersion.Spec2025 && variantIsImplementedInSpec2025
            ? desiredSpecVersion
            : SpecVersion.Spec2021;
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
