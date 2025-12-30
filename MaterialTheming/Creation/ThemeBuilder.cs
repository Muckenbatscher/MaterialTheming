using MaterialTheming.ColorDefinitions;
using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Creation;

public class ThemeBuilder : IThemeBuilder
{
    public static ThemeBuilder Create() => new ThemeBuilder();

    private ThemeBuilder()
    {
        _primaryColorSpec = new ColorSpecification();
        _secondaryColorSpec = new ColorSpecification();
        _tertiaryColorSpec = new ColorSpecification();
        _errorColorSpec = new ColorSpecification();
        _neutralColorSpec = new ColorSpecification();
        _neutralVariantColorSpec = new ColorSpecification();

        mode = ThemeMode.Light;
        contrastLevel = ContrastLevel.Normal;
    }

    private readonly ColorSpecification _primaryColorSpec;
    private readonly ColorSpecification _secondaryColorSpec;
    private readonly ColorSpecification _tertiaryColorSpec;
    private readonly ColorSpecification _errorColorSpec;
    private readonly ColorSpecification _neutralColorSpec;
    private readonly ColorSpecification _neutralVariantColorSpec;

    private ThemeMode mode;
    private ContrastLevel contrastLevel;

    public IThemeBuilder WithPrimaryColor(Action<IColorSpecification> colorSpecificationOptions)
    {
        colorSpecificationOptions(_primaryColorSpec);
        return this;
    }
    public IThemeBuilder WithSecondaryColor(Action<IColorSpecification> colorSpecificationOptions)
    {
        colorSpecificationOptions(_secondaryColorSpec);
        return this;
    }
    public IThemeBuilder WithTertiaryolor(Action<IColorSpecification> colorSpecificationOptions)
    {
        colorSpecificationOptions(_tertiaryColorSpec);
        return this;
    }
    public IThemeBuilder WithErrorColor(Action<IColorSpecification> colorSpecificationOptions)
    {
        colorSpecificationOptions(_errorColorSpec);
        return this;
    }
    public IThemeBuilder WithNeutralColor(Action<IColorSpecification> colorSpecificationOptions)
    {
        colorSpecificationOptions(_neutralColorSpec);
        return this;

    }
    public IThemeBuilder WithNeutralVariantColor(Action<IColorSpecification> colorSpecificationOptions)
    {
        colorSpecificationOptions(_neutralVariantColorSpec);
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
        if (!_primaryColorSpec.BaseColorSpecified)
            throw new InvalidOperationException("Primary color must be specified.");

        var primaryHct = HctColor.FromRgbColor(_primaryColorSpec.BaseColor);
        if (_primaryColorSpec.NormalizeChroma)
            primaryHct.Chroma = TargetChromas.Primary;
        else if (_primaryColorSpec.UseFixedChroma)
            primaryHct.Chroma = _primaryColorSpec.FixedChroma;
        var primaryPalette = new HctTonalPalette(primaryHct);

        return new Theme();
    }
}