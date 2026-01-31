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
#if NETFRAMEWORK
        var methodInfo = typeof(ThemeValidator)
            .GetMethod(
                name: nameof(ThemeValidator.ValidateThemeColors),
                bindingAttr: BindingFlags.Public | BindingFlags.Static,
                binder: null,
                types: [],
                modifiers: null);
#else
        var methodInfo = typeof(ThemeValidator)
            .GetMethod(
                name: nameof(ThemeValidator.ValidateThemeColors),
                bindingAttr: BindingFlags.Public | BindingFlags.Static,
                types: []);
#endif
        var genericMethod = methodInfo!.MakeGenericMethod(testThemeType);

        var result = genericMethod.Invoke(null, []);
        return (ThemeValidationResult)result!;
    }
}
