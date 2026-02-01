namespace MaterialTheming;

public interface IWithMaterialThemeBuilderJsonThemeBuilder<TBuilder>
    where TBuilder : IBuildableThemeBuilder
{
    /// <summary>
    /// Specify the <see href="https://material-foundation.github.io/material-theme-builder/">material theme builder</see> JSON content that is used to build the <see cref="ThemeColors" />.
    /// </summary>
    /// <param name="materialThemeBuilderJson">The JSON content of the exported theme from <see href="https://material-foundation.github.io/material-theme-builder/"/></param>
    /// <returns>The <typeparamref name="TBuilder"/> with the material theme builder JSON content.</returns>
    TBuilder WithMaterialThemeBuilderJsonContent(string materialThemeBuilderJson);
    /// <summary>
    /// Specify the <see href="https://material-foundation.github.io/material-theme-builder/">material theme builder</see> JSON content that is used to build the <see cref="ThemeColors" />.
    /// </summary>
    /// <param name="materialThemeBuilderJsonFilePath">The path to the JSON file that was exported from <see href="https://material-foundation.github.io/material-theme-builder/"/></param>
    /// <returns>The <typeparamref name="TBuilder"/> with the material theme builder JSON content of the specified file.</returns>
    TBuilder WithMaterialThemeBuilderJsonFilePath(string materialThemeBuilderJsonFilePath);
}
