using MaterialTheming.MaterialDesign;
using MaterialTheming.MaterialThemeBuilderConversion;

namespace MaterialTheming.Creation;

public class MaterialThemeBuilderJsonThemeBuilder : IMaterialThemeBuilderJsonThemeBuilder
{
    /// <summary>
    /// Creates a new instance of <see cref="IMaterialThemeBuilderJsonThemeBuilder"/> with default settings.
    /// <para>
    /// Default settings include:<br/>
    /// <b>Mode </b>- light<br/>
    /// <b>Contrast level </b>- normal<br/>
    /// </para>
    /// </summary>
    /// <remarks>The returned builder is preconfigured with default settings.
    /// It can be further customized by chaining additional configuration methods on the returned builder.
    /// A <see href="https://material-foundation.github.io/material-theme-builder/">Material Theme Builder</see> 
    /// exported JSON content is required to be specified.</remarks>
    /// <returns>An <see cref="IMaterialThemeBuilderJsonThemeBuilder"/> initialized with the default settings.</returns>
    public static IMaterialThemeBuilderJsonThemeBuilder Create()
        => new MaterialThemeBuilderJsonThemeBuilder()
        .WithMode(ThemeMode.Light)
        .WithContrastLevel(ContrastLevel.Normal);

    /// <summary>
    /// Creates a new instance of <see cref="IMaterialThemeBuilderJsonThemeBuilder"/> 
    /// with the specifed Material Theme Builder JSON content and with default settings.
    /// <para>
    /// Default settings include:<br/>
    /// <b>Mode </b>- light<br/>
    /// <b>Contrast level </b>- normal<br/>
    /// </para>
    /// </summary>
    /// <remarks>The returned builder is preconfigured with default settings.
    /// It can be further customized by chaining additional configuration methods on the returned builder.
    /// A <see href="https://material-foundation.github.io/material-theme-builder/">Material Theme Builder</see> 
    /// exported JSON content is required to be specified.</remarks>
    /// <param name="materialThemeBuilderJson">A JSON string containing the <see href="https://material-foundation.github.io/material-theme-builder/">Material Theme Builder</see> 
    /// theme definition to initialize the builder with.</param>
    /// <returns>An instance of <see cref="IMaterialThemeBuilderJsonThemeBuilder"/> initialized with the provided JSON content and with default settings.</returns>
    public static IMaterialThemeBuilderJsonThemeBuilder CreateFromJsonContent(string materialThemeBuilderJson)
        => Create().WithMaterialThemeBuilderJsonContent(materialThemeBuilderJson);

    /// <summary>
    /// Creates a new instance of <see cref="IMaterialThemeBuilderJsonThemeBuilder"/> 
    /// with the specifed Material Theme Builder JSON content and with default settings.
    /// <para>
    /// Default settings include:<br/>
    /// <b>Mode </b>- light<br/>
    /// <b>Contrast level </b>- normal<br/>
    /// </para>
    /// </summary>
    /// <remarks>The returned builder is preconfigured with default settings.
    /// It can be further customized by chaining additional configuration methods on the returned builder.
    /// A <see href="https://material-foundation.github.io/material-theme-builder/">Material Theme Builder</see> 
    /// exported JSON content is required to be specified.</remarks>
    /// <param name="materialThemeBuilderJsonFilePath">Path to a JSON file containing the <see href="https://material-foundation.github.io/material-theme-builder/">Material Theme Builder</see> 
    /// theme definition to initialize the builder with.</param>
    /// <returns>An instance of <see cref="IMaterialThemeBuilderJsonThemeBuilder"/> initialized with the JSON content found 
    /// at the specified file path and with default settings.</returns>
    public static IMaterialThemeBuilderJsonThemeBuilder CreateFromJsonFilePath(string materialThemeBuilderJsonFilePath)
        => Create().WithMaterialThemeBuilderJsonFilePath(materialThemeBuilderJsonFilePath);

    private MaterialThemeBuilderJsonThemeBuilder()
    {
    }

    private string? materialThemeBuilderJson;

    private ThemeMode mode;
    private ContrastLevel contrastLevel;

    public IMaterialThemeBuilderJsonThemeBuilder WithMaterialThemeBuilderJsonContent(string materialThemeBuilderJson)
    {
        this.materialThemeBuilderJson = materialThemeBuilderJson;
        return this;
    }
    public IMaterialThemeBuilderJsonThemeBuilder WithMaterialThemeBuilderJsonFilePath(string materialThemeBuilderJsonFilePath)
    {
        var fileContents = File.ReadAllText(materialThemeBuilderJsonFilePath);
        materialThemeBuilderJson = fileContents;
        return this;
    }

    public IMaterialThemeBuilderJsonThemeBuilder WithMode(ThemeMode mode)
    {
        this.mode = mode;
        return this;
    }
    public IMaterialThemeBuilderJsonThemeBuilder WithContrastLevel(ContrastLevel contrastLevel)
    {
        this.contrastLevel = contrastLevel;
        return this;
    }

    public Theme Build()
    {
        if (materialThemeBuilderJson == null)
            throw new InvalidOperationException($"The Material Thheme Builder JSON is not configured.");

        var themeColors = MaterialThemeBuilderThemeColorsExtractor
            .CreateFromMaterialDesignJson(materialThemeBuilderJson, mode, contrastLevel);
        return new Theme(
            isDark: mode == ThemeMode.Dark,
            colors: themeColors);
    }
}
