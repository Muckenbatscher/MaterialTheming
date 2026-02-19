namespace MaterialTheming;

/// <summary>
/// Defines a builder interface for configuring and constructing color palette-based themes with customizable properties.
/// </summary>
/// <remarks>This interface extends multiple theme builder interfaces, enabling fluent configuration of 
/// source colors, theme modes, contrast levels, variants, platform, spec version, and palette
/// overrides.</remarks>
public interface IColorPaletteThemeBuilder :
    IBuildableThemeBuilder,
    IWithSourceColorThemeBuilder<IColorPaletteThemeBuilder>,
    IWithModeThemeBuilder<IColorPaletteThemeBuilder>,
    IWithContrastLevelThemeBuilder<IColorPaletteThemeBuilder>,
    IWithContrastLevelValueThemeBuilder<IColorPaletteThemeBuilder>,
    IWithVariantThemeBuilder<IColorPaletteThemeBuilder>,
    IWithPlatformThemeBuilder<IColorPaletteThemeBuilder>,
    IWithSpecVersionThemeBuilder<IColorPaletteThemeBuilder>
{
}
