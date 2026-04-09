using MaterialTheming.Tests.ColorDifferenceCalculation;
using MaterialTheming.Tests.KnownTestThemes;
using MaterialTheming.Tests.ThemeCreation;

namespace MaterialTheming.Tests.ColorValidation;

internal class ThemeValidator
{
    public static ThemeValidationResult ValidateThemeColors(ITestTheme testTheme)
    {
        var themeColors = ThemeCreationService.CreateThemeColors(testTheme);

        return CreateFromColorDifferences(
            testTheme.GetType(),
            ColorDifferenceService.GetColorDifferences(themeColors, testTheme));
    }
    private static ThemeValidationResult CreateFromColorDifferences(Type testThemeType, IEnumerable<ColorDifference> colorDifferences)
    {
        var outOfSpecColorDifferences = ColorDifferenceValidationService.FilterToOutOfSpecColorDifferences(colorDifferences);
        return new ThemeValidationResult(testThemeType, outOfSpecColorDifferences);
    }
}
