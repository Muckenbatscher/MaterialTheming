using MaterialTheming.ColorDefinitions;
using MaterialTheming.MaterialDesign;
using MaterialTheming.MaterialDesign.DynamicColors;
using MaterialTheming.MaterialDesign.DynamicColors.ColorSpecs;
using System.ComponentModel;

namespace MaterialTheming.Creation;

public class ColorPaletteThemeBuilder : IColorPaletteThemeBuilder
{
    public static IColorPaletteThemeBuilder Create() => new ColorPaletteThemeBuilder();

    public static IColorPaletteThemeBuilder CreateFromSourceColor(HctColor color)
        => Create().WithSourceColor(color);
    public static IColorPaletteThemeBuilder CreateFromSourceColor(RgbColor color)
        => Create().WithSourceColor(color);
    public static IColorPaletteThemeBuilder CreateFromSourceColor(string htmlColor)
        => Create().WithSourceColor(htmlColor);

    private ColorPaletteThemeBuilder()
    {
        mode = ThemeMode.Light;
        contrastLevel = 0.0;
        variant = Variant.TonalSpot;
        platform = Platform.Phone;
        specVersion = SpecVersion.Spec2021;
    }
    private HctColor? sourceColor;

    private ThemeMode mode;
    private double contrastLevel;
    private Variant variant;
    private Platform platform;
    private SpecVersion specVersion;

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
            throw new InvalidOperationException("Primary color must be specified.");

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
            OnSurface = scheme.OnSurface.ToRgbColor(),
            OnSurfaceVariant = scheme.OnSurfaceVariant.ToRgbColor(),

            SurfaceContainerLowest = scheme.SurfaceContainerLowest.ToRgbColor(),
            SurfaceContainerLow = scheme.SurfaceContainerLow.ToRgbColor(),
            SurfaceContainer = scheme.SurfaceContainer.ToRgbColor(),
            SurfaceContainerHigh = scheme.SurfaceContainerHigh.ToRgbColor(),
            SurfaceContainerHighest = scheme.SurfaceContainerHighest.ToRgbColor(),
        };
    }
}
