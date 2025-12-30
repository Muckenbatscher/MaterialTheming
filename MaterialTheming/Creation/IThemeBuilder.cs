using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Creation;

public interface IThemeBuilder
{
    IThemeBuilder WithPrimaryColor(Action<IColorPaletteSpecification> colorSpecificationOptions);
    IThemeBuilder WithSecondaryColor(Action<IColorPaletteSpecification> colorSpecificationOptions);
    IThemeBuilder WithTertiaryolor(Action<IColorPaletteSpecification> colorSpecificationOptions);
    IThemeBuilder WithErrorColor(Action<IColorPaletteSpecification> colorSpecificationOptions);
    IThemeBuilder WithNeutralColor(Action<IColorPaletteSpecification> colorSpecificationOptions);
    IThemeBuilder WithNeutralVariantColor(Action<IColorPaletteSpecification> colorSpecificationOptions);

    IThemeBuilder WithMode(ThemeMode mode);
    IThemeBuilder WithContrastLevel(ContrastLevel contrastLevel);

    Theme Build();
}
