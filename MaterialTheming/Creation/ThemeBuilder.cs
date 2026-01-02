using MaterialTheming.ColorDefinitions;
using MaterialTheming.MaterialDesign;
using MaterialTheming.MaterialThemeBuilderConversion;

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
        contrastLevel = ContrastLevel.Normal;
    }

    private readonly ColorPaletteSpecification _primaryColorSpec;
    private readonly NonPrimaryColorPaletteSpecification _secondaryColorSpec;
    private readonly NonPrimaryColorPaletteSpecification _tertiaryColorSpec;
    private readonly NonPrimaryColorPaletteSpecification _errorColorSpec;
    private readonly NonPrimaryColorPaletteSpecification _neutralColorSpec;
    private readonly NonPrimaryColorPaletteSpecification _neutralVariantColorSpec;

    private string? materialThemeBuilderJson;

    private ThemeMode mode;
    private ContrastLevel contrastLevel;

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
        this.contrastLevel = contrastLevel;
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
        return MaterialThemeBuilderThemeColorsExtractor.CreateFromMaterialDesignJson(materialThemeBuilderJson!, mode, contrastLevel);
    }
    private ThemeColors BuildThemeColorsFromColorSpecifications()
    {
        if (!_primaryColorSpec.BaseColorSpecified)
            throw new InvalidOperationException("Primary color must be specified.");

        var primaryColorHct = HctColor.FromRgbColor(_primaryColorSpec.BaseColor);
        if (!_secondaryColorSpec.BaseColorSpecified)
            _secondaryColorSpec.WithBaseColorHue(primaryColorHct.Hue);
        if (!_tertiaryColorSpec.BaseColorSpecified)
            _tertiaryColorSpec.WithBaseColorHue(primaryColorHct.Hue + 60);
        if (!_errorColorSpec.BaseColorSpecified)
            _errorColorSpec.WithBaseColorHue(24);
        if (!_neutralColorSpec.BaseColorSpecified)
            _neutralColorSpec.WithBaseColorHue(primaryColorHct.Hue);
        if (!_neutralVariantColorSpec.BaseColorSpecified)
            _neutralVariantColorSpec.WithBaseColorHue(primaryColorHct.Hue);

        var primaryPalette = CreateTonalPaletteFromSpecification(_primaryColorSpec);
        var secondaryPalette = CreateTonalPaletteFromSpecification(_secondaryColorSpec);
        var tertiaryPalette = CreateTonalPaletteFromSpecification(_tertiaryColorSpec);
        var errorPalette = CreateTonalPaletteFromSpecification(_errorColorSpec);
        var neutralPalette = CreateTonalPaletteFromSpecification(_neutralColorSpec);
        var neutralVariantPalette = CreateTonalPaletteFromSpecification(_neutralVariantColorSpec);

        return CreateThemeColorsFromTonalPalettes(primaryPalette, secondaryPalette, tertiaryPalette,
            errorPalette, neutralPalette, neutralVariantPalette);
    }

    private HctTonalPalette CreateTonalPaletteFromSpecification(IColorPaletteSpecResult specification)
    {
        var specificationHct = HctColor.FromRgbColor(specification.BaseColor);
        if (specification.UseFixedChroma)
            specificationHct.Chroma = specification.FixedChroma;

        else if (specification is INonPrimaryColorPaletteSpecResult nonPrimarySpec && nonPrimarySpec.NormalizeChromaToPrimary)
            specificationHct.Chroma = GetChromaRatioedToPrimaryChroma(nonPrimarySpec);

        else if (specification.UseFixedTargetChroma)
            specificationHct.Chroma = TargetChromaProvider.GetTargetChromaForPaletteType(specification.PaletteType);

        return new HctTonalPalette(specificationHct);
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

    private ThemeColors CreateThemeColorsFromTonalPalettes(HctTonalPalette primaryPalette,
        HctTonalPalette secondaryPalette,
        HctTonalPalette tertiaryPalette,
        HctTonalPalette errorPalette,
        HctTonalPalette neutralPalette,
        HctTonalPalette neutralVariantPalette)
    {
        var foregroundTone = TargetToneProvider.GetTone(mode, contrastLevel, false);
        var backgroundTone = TargetToneProvider.GetTone(mode, contrastLevel, true);
        var containerForegroundTone = TargetToneProvider.GetContainerTone(mode, contrastLevel, false);
        var containerBackgroundTone = TargetToneProvider.GetContainerTone(mode, contrastLevel, true);
        var surfaceForegroundTone = TargetToneProvider.GetSurfaceTone(mode, contrastLevel, false);
        var surfaceBackgroundTone = TargetToneProvider.GetSurfaceTone(mode, contrastLevel, true);
        var surfaceVariantForegroundTone = TargetToneProvider.GetSurfaceVariantTone(mode, contrastLevel, false);
        var surfaceVariantBackgroundTone = TargetToneProvider.GetSurfaceVariantTone(mode, contrastLevel, true);

        double surfaceContainerLowestTone = TargetToneProvider.GetSurfaceContainerLowestTone(mode);
        double surfaceContainerLowTone = TargetToneProvider.GetSurfaceContainerLowTone(mode);
        double surfaceContainerTone = TargetToneProvider.GetSurfaceContainerTone(mode);
        double surfaceContainerHighTone = TargetToneProvider.GetSurfaceContainerHighTone(mode);
        double surfaceContainerHighestTone = TargetToneProvider.GetSurfaceContainerHighestTone(mode);

        return new ThemeColors()
        {
            Primary = primaryPalette.GetHctForTone(backgroundTone).ToRgbColor(),
            OnPrimary = primaryPalette.GetHctForTone(foregroundTone).ToRgbColor(),
            PrimaryContainer = primaryPalette.GetHctForTone(containerBackgroundTone).ToRgbColor(),
            OnPrimaryContainer = primaryPalette.GetHctForTone(containerForegroundTone).ToRgbColor(),
            Secondary = secondaryPalette.GetHctForTone(backgroundTone).ToRgbColor(),
            OnSecondary = secondaryPalette.GetHctForTone(foregroundTone).ToRgbColor(),
            SecondaryContainer = secondaryPalette.GetHctForTone(containerBackgroundTone).ToRgbColor(),
            OnSecondaryContainer = secondaryPalette.GetHctForTone(containerForegroundTone).ToRgbColor(),
            Tertiary = tertiaryPalette.GetHctForTone(backgroundTone).ToRgbColor(),
            OnTertiary = tertiaryPalette.GetHctForTone(foregroundTone).ToRgbColor(),
            TertiaryContainer = tertiaryPalette.GetHctForTone(containerBackgroundTone).ToRgbColor(),
            OnTertiaryContainer = tertiaryPalette.GetHctForTone(containerForegroundTone).ToRgbColor(),
            Error = errorPalette.GetHctForTone(backgroundTone).ToRgbColor(),
            OnError = errorPalette.GetHctForTone(foregroundTone).ToRgbColor(),
            ErrorContainer = errorPalette.GetHctForTone(containerBackgroundTone).ToRgbColor(),
            OnErrorContainer = errorPalette.GetHctForTone(containerForegroundTone).ToRgbColor(),
            Surface = neutralPalette.GetHctForTone(surfaceBackgroundTone).ToRgbColor(),
            SurfaceContainer = neutralPalette.GetHctForTone(surfaceContainerTone).ToRgbColor(),
            SurfaceContainerLowest = neutralPalette.GetHctForTone(surfaceContainerLowestTone).ToRgbColor(),
            SurfaceContainerLow = neutralPalette.GetHctForTone(surfaceContainerLowTone).ToRgbColor(),
            SurfaceContainerHigh = neutralPalette.GetHctForTone(surfaceContainerHighTone).ToRgbColor(),
            SurfaceContainerHighest = neutralPalette.GetHctForTone(surfaceContainerHighestTone).ToRgbColor(),
            OnSurface = neutralPalette.GetHctForTone(surfaceForegroundTone).ToRgbColor(),
            OnSurfaceVariant = neutralVariantPalette.GetHctForTone(surfaceVariantForegroundTone).ToRgbColor()
        };
    }
}