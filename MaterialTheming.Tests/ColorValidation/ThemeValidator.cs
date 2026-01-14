using MaterialTheming.Tests.ColorDifferenceCalculation;
using MaterialTheming.Tests.KnownTestThemes;
using MaterialTheming.Tests.ThemeCreation;

namespace MaterialTheming.Tests.ColorValidation;

internal class ThemeValidator
{
    public static ThemeValidationResult ValidateThemeColors<TTestTheme>()
        where TTestTheme : ITestTheme, new()
    {
        var theme = ThemeCreationService.CreateTheme<TTestTheme>();
        return CreateFromColorDifferences(
            ColorDifferenceService.GetColorDifferences<TTestTheme>(theme));
    }

    public static ThemeValidationResult ValidateThemeColors(ITestTheme testTheme)
    {
        var theme = ThemeCreationService.CreateTheme(testTheme);

        return CreateFromColorDifferences(
            ColorDifferenceService.GetColorDifferences(theme, testTheme));
    }
    private static ThemeValidationResult CreateFromColorDifferences(IEnumerable<ColorDifference> colorDifferences)
    {
        var outOfSpecColorDifferences = ColorDifferenceValidationService.FilterToOutOfSpecColorDifferences(colorDifferences);
        return new ThemeValidationResult(outOfSpecColorDifferences);
    }
}
