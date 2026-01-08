using MaterialTheming.Tests.KnownTestThemes;
using MaterialTheming.Tests.ThemeCreation;

namespace MaterialTheming.Tests.ColorValidation;

internal class ThemeValidator
{
    public static ThemeValidationResult ValidateThemeColors<TTestTheme>()
        where TTestTheme : ITestTheme, new()
    {
        return ValidateThemeColors<TTestTheme, TTestTheme>();
    }

    public static ThemeValidationResult ValidateThemeColors<TTestThemeParameters, TExpectedThemeColors>()
        where TTestThemeParameters : IThemeCreationParameters, new()
        where TExpectedThemeColors : IExpectedThemeColors, new()
    {
        var theme = ThemeCreationService.CreateTheme<TTestThemeParameters>();

        var colorDifferences = ColorDifferenceService.GetColorDifferences<TExpectedThemeColors>(theme);
        var outOfSpecColorDifferences = ColorDifferenceValidationService.FilterToOutOfSpecColorDifferences(colorDifferences);
        return new ThemeValidationResult(outOfSpecColorDifferences);
    }
}
