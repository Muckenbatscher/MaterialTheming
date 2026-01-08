using MaterialTheming.ColorDefinitions;
using MaterialTheming.MaterialDesign;
using MaterialTheming.MaterialDesign.DynamicColors;
using MaterialTheming.MaterialDesign.DynamicColors.ColorSpecs;
using System.ComponentModel;

namespace MaterialTheming.Creation;

public class ColorPaletteThemeBuilder : IColorPaletteThemeBuilder
{
    public static IColorPaletteThemeBuilder Create() => new ColorPaletteThemeBuilder();

    public static IColorPaletteThemeBuilder CreateFromSourceColor(string htmlColor)
        => Create().WithPrimaryColor(c => c.WithBaseColor(htmlColor));
    public static IColorPaletteThemeBuilder CreateFromSourceColor(RgbColor color)
        => Create().WithPrimaryColor(c => c.WithBaseColor(color));
    public static IColorPaletteThemeBuilder CreateFromSourceColor(HctColor color)
        => Create().WithPrimaryColor(c => c.WithBaseColor(color));

    private ColorPaletteThemeBuilder()
    {
        _primaryColorSpec = new ColorPaletteSpecification(ColorPaletteType.Primary);
        _secondaryColorSpec = new NonPrimaryColorPaletteSpecification(ColorPaletteType.Secondary);
        _tertiaryColorSpec = new NonPrimaryColorPaletteSpecification(ColorPaletteType.Tertiary);
        _errorColorSpec = new NonPrimaryColorPaletteSpecification(ColorPaletteType.Error);
        _neutralColorSpec = new NonPrimaryColorPaletteSpecification(ColorPaletteType.Neutral);
        _neutralVariantColorSpec = new NonPrimaryColorPaletteSpecification(ColorPaletteType.NeutralVariant);

        mode = ThemeMode.Light;
        contrastLevel = 0.0;
        variant = Variant.TonalSpot;
        platform = Platform.Phone;
        specVersion = SpecVersion.Spec2021;
    }

    private readonly ColorPaletteSpecification _primaryColorSpec;
    private readonly NonPrimaryColorPaletteSpecification _secondaryColorSpec;
    private readonly NonPrimaryColorPaletteSpecification _tertiaryColorSpec;
    private readonly NonPrimaryColorPaletteSpecification _errorColorSpec;
    private readonly NonPrimaryColorPaletteSpecification _neutralColorSpec;
    private readonly NonPrimaryColorPaletteSpecification _neutralVariantColorSpec;

    private ThemeMode mode;
    private double contrastLevel;
    private Variant variant;
    private Platform platform;
    private SpecVersion specVersion;

    public IColorPaletteThemeBuilder WithPrimaryColor(Action<IColorPaletteSpecification> colorSpecificationOptions)
    {
        colorSpecificationOptions(_primaryColorSpec);
        return this;
    }
    public IColorPaletteThemeBuilder WithSecondaryColor(Action<INonPrimaryColorPaletteSpecification> colorSpecificationOptions)
    {
        colorSpecificationOptions(_secondaryColorSpec);
        return this;
    }
    public IColorPaletteThemeBuilder WithTertiaryolor(Action<INonPrimaryColorPaletteSpecification> colorSpecificationOptions)
    {
        colorSpecificationOptions(_tertiaryColorSpec);
        return this;
    }
    public IColorPaletteThemeBuilder WithErrorColor(Action<INonPrimaryColorPaletteSpecification> colorSpecificationOptions)
    {
        colorSpecificationOptions(_errorColorSpec);
        return this;
    }
    public IColorPaletteThemeBuilder WithNeutralColor(Action<INonPrimaryColorPaletteSpecification> colorSpecificationOptions)
    {
        colorSpecificationOptions(_neutralColorSpec);
        return this;

    }
    public IColorPaletteThemeBuilder WithNeutralVariantColor(Action<INonPrimaryColorPaletteSpecification> colorSpecificationOptions)
    {
        colorSpecificationOptions(_neutralVariantColorSpec);
        return this;
    }

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
        if (!_primaryColorSpec.BaseColorSpecified)
            throw new InvalidOperationException("Primary color must be specified.");

        var primaryColorHct = HctColor.FromRgbColor(_primaryColorSpec.BaseColor);

        bool isDark = mode == ThemeMode.Dark;
        var colorSpec = ColorSpecFactory.Create(specVersion);

        var primaryPalette = colorSpec.GetPrimaryPalette(variant, primaryColorHct, isDark, platform, contrastLevel);
        var secondaryPalette = colorSpec.GetSecondaryPalette(variant, primaryColorHct, isDark, platform, contrastLevel);
        var tertiaryPalette = colorSpec.GetTertiaryPalette(variant, primaryColorHct, isDark, platform, contrastLevel);
        var errorPalette = colorSpec.GetErrorPalette(variant, primaryColorHct, isDark, platform, contrastLevel);
        var neutralPalette = colorSpec.GetNeutralPalette(variant, primaryColorHct, isDark, platform, contrastLevel);
        var neutralVariantPalette = colorSpec.GetNeutralVariantPalette(variant, primaryColorHct, isDark, platform, contrastLevel);

        var scheme = new DynamicScheme(variant, mode == ThemeMode.Dark, contrastLevel,
            primaryPalette, secondaryPalette, tertiaryPalette,
            neutralPalette, neutralVariantPalette, errorPalette);
        return CreateThemeColorFromScheme(scheme);
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
