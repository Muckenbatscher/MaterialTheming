using MaterialTheming.Tests.KnownTestThemes;
using System.Reflection;

namespace MaterialTheming.Tests.ColorValidation;

internal class TestThemeTypeValidator
{
    public static ThemeValidationResult ValidateThemeType(Type testThemeType)
    {
        var targetTestThemeType = typeof(ITestTheme);
        if (!targetTestThemeType.IsAssignableFrom(testThemeType))
            throw new ArgumentException($"The type {testThemeType.FullName} does not implement {targetTestThemeType.FullName}.");

        var methodInfo = typeof(ThemeValidator)
            .GetMethod(
                name: nameof(ThemeValidator.ValidateThemeColors),
                bindingAttr: BindingFlags.Public | BindingFlags.Static,
                types: []);
        var genericMethod = methodInfo!.MakeGenericMethod(testThemeType);

        var result = genericMethod.Invoke(null, []);
        return (ThemeValidationResult)result!;
    }
}
