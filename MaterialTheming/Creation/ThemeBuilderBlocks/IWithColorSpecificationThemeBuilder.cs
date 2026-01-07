namespace MaterialTheming.Creation.ThemeBuilderBlocks;

public interface IWithColorSpecificationThemeBuilder<TBuilder> 
    where TBuilder : IBuildableThemeBuilder
{
    TBuilder WithPrimaryColor(Action<IColorPaletteSpecification> colorSpecificationOptions);
    TBuilder WithSecondaryColor(Action<INonPrimaryColorPaletteSpecification> colorSpecificationOptions);
    TBuilder WithTertiaryolor(Action<INonPrimaryColorPaletteSpecification> colorSpecificationOptions);
    TBuilder WithErrorColor(Action<INonPrimaryColorPaletteSpecification> colorSpecificationOptions);
    TBuilder WithNeutralColor(Action<INonPrimaryColorPaletteSpecification> colorSpecificationOptions);
    TBuilder WithNeutralVariantColor(Action<INonPrimaryColorPaletteSpecification> colorSpecificationOptions);
}
