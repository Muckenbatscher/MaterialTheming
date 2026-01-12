using MaterialTheming.ColorDefinitions;

namespace MaterialTheming.Creation;

public class ThemeBuilder
{
    public static IColorPaletteThemeBuilder CreateForColorPalette()
        => ColorPaletteThemeBuilder.Create();
    public static IColorPaletteThemeBuilder CreateForColorPaletteFromSourceColor(string htmlColor)
        => ColorPaletteThemeBuilder.CreateFromSourceColor(htmlColor);
    public static IColorPaletteThemeBuilder CreateForColorPaletteFromSourceColor(HctColor color)
        => ColorPaletteThemeBuilder.CreateFromSourceColor(color);
    public static IColorPaletteThemeBuilder CreateForColorPaletteFromSourceColor(RgbColor color)
        => ColorPaletteThemeBuilder.CreateFromSourceColor(color);

    public static IMaterialThemeBuilderJsonThemeBuilder CreateForMaterialThemeBuilderJson()
        => MaterialThemeBuilderJsonThemeBuilder.Create();
    public static IMaterialThemeBuilderJsonThemeBuilder CreateForMaterialThemeBuilderJsonFromJsonContent(string materialThemeJsonContent)
        => MaterialThemeBuilderJsonThemeBuilder.CreateFromJsonContent(materialThemeJsonContent);
    public static IMaterialThemeBuilderJsonThemeBuilder CreateForMaterialThemeBuilderJsonFromJsonFilePath(string materialThemeJsonFilePath)
        => MaterialThemeBuilderJsonThemeBuilder.CreateFromJsonFilePath(materialThemeJsonFilePath);
}