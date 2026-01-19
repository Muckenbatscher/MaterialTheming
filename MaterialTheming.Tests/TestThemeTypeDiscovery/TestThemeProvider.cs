using MaterialTheming.Tests.KnownTestThemes;
using System.Reflection;

namespace MaterialTheming.Tests.TestThemeTypeDiscovery;

internal class TestThemeProvider
{
    public static IEnumerable<ITestTheme> GetTestThemes(TestThemePermutation testThemePermutation)
    {
        return GetAllTestThemes()
            .Where(theme => MatchesTestThemePermutation(theme, testThemePermutation))
            .ToArray();
    }
    private static bool MatchesTestThemePermutation(ITestTheme testTheme, TestThemePermutation testThemePermutation)
    {
        var permutationVariant = testThemePermutation.Variant;
        var permutationIsDark = testThemePermutation.Mode == ThemeMode.Dark;
        var permutationContrastLevelValue = testThemePermutation.ContrastLevel switch
        {
            ContrastLevel.High => 1.0,
            ContrastLevel.Medium => 0.5,
            _ => 0.0
        };
        var permutationSpec = testThemePermutation.SpecVersion;

        return testTheme.Variant == permutationVariant
            && testTheme.IsDark == permutationIsDark
            && testTheme.ContrastLevelValue == permutationContrastLevelValue
            && testTheme.SpecVersion == permutationSpec;
    }

    private static IEnumerable<ITestTheme> GetAllTestThemes()
    {
        var types = Assembly.GetCallingAssembly().GetTypes();
        var testThemeTypes = types.Where(IsTestThemeType);
        return testThemeTypes.Select(InstantiateTestTheme);
    }

    private static bool IsTestThemeType(Type type)
    {
        var testThemeType = typeof(ITestTheme);
        var isTestThemeImplementation = !type.IsAbstract && !type.IsInterface
            && testThemeType.IsAssignableFrom(type);
        var hasEmptyConstructors = type.GetConstructor([]) != null;
        return isTestThemeImplementation && hasEmptyConstructors;
    }

    private static ITestTheme InstantiateTestTheme(Type testThemeType)
    {
        var constructor = testThemeType.GetConstructor([]);
        return (ITestTheme)constructor!.Invoke([]);
    }
}
