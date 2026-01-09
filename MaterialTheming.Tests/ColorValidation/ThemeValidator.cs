using MaterialTheming.Tests.ColorDifferenceCalculation;
using MaterialTheming.Tests.KnownTestThemes;
using MaterialTheming.Tests.ThemeCreation;

namespace MaterialTheming.Tests.ColorValidation;

internal class ThemeValidator
{
    public static ThemeValidationResult ValidateThemeColors<TTestTheme>()
        where TTestTheme : ITestTheme, new()
    {
        var testTheme = new TTestTheme();
        return ValidateThemeColors<TTestTheme>(testTheme);
    }

    public static ThemeValidationResult ValidateThemeColors<TTestTheme>(TTestTheme testTheme)
        where TTestTheme : ITestTheme, new()
    {
        var theme = ThemeCreationService.CreateTheme(testTheme);

        var colorDifferences = ColorDifferenceService.GetColorDifferences(theme, testTheme);
        var outOfSpecColorDifferences = ColorDifferenceValidationService.FilterToOutOfSpecColorDifferences(colorDifferences);
        return new ThemeValidationResult(outOfSpecColorDifferences);
    }
}
