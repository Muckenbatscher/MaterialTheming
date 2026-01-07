using MaterialTheming.Creation.ThemeBuilderBlocks;

namespace MaterialTheming.Creation;

public interface IColorPaletteThemeBuilder :
    IBuildableThemeBuilder,
    IWithColorSpecificationThemeBuilder<IColorPaletteThemeBuilder>,
    IWithModeThemeBuilder<IColorPaletteThemeBuilder>,
    IWithContrastLevelThemeBuilder<IColorPaletteThemeBuilder>,
    IWithContrastLevelValueThemeBuilder<IColorPaletteThemeBuilder>,
    IWithVariantThemeBuilder<IColorPaletteThemeBuilder>,
    IWithPlatformThemeBuilder<IColorPaletteThemeBuilder>
{
}
