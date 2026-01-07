using MaterialTheming.MaterialDesign;
using MaterialTheming.MaterialThemeBuilderConversion;

namespace MaterialTheming.Creation;

public class MaterialThemeBuilderJsonThemeBuilder : IMaterialThemeBuilderJsonThemeBuilder
{
    public static IMaterialThemeBuilderJsonThemeBuilder Create() => new MaterialThemeBuilderJsonThemeBuilder();

    public static IMaterialThemeBuilderJsonThemeBuilder CreateFromJsonContent(string materialThemeBuilderJson)
        => Create().WithMaterialThemeBuilderJson(materialThemeBuilderJson);

    public static IMaterialThemeBuilderJsonThemeBuilder CreateFromJsonFile(string materialThemeBuilderJsonFilePath)
        => Create().WithMaterialThemeBuilderJsonFile(materialThemeBuilderJsonFilePath);

    private MaterialThemeBuilderJsonThemeBuilder()
    {
        mode = ThemeMode.Light;
        contrastLevel = ContrastLevel.Normal;
    }

    private string? materialThemeBuilderJson;

    private ThemeMode mode;
    private ContrastLevel contrastLevel;

    public IMaterialThemeBuilderJsonThemeBuilder WithMaterialThemeBuilderJson(string materialThemeBuilderJson)
    {

        this.materialThemeBuilderJson = materialThemeBuilderJson;
        return this;
    }
    public IMaterialThemeBuilderJsonThemeBuilder WithMaterialThemeBuilderJsonFile(string materialThemeBuilderJsonFilePath)
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
