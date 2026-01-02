using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Creation;

public interface IThemeBuilder
{
    IThemeBuilder WithPrimaryColor(Action<IColorPaletteSpecification> colorSpecificationOptions);
    IThemeBuilder WithSecondaryColor(Action<INonPrimaryColorPaletteSpecification> colorSpecificationOptions);
    IThemeBuilder WithTertiaryolor(Action<INonPrimaryColorPaletteSpecification> colorSpecificationOptions);
    IThemeBuilder WithErrorColor(Action<INonPrimaryColorPaletteSpecification> colorSpecificationOptions);
    IThemeBuilder WithNeutralColor(Action<INonPrimaryColorPaletteSpecification> colorSpecificationOptions);
    IThemeBuilder WithNeutralVariantColor(Action<INonPrimaryColorPaletteSpecification> colorSpecificationOptions);

    IThemeBuilder WithMaterialThemeBuilderJson(string materialThemeBuilderJson);
    IThemeBuilder WithMaterialThemeBuilderJsonFile(string materialThemeBuilderJsonFilePath);

    IThemeBuilder WithMode(ThemeMode mode);
    IThemeBuilder WithContrastLevel(ContrastLevel contrastLevel);

    Theme Build();
}
