using MaterialTheming.Tests.ColorDifferenceCalculation;
using MaterialTheming.Tests.TestThemeDiscovery;

namespace MaterialTheming.Tests.ColorValidation;

internal class ThemeValidator
{
    public static ThemeValidationResult ValidateThemeColors(TestTheme testTheme)
    {
        var differences = ColorDifferenceService.GetColorDifferences(
            testTheme.GeneratedThemeColors, testTheme.ExpectedThemeColors);
        return CreateFromColorDifferences(
            testTheme.Name,
            differences);
    }
    private static ThemeValidationResult CreateFromColorDifferences(string themeName, IEnumerable<ColorDifference> colorDifferences)
    {
        var outOfSpecColorDifferences = ColorDifferenceValidationService.FilterToOutOfSpecColorDifferences(colorDifferences);
        return new ThemeValidationResult(themeName, outOfSpecColorDifferences);
    }
}
