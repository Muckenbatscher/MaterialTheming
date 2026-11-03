namespace MaterialTheming.Tests.ColorDifferenceCalculation;

internal class ColorDifferenceService
{
    public static IEnumerable<ColorDifference> GetColorDifferences(
        ThemeColors themeColors, ThemeColors expectedThemeColors)
    {
        // Primary
        yield return new("Primary", themeColors.Primary, expectedThemeColors.Primary);
        yield return new("OnPrimary", themeColors.OnPrimary, expectedThemeColors.OnPrimary);
        yield return new("PrimaryContainer", themeColors.PrimaryContainer, expectedThemeColors.PrimaryContainer);
        yield return new("OnPrimaryContainer", themeColors.OnPrimaryContainer, expectedThemeColors.OnPrimaryContainer);
        // Secondary
        yield return new("Secondary", themeColors.Secondary, expectedThemeColors.Secondary);
        yield return new("OnSecondary", themeColors.OnSecondary, expectedThemeColors.OnSecondary);
        yield return new("SecondaryContainer", themeColors.SecondaryContainer, expectedThemeColors.SecondaryContainer);
        yield return new("OnSecondaryContainer", themeColors.OnSecondaryContainer, expectedThemeColors.OnSecondaryContainer);
        // Tertiary
        yield return new("Tertiary", themeColors.Tertiary, expectedThemeColors.Tertiary);
        yield return new("OnTertiary", themeColors.OnTertiary, expectedThemeColors.OnTertiary);
        yield return new("TertiaryContainer", themeColors.TertiaryContainer, expectedThemeColors.TertiaryContainer);
        yield return new("OnTertiaryContainer", themeColors.OnTertiaryContainer, expectedThemeColors.OnTertiaryContainer);
        // Error
        yield return new("Error", themeColors.Error, expectedThemeColors.Error);
        yield return new("OnError", themeColors.OnError, expectedThemeColors.OnError);
        yield return new("ErrorContainer", themeColors.ErrorContainer, expectedThemeColors.ErrorContainer);
        yield return new("OnErrorContainer", themeColors.OnErrorContainer, expectedThemeColors.OnErrorContainer);
        // Surface
        yield return new("Surface", themeColors.Surface, expectedThemeColors.Surface);
        yield return new("SurfaceVariant", themeColors.SurfaceVariant, expectedThemeColors.SurfaceVariant);
        yield return new("OnSurface", themeColors.OnSurface, expectedThemeColors.OnSurface);
        yield return new("OnSurfaceVariant", themeColors.OnSurfaceVariant, expectedThemeColors.OnSurfaceVariant);
        yield return new("SurfaceDim", themeColors.SurfaceDim, expectedThemeColors.SurfaceDim);
        yield return new("SurfaceBright", themeColors.SurfaceBright, expectedThemeColors.SurfaceBright);
        yield return new("SurfaceTint", themeColors.SurfaceTint, expectedThemeColors.SurfaceTint);
        // Background
        yield return new("Background", themeColors.Background, expectedThemeColors.Background);
        yield return new("OnBackground", themeColors.OnBackground, expectedThemeColors.OnBackground);
        // Outline
        yield return new("Outline", themeColors.Outline, expectedThemeColors.Outline);
        yield return new("OutlineVariant", themeColors.OutlineVariant, expectedThemeColors.OutlineVariant);
        // Shadow
        yield return new("Shadow", themeColors.Shadow, expectedThemeColors.Shadow);
        yield return new("Scrim", themeColors.Scrim, expectedThemeColors.Scrim);
        // Inverse
        yield return new("InverseSurface", themeColors.InverseSurface, expectedThemeColors.InverseSurface);
        yield return new("InverseOnSurface", themeColors.InverseOnSurface, expectedThemeColors.InverseOnSurface);
        yield return new("InversePrimary", themeColors.InversePrimary, expectedThemeColors.InversePrimary);
        // Primary Fixed
        yield return new("PrimaryFixed", themeColors.PrimaryFixed, expectedThemeColors.PrimaryFixed);
        yield return new("OnPrimaryFixed", themeColors.OnPrimaryFixed, expectedThemeColors.OnPrimaryFixed);
        yield return new("PrimaryFixedDim", themeColors.PrimaryFixedDim, expectedThemeColors.PrimaryFixedDim);
        yield return new("OnPrimaryFixedVariant", themeColors.OnPrimaryFixedVariant, expectedThemeColors.OnPrimaryFixedVariant);
        // Secondary Fixed
        yield return new("SecondaryFixed", themeColors.SecondaryFixed, expectedThemeColors.SecondaryFixed);
        yield return new("OnSecondaryFixed", themeColors.OnSecondaryFixed, expectedThemeColors.OnSecondaryFixed);
        yield return new("SecondaryFixedDim", themeColors.SecondaryFixedDim, expectedThemeColors.SecondaryFixedDim);
        yield return new("OnSecondaryFixedVariant", themeColors.OnSecondaryFixedVariant, expectedThemeColors.OnSecondaryFixedVariant);
        // Tertiary Fixed
        yield return new("TertiaryFixed", themeColors.TertiaryFixed, expectedThemeColors.TertiaryFixed);
        yield return new("OnTertiaryFixed", themeColors.OnTertiaryFixed, expectedThemeColors.OnTertiaryFixed);
        yield return new("TertiaryFixedDim", themeColors.TertiaryFixedDim, expectedThemeColors.TertiaryFixedDim);
        yield return new("OnTertiaryFixedVariant", themeColors.OnTertiaryFixedVariant, expectedThemeColors.OnTertiaryFixedVariant);
        // Surface Container
        yield return new("SurfaceContainerLowest", themeColors.SurfaceContainerLowest, expectedThemeColors.SurfaceContainerLowest);
        yield return new("SurfaceContainerLow", themeColors.SurfaceContainerLow, expectedThemeColors.SurfaceContainerLow);
        yield return new("SurfaceContainer", themeColors.SurfaceContainer, expectedThemeColors.SurfaceContainer);
        yield return new("SurfaceContainerHigh", themeColors.SurfaceContainerHigh, expectedThemeColors.SurfaceContainerHigh);
        yield return new("SurfaceContainerHighest", themeColors.SurfaceContainerHighest, expectedThemeColors.SurfaceContainerHighest);
    }
}
