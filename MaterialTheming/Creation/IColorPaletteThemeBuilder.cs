using MaterialTheming.Creation.ThemeBuilderBlocks;

namespace MaterialTheming.Creation;

public interface IColorPaletteThemeBuilder :
    IBuildableThemeBuilder,
    IWithSourceColorThemeBuilder<IColorPaletteThemeBuilder>,
    IWithModeThemeBuilder<IColorPaletteThemeBuilder>,
    IWithContrastLevelThemeBuilder<IColorPaletteThemeBuilder>,
    IWithContrastLevelValueThemeBuilder<IColorPaletteThemeBuilder>,
    IWithVariantThemeBuilder<IColorPaletteThemeBuilder>,
    IWithPlatformThemeBuilder<IColorPaletteThemeBuilder>,
    IWithSpecVersionThemeBuilder<IColorPaletteThemeBuilder>,
    IWithPaletteOverrideThemeBuilder<IColorPaletteThemeBuilder>
{
}
