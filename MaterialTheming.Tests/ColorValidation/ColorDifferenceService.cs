using MaterialTheming.ColorDefinitions;
using MaterialTheming.Tests.KnownTestThemes;

namespace MaterialTheming.Tests.ColorValidation;

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
        yield return CalculateColorDifference("Primary", themeColors.Primary, expectedThemeColors.Primary);
        yield return CalculateColorDifference("OnPrimary", themeColors.OnPrimary, expectedThemeColors.OnPrimary);
        yield return CalculateColorDifference("PrimaryContainer", themeColors.PrimaryContainer, expectedThemeColors.PrimaryContainer);
        yield return CalculateColorDifference("OnPrimaryContainer", themeColors.OnPrimaryContainer, expectedThemeColors.OnPrimaryContainer);


        yield return CalculateColorDifference("Secondary", themeColors.Secondary, expectedThemeColors.Secondary);
        yield return CalculateColorDifference("OnSecondary", themeColors.OnSecondary, expectedThemeColors.OnSecondary);
        yield return CalculateColorDifference("SecondaryContainer", themeColors.SecondaryContainer, expectedThemeColors.SecondaryContainer);
        yield return CalculateColorDifference("OnSecondaryContainer", themeColors.OnSecondaryContainer, expectedThemeColors.OnSecondaryContainer);


        yield return CalculateColorDifference("Tertiary", themeColors.Tertiary, expectedThemeColors.Tertiary);
        yield return CalculateColorDifference("OnTertiary", themeColors.OnTertiary, expectedThemeColors.OnTertiary);
        yield return CalculateColorDifference("TertiaryContainer", themeColors.TertiaryContainer, expectedThemeColors.TertiaryContainer);
        yield return CalculateColorDifference("OnTertiaryContainer", themeColors.OnTertiaryContainer, expectedThemeColors.OnTertiaryContainer);


        yield return CalculateColorDifference("Error", themeColors.Error, expectedThemeColors.Error);
        yield return CalculateColorDifference("OnError", themeColors.OnError, expectedThemeColors.OnError);
        yield return CalculateColorDifference("ErrorContainer", themeColors.ErrorContainer, expectedThemeColors.ErrorContainer);
        yield return CalculateColorDifference("OnErrorContainer", themeColors.OnErrorContainer, expectedThemeColors.OnErrorContainer);


        yield return CalculateColorDifference("Surface", themeColors.Surface, expectedThemeColors.Surface);
        yield return CalculateColorDifference("OnSurface", themeColors.OnSurface, expectedThemeColors.OnSurface);
        yield return CalculateColorDifference("OnSurfaceVariant", themeColors.OnSurfaceVariant, expectedThemeColors.OnSurfaceVariant);

        yield return CalculateColorDifference("SurfaceContainerLowest", themeColors.SurfaceContainerLowest, expectedThemeColors.SurfaceContainerLowest);
        yield return CalculateColorDifference("SurfaceContainerLow", themeColors.SurfaceContainerLow, expectedThemeColors.SurfaceContainerLow);
        yield return CalculateColorDifference("SurfaceContainer", themeColors.SurfaceContainer, expectedThemeColors.SurfaceContainer);
        yield return CalculateColorDifference("SurfaceContainerHigh", themeColors.SurfaceContainerHigh, expectedThemeColors.SurfaceContainerHigh);
        yield return CalculateColorDifference("SurfaceContainerHighest", themeColors.SurfaceContainerHighest, expectedThemeColors.SurfaceContainerHighest);
    }

    private static ColorDifference CalculateColorDifference(string colorRoleName, RgbColor actualColor, string expectedColor)
        => CalculateColorDifference(colorRoleName, actualColor, RgbColor.FromHtml(expectedColor));
    private static ColorDifference CalculateColorDifference(string colorRoleName, RgbColor actualColor, RgbColor expectedColor)
    {
        int redDiff = actualColor.Red - expectedColor.Red;
        int greenDiff = actualColor.Green - expectedColor.Green;
        int blueDiff = actualColor.Blue - expectedColor.Blue;

        return new ColorDifference(colorRoleName,
            redDiff, greenDiff, blueDiff);
    }
}
