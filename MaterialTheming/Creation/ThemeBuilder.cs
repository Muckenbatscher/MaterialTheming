using MaterialTheming.ColorDefinitions;
using MaterialTheming.MaterialDesign;
using MaterialTheming.MaterialDesign.DynamicColors;
using MaterialTheming.MaterialDesign.Palettes;
using MaterialTheming.MaterialThemeBuilderConversion;
using System.ComponentModel;

namespace MaterialTheming.Creation;

public class ThemeBuilder : IThemeBuilder
{
    public static ThemeBuilder Create() => new ThemeBuilder();

    private ThemeBuilder()
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
    }

    private readonly ColorPaletteSpecification _primaryColorSpec;
    private readonly NonPrimaryColorPaletteSpecification _secondaryColorSpec;
    private readonly NonPrimaryColorPaletteSpecification _tertiaryColorSpec;
    private readonly NonPrimaryColorPaletteSpecification _errorColorSpec;
    private readonly NonPrimaryColorPaletteSpecification _neutralColorSpec;
    private readonly NonPrimaryColorPaletteSpecification _neutralVariantColorSpec;

    private string? materialThemeBuilderJson;

    private ThemeMode mode;
    private double contrastLevel;
    private Variant variant;
    private Platform platform;

    public IThemeBuilder WithPrimaryColor(Action<IColorPaletteSpecification> colorSpecificationOptions)
    {
        colorSpecificationOptions(_primaryColorSpec);
        return this;
    }
    public IThemeBuilder WithSecondaryColor(Action<INonPrimaryColorPaletteSpecification> colorSpecificationOptions)
    {
        colorSpecificationOptions(_secondaryColorSpec);
        return this;
    }
    public IThemeBuilder WithTertiaryolor(Action<INonPrimaryColorPaletteSpecification> colorSpecificationOptions)
    {
        colorSpecificationOptions(_tertiaryColorSpec);
        return this;
    }
    public IThemeBuilder WithErrorColor(Action<INonPrimaryColorPaletteSpecification> colorSpecificationOptions)
    {
        colorSpecificationOptions(_errorColorSpec);
        return this;
    }
    public IThemeBuilder WithNeutralColor(Action<INonPrimaryColorPaletteSpecification> colorSpecificationOptions)
    {
        colorSpecificationOptions(_neutralColorSpec);
        return this;

    }
    public IThemeBuilder WithNeutralVariantColor(Action<INonPrimaryColorPaletteSpecification> colorSpecificationOptions)
    {
        colorSpecificationOptions(_neutralVariantColorSpec);
        return this;
    }

    public IThemeBuilder WithMaterialThemeBuilderJson(string materialThemeBuilderJson)
    {
        this.materialThemeBuilderJson = materialThemeBuilderJson;
        return this;
    }
    public IThemeBuilder WithMaterialThemeBuilderJsonFile(string materialThemeBuilderJsonFilePath)
    {
        var fileContents = File.ReadAllText(materialThemeBuilderJsonFilePath);
        materialThemeBuilderJson = fileContents;
        return this;
    }

    public IThemeBuilder WithMode(ThemeMode mode)
    {
        this.mode = mode;
        return this;
    }

    public IThemeBuilder WithContrastLevel(ContrastLevel contrastLevel)
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
    public IThemeBuilder WithContrastLevel(double contrastLevel)
    {
        this.contrastLevel = contrastLevel;
        return this;
    }

    public IThemeBuilder WithVariant(Variant variant)
    {
        this.variant = variant;
        return this;
    }
    public IThemeBuilder WithPlatform(Platform platform)
    {
        this.platform = platform;
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
        return materialThemeBuilderJson != null
            ? BuildThemeColorsFromMaterialDesignJson()
            : BuildThemeColorsFromColorSpecifications();
    }
    private ThemeColors BuildThemeColorsFromMaterialDesignJson()
    {
        return MaterialThemeBuilderThemeColorsExtractor.CreateFromMaterialDesignJson(materialThemeBuilderJson!, mode, ContrastLevel.Normal);
    }
    private ThemeColors BuildThemeColorsFromColorSpecifications()
    {
        if (!_primaryColorSpec.BaseColorSpecified)
            throw new InvalidOperationException("Primary color must be specified.");

        var primaryColorHct = HctColor.FromRgbColor(_primaryColorSpec.BaseColor);

        bool isDark = mode == ThemeMode.Dark;
        var primaryPalette = ColorSpec2025.GetPrimaryPalette(variant, primaryColorHct, isDark, platform);
        var secondaryPalette = ColorSpec2025.GetSecondaryPalette(variant, primaryColorHct, isDark, platform);
        var tertiaryPalette = ColorSpec2025.GetTertiaryPalette(variant, primaryColorHct, platform);
        var errorPalette = ColorSpec2025.GetErrorPalette(variant, primaryColorHct, platform);
        var neutralPalette = ColorSpec2025.GetNeutralPalette(variant, primaryColorHct, isDark, platform);
        var neutralVariantPalette = ColorSpec2025.GetNeutralVariantPalette(variant, primaryColorHct, isDark, platform);

        
        var scheme = new DynamicScheme(variant, mode == ThemeMode.Dark, contrastLevel,
            primaryPalette, secondaryPalette, tertiaryPalette,
            neutralPalette, neutralVariantPalette, errorPalette);
        return CreateThemeColorFromScheme(scheme);
    }

    private TonalPalette CreateTonalPaletteFromSpecification(IColorPaletteSpecResult specification)
    {
        var specificationHct = HctColor.FromRgbColor(specification.BaseColor);
        if (specification.UseFixedChroma)
            specificationHct.Chroma = specification.FixedChroma;

        else if (specification is INonPrimaryColorPaletteSpecResult nonPrimarySpec && nonPrimarySpec.NormalizeChromaToPrimary)
            specificationHct.Chroma = GetChromaRatioedToPrimaryChroma(nonPrimarySpec);

        else if (specification.UseFixedTargetChroma)
            specificationHct.Chroma = TargetChromaProvider.GetTargetChromaForPaletteType(specification.PaletteType);

        return TonalPalette.FromHct(specificationHct);
    }

    private double GetChromaRatioedToPrimaryChroma(INonPrimaryColorPaletteSpecResult nonPrimarySpec)
    {
        var primaryTonalPalette = CreateTonalPaletteFromSpecification(_primaryColorSpec);
        var primaryChroma = primaryTonalPalette.Chroma;
        var primaryTargetChroma = TargetChromaProvider.GetTargetChromaForPaletteType(ColorPaletteType.Primary);
        var ratio = primaryChroma / primaryTargetChroma;

        var targetChroma = TargetChromaProvider.GetTargetChromaForPaletteType(nonPrimarySpec.PaletteType);
        return targetChroma * ratio;
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