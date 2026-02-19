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
        IColorPaletteThemeBuilder builder;
        if (parameters is IThemeCreationParametersSecondSourceColor secondSourceColorCreationParameters)
            builder = ThemeBuilder.CreateFromSourceColors(parameters.SourceColor, secondSourceColorCreationParameters.SecondSourceColor);
        else
            builder = ThemeBuilder.CreateFromSourceColor(parameters.SourceColor);

        var mode = parameters.IsDark ? ThemeMode.Dark : ThemeMode.Light;
        return builder
            .WithMode(mode)
            .WithContrastLevel(parameters.ContrastLevelValue)
            .WithVariant(parameters.Variant)
            .WithSpecVersion(parameters.SpecVersion)
            .Build();
    }
}
