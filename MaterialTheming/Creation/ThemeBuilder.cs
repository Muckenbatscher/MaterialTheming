using MaterialTheming.ColorDefinitions;

namespace MaterialTheming.Creation;

public class ThemeBuilder
{
    /// <inheritdoc cref="ColorPaletteThemeBuilder.Create"/>
    public static IColorPaletteThemeBuilder CreateForColorPalette()
        => ColorPaletteThemeBuilder.Create();

    /// <inheritdoc cref="ColorPaletteThemeBuilder.CreateFromSourceColor(string)"/>
    public static IColorPaletteThemeBuilder CreateForColorPaletteFromSourceColor(string htmlColor)
        => ColorPaletteThemeBuilder.CreateFromSourceColor(htmlColor);

    /// <inheritdoc cref="ColorPaletteThemeBuilder.CreateFromSourceColor(HctColor)"/>
    public static IColorPaletteThemeBuilder CreateForColorPaletteFromSourceColor(HctColor color)
        => ColorPaletteThemeBuilder.CreateFromSourceColor(color);

    /// <inheritdoc cref="ColorPaletteThemeBuilder.CreateFromSourceColor(RgbColor)"/>
    public static IColorPaletteThemeBuilder CreateForColorPaletteFromSourceColor(RgbColor color)
        => ColorPaletteThemeBuilder.CreateFromSourceColor(color);

    /// <inheritdoc cref="MaterialThemeBuilderJsonThemeBuilder.Create"/>
    public static IMaterialThemeBuilderJsonThemeBuilder CreateForMaterialThemeBuilderJson()
        => MaterialThemeBuilderJsonThemeBuilder.Create();

    /// <inheritdoc cref="MaterialThemeBuilderJsonThemeBuilder.CreateFromJsonContent(string)"/>
    public static IMaterialThemeBuilderJsonThemeBuilder CreateForMaterialThemeBuilderJsonFromJsonContent(string materialThemeBuilderJson)
        => MaterialThemeBuilderJsonThemeBuilder.CreateFromJsonContent(materialThemeBuilderJson);

    /// <inheritdoc cref="MaterialThemeBuilderJsonThemeBuilder.CreateFromJsonFilePath(string)"/>
    public static IMaterialThemeBuilderJsonThemeBuilder CreateForMaterialThemeBuilderJsonFromJsonFilePath(string materialThemeBuilderJsonFilePath)
        => MaterialThemeBuilderJsonThemeBuilder.CreateFromJsonFilePath(materialThemeBuilderJsonFilePath);
}