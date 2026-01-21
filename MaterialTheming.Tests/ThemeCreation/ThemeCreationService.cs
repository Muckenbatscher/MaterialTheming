using MaterialTheming.Tests.KnownTestThemes;

namespace MaterialTheming.Tests.ThemeCreation;

internal class ThemeCreationService
{
    public static ThemeColors CreateThemeColors<TTestThemeParameters>()
        where TTestThemeParameters : IThemeCreationParameters, new()
    {
        var parameters = new TTestThemeParameters();
        return CreateThemeColors(parameters);
    }
    public static ThemeColors CreateThemeColors(IThemeCreationParameters parameters)
    {
        var mode = parameters.IsDark ? ThemeMode.Dark : ThemeMode.Light;
        return ThemeBuilder.CreateFromSourceColor(parameters.SourceColor)
            .WithMode(mode)
            .WithContrastLevel(parameters.ContrastLevelValue)
            .WithVariant(parameters.Variant)
            .WithSpecVersion(parameters.SpecVersion)
            .Build();
    }
}
