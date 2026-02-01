namespace MaterialTheming;

public interface IMaterialThemeBuilderJsonThemeBuilder :
    IBuildableThemeBuilder,
    IWithMaterialThemeBuilderJsonThemeBuilder<IMaterialThemeBuilderJsonThemeBuilder>,
    IWithModeThemeBuilder<IMaterialThemeBuilderJsonThemeBuilder>,
    IWithContrastLevelThemeBuilder<IMaterialThemeBuilderJsonThemeBuilder>
{
}
