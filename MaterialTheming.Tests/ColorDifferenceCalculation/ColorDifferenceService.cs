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
        // Primary
        yield return GetColorDifference("Primary", themeColors.Primary, expectedThemeColors.Primary);
        yield return GetColorDifference("OnPrimary", themeColors.OnPrimary, expectedThemeColors.OnPrimary);
        yield return GetColorDifference("PrimaryContainer", themeColors.PrimaryContainer, expectedThemeColors.PrimaryContainer);
        yield return GetColorDifference("OnPrimaryContainer", themeColors.OnPrimaryContainer, expectedThemeColors.OnPrimaryContainer);
        // Secondary
        yield return GetColorDifference("Secondary", themeColors.Secondary, expectedThemeColors.Secondary);
        yield return GetColorDifference("OnSecondary", themeColors.OnSecondary, expectedThemeColors.OnSecondary);
        yield return GetColorDifference("SecondaryContainer", themeColors.SecondaryContainer, expectedThemeColors.SecondaryContainer);
        yield return GetColorDifference("OnSecondaryContainer", themeColors.OnSecondaryContainer, expectedThemeColors.OnSecondaryContainer);
        // Tertiary
        yield return GetColorDifference("Tertiary", themeColors.Tertiary, expectedThemeColors.Tertiary);
        yield return GetColorDifference("OnTertiary", themeColors.OnTertiary, expectedThemeColors.OnTertiary);
        yield return GetColorDifference("TertiaryContainer", themeColors.TertiaryContainer, expectedThemeColors.TertiaryContainer);
        yield return GetColorDifference("OnTertiaryContainer", themeColors.OnTertiaryContainer, expectedThemeColors.OnTertiaryContainer);
        // Error
        yield return GetColorDifference("Error", themeColors.Error, expectedThemeColors.Error);
        yield return GetColorDifference("OnError", themeColors.OnError, expectedThemeColors.OnError);
        yield return GetColorDifference("ErrorContainer", themeColors.ErrorContainer, expectedThemeColors.ErrorContainer);
        yield return GetColorDifference("OnErrorContainer", themeColors.OnErrorContainer, expectedThemeColors.OnErrorContainer);
        // Surface
        yield return GetColorDifference("Surface", themeColors.Surface, expectedThemeColors.Surface);
        yield return GetColorDifference("SurfaceVariant", themeColors.SurfaceVariant, expectedThemeColors.SurfaceVariant);
        yield return GetColorDifference("OnSurface", themeColors.OnSurface, expectedThemeColors.OnSurface);
        yield return GetColorDifference("OnSurfaceVariant", themeColors.OnSurfaceVariant, expectedThemeColors.OnSurfaceVariant);
        yield return GetColorDifference("SurfaceDim", themeColors.SurfaceDim, expectedThemeColors.SurfaceDim);
        yield return GetColorDifference("SurfaceBright", themeColors.SurfaceBright, expectedThemeColors.SurfaceBright);
        yield return GetColorDifference("SurfaceTint", themeColors.SurfaceTint, expectedThemeColors.SurfaceTint);
        // Background
        yield return GetColorDifference("Background", themeColors.Background, expectedThemeColors.Background);
        yield return GetColorDifference("OnBackground", themeColors.OnBackground, expectedThemeColors.OnBackground);
        // Outline
        yield return GetColorDifference("Outline", themeColors.Outline, expectedThemeColors.Outline);
        yield return GetColorDifference("OutlineVariant", themeColors.OutlineVariant, expectedThemeColors.OutlineVariant);
        // Shadow
        yield return GetColorDifference("Shadow", themeColors.Shadow, expectedThemeColors.Shadow);
        yield return GetColorDifference("Scrim", themeColors.Scrim, expectedThemeColors.Scrim);
        // Inverse
        yield return GetColorDifference("InverseSurface", themeColors.InverseSurface, expectedThemeColors.InverseSurface);
        yield return GetColorDifference("InverseOnSurface", themeColors.InverseOnSurface, expectedThemeColors.InverseOnSurface);
        yield return GetColorDifference("InversePrimary", themeColors.InversePrimary, expectedThemeColors.InversePrimary);
        // Primary Fixed
        yield return GetColorDifference("PrimaryFixed", themeColors.PrimaryFixed, expectedThemeColors.PrimaryFixed);
        yield return GetColorDifference("OnPrimaryFixed", themeColors.OnPrimaryFixed, expectedThemeColors.OnPrimaryFixed);
        yield return GetColorDifference("PrimaryFixedDim", themeColors.PrimaryFixedDim, expectedThemeColors.PrimaryFixedDim);
        yield return GetColorDifference("OnPrimaryFixedVariant", themeColors.OnPrimaryFixedVariant, expectedThemeColors.OnPrimaryFixedVariant);
        // Secondary Fixed
        yield return GetColorDifference("SecondaryFixed", themeColors.SecondaryFixed, expectedThemeColors.SecondaryFixed);
        yield return GetColorDifference("OnSecondaryFixed", themeColors.OnSecondaryFixed, expectedThemeColors.OnSecondaryFixed);
        yield return GetColorDifference("SecondaryFixedDim", themeColors.SecondaryFixedDim, expectedThemeColors.SecondaryFixedDim);
        yield return GetColorDifference("OnSecondaryFixedVariant", themeColors.OnSecondaryFixedVariant, expectedThemeColors.OnSecondaryFixedVariant);
        // Tertiary Fixed
        yield return GetColorDifference("TertiaryFixed", themeColors.TertiaryFixed, expectedThemeColors.TertiaryFixed);
        yield return GetColorDifference("OnTertiaryFixed", themeColors.OnTertiaryFixed, expectedThemeColors.OnTertiaryFixed);
        yield return GetColorDifference("TertiaryFixedDim", themeColors.TertiaryFixedDim, expectedThemeColors.TertiaryFixedDim);
        yield return GetColorDifference("OnTertiaryFixedVariant", themeColors.OnTertiaryFixedVariant, expectedThemeColors.OnTertiaryFixedVariant);
        // Surface Container
        yield return GetColorDifference("SurfaceContainerLowest", themeColors.SurfaceContainerLowest, expectedThemeColors.SurfaceContainerLowest);
        yield return GetColorDifference("SurfaceContainerLow", themeColors.SurfaceContainerLow, expectedThemeColors.SurfaceContainerLow);
        yield return GetColorDifference("SurfaceContainer", themeColors.SurfaceContainer, expectedThemeColors.SurfaceContainer);
        yield return GetColorDifference("SurfaceContainerHigh", themeColors.SurfaceContainerHigh, expectedThemeColors.SurfaceContainerHigh);
        yield return GetColorDifference("SurfaceContainerHighest", themeColors.SurfaceContainerHighest, expectedThemeColors.SurfaceContainerHighest);
    }

    private static ColorDifference GetColorDifference(string colorRoleName, RgbColor actualColor, string expectedColor)
        => new(colorRoleName, actualColor, RgbColor.FromHtml(expectedColor));
}
