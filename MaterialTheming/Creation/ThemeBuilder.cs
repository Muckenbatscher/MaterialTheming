using MaterialTheming.ColorDefinitions;

namespace MaterialTheming.Creation;

public class ThemeBuilder
{
    /// <inheritdoc cref="ColorPaletteThemeBuilder.Create" path="/summary"/>
    /// <inheritdoc cref="ColorPaletteThemeBuilder.Create" path="/remarks"/>
    /// <inheritdoc cref="ColorPaletteThemeBuilder.Create" path="/returns"/>
    public static IColorPaletteThemeBuilder CreateForColorPalette()
        => ColorPaletteThemeBuilder.Create();

    /// <inheritdoc cref="ColorPaletteThemeBuilder.CreateFromSourceColor(string)" path="/summary"/>
    /// <inheritdoc cref="ColorPaletteThemeBuilder.CreateFromSourceColor(string)" path="/remarks"/>
    /// <inheritdoc cref="ColorPaletteThemeBuilder.CreateFromSourceColor(string)" path="/param"/>
    /// <inheritdoc cref="ColorPaletteThemeBuilder.CreateFromSourceColor(string)" path="/returns"/>
    public static IColorPaletteThemeBuilder CreateForColorPaletteFromSourceColor(string htmlColor)
        => ColorPaletteThemeBuilder.CreateFromSourceColor(htmlColor);

    /// <inheritdoc cref="ColorPaletteThemeBuilder.CreateFromSourceColor(HctColor)" path="/summary"/>
    /// <inheritdoc cref="ColorPaletteThemeBuilder.CreateFromSourceColor(HctColor)" path="/remarks"/>
    /// <inheritdoc cref="ColorPaletteThemeBuilder.CreateFromSourceColor(HctColor)" path="/param"/>
    /// <inheritdoc cref="ColorPaletteThemeBuilder.CreateFromSourceColor(HctColor)" path="/returns"/>
    public static IColorPaletteThemeBuilder CreateForColorPaletteFromSourceColor(HctColor color)
        => ColorPaletteThemeBuilder.CreateFromSourceColor(color);

    /// <inheritdoc cref="ColorPaletteThemeBuilder.CreateFromSourceColor(RgbColor)" path="/summary"/>
    /// <inheritdoc cref="ColorPaletteThemeBuilder.CreateFromSourceColor(RgbColor)" path="/remarks"/>
    /// <inheritdoc cref="ColorPaletteThemeBuilder.CreateFromSourceColor(RgbColor)" path="/param"/>
    /// <inheritdoc cref="ColorPaletteThemeBuilder.CreateFromSourceColor(RgbColor)" path="/returns"/>
    public static IColorPaletteThemeBuilder CreateForColorPaletteFromSourceColor(RgbColor color)
        => ColorPaletteThemeBuilder.CreateFromSourceColor(color);

    /// <inheritdoc cref="MaterialThemeBuilderJsonThemeBuilder.Create" path="/summary"/>
    /// <inheritdoc cref="MaterialThemeBuilderJsonThemeBuilder.Create" path="/remarks"/>
    /// <inheritdoc cref="MaterialThemeBuilderJsonThemeBuilder.Create" path="/returns"/>
    public static IMaterialThemeBuilderJsonThemeBuilder CreateForMaterialThemeBuilderJson()
        => MaterialThemeBuilderJsonThemeBuilder.Create();

    /// <inheritdoc cref="MaterialThemeBuilderJsonThemeBuilder.CreateFromJsonContent(string)" path="/summary"/>
    /// <inheritdoc cref="MaterialThemeBuilderJsonThemeBuilder.CreateFromJsonContent(string)" path="/remarks"/>
    /// <inheritdoc cref="MaterialThemeBuilderJsonThemeBuilder.CreateFromJsonContent(string)" path="/param"/>
    /// <inheritdoc cref="MaterialThemeBuilderJsonThemeBuilder.CreateFromJsonContent(string)" path="/returns"/>
    public static IMaterialThemeBuilderJsonThemeBuilder CreateForMaterialThemeBuilderJsonFromJsonContent(string materialThemeBuilderJson)
        => MaterialThemeBuilderJsonThemeBuilder.CreateFromJsonContent(materialThemeBuilderJson);

    /// <inheritdoc cref="MaterialThemeBuilderJsonThemeBuilder.CreateFromJsonFilePath(string)" path="/summary"/>
    /// <inheritdoc cref="MaterialThemeBuilderJsonThemeBuilder.CreateFromJsonFilePath(string)" path="/remarks"/>
    /// <inheritdoc cref="MaterialThemeBuilderJsonThemeBuilder.CreateFromJsonFilePath(string)" path="/param"/>
    /// <inheritdoc cref="MaterialThemeBuilderJsonThemeBuilder.CreateFromJsonFilePath(string)" path="/returns"/>
    public static IMaterialThemeBuilderJsonThemeBuilder CreateForMaterialThemeBuilderJsonFromJsonFilePath(string materialThemeBuilderJsonFilePath)
        => MaterialThemeBuilderJsonThemeBuilder.CreateFromJsonFilePath(materialThemeBuilderJsonFilePath);
}