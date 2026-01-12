using MaterialTheming.ColorDefinitions;
using MaterialTheming.Tests.KnownTestThemes;

namespace MaterialTheming.Tests.ColorDifferenceCalculation;

internal class ColorDifferenceService
{
    public static IEnumerable<ColorDifference> GetColorDifferences<TExpected>(Theme theme)
        where TExpected : IExpectedThemeColors, new()
    {
        var expectedThemeColors = new TExpected();
        return GetColorDifferences(theme.Colors, expectedThemeColors);
    }
    public static IEnumerable<ColorDifference> GetColorDifferences<TExpected>(ThemeColors themeColors)
        where TExpected : IExpectedThemeColors, new()
    {
        var expectedThemeColors = new TExpected();
        return GetColorDifferences(themeColors, expectedThemeColors);
    }

    public static IEnumerable<ColorDifference> GetColorDifferences(Theme theme, IExpectedThemeColors expectedThemeColors)
        => GetColorDifferences(theme.Colors, expectedThemeColors);
    public static IEnumerable<ColorDifference> GetColorDifferences(ThemeColors themeColors, IExpectedThemeColors expectedThemeColors)
    {
        yield return GetColorDifference("Primary", themeColors.Primary, expectedThemeColors.Primary);
        yield return GetColorDifference("OnPrimary", themeColors.OnPrimary, expectedThemeColors.OnPrimary);
        yield return GetColorDifference("PrimaryContainer", themeColors.PrimaryContainer, expectedThemeColors.PrimaryContainer);
        yield return GetColorDifference("OnPrimaryContainer", themeColors.OnPrimaryContainer, expectedThemeColors.OnPrimaryContainer);

        yield return GetColorDifference("Secondary", themeColors.Secondary, expectedThemeColors.Secondary);
        yield return GetColorDifference("OnSecondary", themeColors.OnSecondary, expectedThemeColors.OnSecondary);
        yield return GetColorDifference("SecondaryContainer", themeColors.SecondaryContainer, expectedThemeColors.SecondaryContainer);
        yield return GetColorDifference("OnSecondaryContainer", themeColors.OnSecondaryContainer, expectedThemeColors.OnSecondaryContainer);

        yield return GetColorDifference("Tertiary", themeColors.Tertiary, expectedThemeColors.Tertiary);
        yield return GetColorDifference("OnTertiary", themeColors.OnTertiary, expectedThemeColors.OnTertiary);
        yield return GetColorDifference("TertiaryContainer", themeColors.TertiaryContainer, expectedThemeColors.TertiaryContainer);
        yield return GetColorDifference("OnTertiaryContainer", themeColors.OnTertiaryContainer, expectedThemeColors.OnTertiaryContainer);

        yield return GetColorDifference("Error", themeColors.Error, expectedThemeColors.Error);
        yield return GetColorDifference("OnError", themeColors.OnError, expectedThemeColors.OnError);
        yield return GetColorDifference("ErrorContainer", themeColors.ErrorContainer, expectedThemeColors.ErrorContainer);
        yield return GetColorDifference("OnErrorContainer", themeColors.OnErrorContainer, expectedThemeColors.OnErrorContainer);

        yield return GetColorDifference("Surface", themeColors.Surface, expectedThemeColors.Surface);
        yield return GetColorDifference("OnSurface", themeColors.OnSurface, expectedThemeColors.OnSurface);
        yield return GetColorDifference("OnSurfaceVariant", themeColors.OnSurfaceVariant, expectedThemeColors.OnSurfaceVariant);

        yield return GetColorDifference("SurfaceContainerLowest", themeColors.SurfaceContainerLowest, expectedThemeColors.SurfaceContainerLowest);
        yield return GetColorDifference("SurfaceContainerLow", themeColors.SurfaceContainerLow, expectedThemeColors.SurfaceContainerLow);
        yield return GetColorDifference("SurfaceContainer", themeColors.SurfaceContainer, expectedThemeColors.SurfaceContainer);
        yield return GetColorDifference("SurfaceContainerHigh", themeColors.SurfaceContainerHigh, expectedThemeColors.SurfaceContainerHigh);
        yield return GetColorDifference("SurfaceContainerHighest", themeColors.SurfaceContainerHighest, expectedThemeColors.SurfaceContainerHighest);
    }

    private static ColorDifference GetColorDifference(string colorRoleName, RgbColor actualColor, string expectedColor)
        => new(colorRoleName, actualColor, RgbColor.FromHtml(expectedColor));
}
