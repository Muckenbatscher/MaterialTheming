using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Creation;

public interface IThemeBuilder
{
    IThemeBuilder WithPrimaryColor(Action<IColorSpecification> colorSpecificationOptions);
    IThemeBuilder WithSecondaryColor(Action<IColorSpecification> colorSpecificationOptions);
    IThemeBuilder WithTertiaryolor(Action<IColorSpecification> colorSpecificationOptions);
    IThemeBuilder WithErrorColor(Action<IColorSpecification> colorSpecificationOptions);
    IThemeBuilder WithNeutralColor(Action<IColorSpecification> colorSpecificationOptions);
    IThemeBuilder WithNeutralVariantColor(Action<IColorSpecification> colorSpecificationOptions);

    IThemeBuilder WithMode(ThemeMode mode);
    IThemeBuilder WithContrastLevel(ContrastLevel contrastLevel);

    Theme Build();
}
