using MaterialTheming.Creation.ThemeBuilderBlocks;

namespace MaterialTheming.Creation;

public interface IMaterialThemeBuilderJsonThemeBuilder :
    IBuildableThemeBuilder,
    IWithMaterialThemeBuilderJsonThemeBuilder<IMaterialThemeBuilderJsonThemeBuilder>,
    IWithModeThemeBuilder<IMaterialThemeBuilderJsonThemeBuilder>,
    IWithContrastLevelThemeBuilder<IMaterialThemeBuilderJsonThemeBuilder>
{
}
