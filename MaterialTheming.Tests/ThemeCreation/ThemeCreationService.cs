using MaterialTheming.Tests.KnownTestThemes;

namespace MaterialTheming.Tests.ThemeCreation;

internal class ThemeCreationService
{
    public static Theme CreateTheme<TTestThemeParameters>()
        where TTestThemeParameters : IThemeCreationParameters, new()
    {
        var parameters = new TTestThemeParameters();
        return CreateTheme(parameters);
    }
    public static Theme CreateTheme(IThemeCreationParameters parameters)
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
