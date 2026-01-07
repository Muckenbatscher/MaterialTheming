namespace MaterialTheming.Creation.ThemeBuilderBlocks;

public interface IWithMaterialThemeBuilderJsonThemeBuilder<TBuilder>
    where TBuilder : IBuildableThemeBuilder
{
    TBuilder WithMaterialThemeBuilderJsonContent(string materialThemeBuilderJson);
    TBuilder WithMaterialThemeBuilderJsonFilePath(string materialThemeBuilderJsonFilePath);
}
