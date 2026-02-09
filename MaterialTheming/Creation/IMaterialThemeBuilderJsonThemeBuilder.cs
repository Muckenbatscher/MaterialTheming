namespace MaterialTheming;

/// <summary>
/// Defines a builder interface for configuring how to extract the <see cref="ThemeColors"/> from a 
/// <see href="https://material-foundation.github.io/material-theme-builder/">Material Theme Builder</see> JSON content.
/// </summary>
public interface IMaterialThemeBuilderJsonThemeBuilder :
    IBuildableThemeBuilder,
    IWithMaterialThemeBuilderJsonThemeBuilder<IMaterialThemeBuilderJsonThemeBuilder>,
    IWithModeThemeBuilder<IMaterialThemeBuilderJsonThemeBuilder>,
    IWithContrastLevelThemeBuilder<IMaterialThemeBuilderJsonThemeBuilder>
{
}
