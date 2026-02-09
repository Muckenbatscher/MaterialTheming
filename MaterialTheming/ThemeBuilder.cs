namespace MaterialTheming;

/// <summary>
/// Provides static methods for creating theme builders from various color sources or JSON content.
/// </summary>
public class ThemeBuilder
{
    /// <inheritdoc cref="ColorPaletteThemeBuilder.CreateFromSourceColor(string)"/>
    public static IColorPaletteThemeBuilder CreateFromSourceColor(string htmlColor)
        => ColorPaletteThemeBuilder.CreateFromSourceColor(htmlColor);

    /// <inheritdoc cref="ColorPaletteThemeBuilder.CreateFromSourceColor(HctColor)"/>
    public static IColorPaletteThemeBuilder CreateFromSourceColor(HctColor color)
        => ColorPaletteThemeBuilder.CreateFromSourceColor(color);

    /// <inheritdoc cref="ColorPaletteThemeBuilder.CreateFromSourceColor(RgbColor)"/>
    public static IColorPaletteThemeBuilder CreateFromSourceColor(RgbColor color)
        => ColorPaletteThemeBuilder.CreateFromSourceColor(color);

    /// <inheritdoc cref="MaterialThemeBuilderJsonThemeBuilder.CreateFromJsonContent(string)"/>
    public static IMaterialThemeBuilderJsonThemeBuilder CreateFromJsonContent(string materialThemeBuilderJson)
        => MaterialThemeBuilderJsonThemeBuilder.CreateFromJsonContent(materialThemeBuilderJson);

    /// <inheritdoc cref="MaterialThemeBuilderJsonThemeBuilder.CreateFromJsonFilePath(string)"/>
    public static IMaterialThemeBuilderJsonThemeBuilder CreateFromJsonFilePath(string materialThemeBuilderJsonFilePath)
        => MaterialThemeBuilderJsonThemeBuilder.CreateFromJsonFilePath(materialThemeBuilderJsonFilePath);
}