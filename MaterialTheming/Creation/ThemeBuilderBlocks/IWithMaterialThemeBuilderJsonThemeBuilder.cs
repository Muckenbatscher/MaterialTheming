namespace MaterialTheming.Creation.ThemeBuilderBlocks;

public interface IWithMaterialThemeBuilderJsonThemeBuilder<TBuilder>
    where TBuilder : IBuildableThemeBuilder
{
    TBuilder WithMaterialThemeBuilderJson(string materialThemeBuilderJson);
    TBuilder WithMaterialThemeBuilderJsonFile(string materialThemeBuilderJsonFilePath);
}
