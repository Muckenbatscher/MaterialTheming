using MaterialTheming.Tests.KnownTestThemes;
using System.Reflection;

namespace MaterialTheming.Tests.TestThemeTypeDiscovery;

internal class TestThemeProvider
{
    private readonly TestThemePermutation _testThemePermutation;

    private TestThemeProvider(TestThemePermutation testThemePermutation)
    {
        _testThemePermutation = testThemePermutation;
    }

    public static TestThemeProvider CreateForPermutation(TestThemePermutation testThemePermutation)
        => new(testThemePermutation);

    public IEnumerable<ITestTheme> GetTestThemes()
    {
        return GetAllTestThemes()
            .Where(MatchesTestThemePermutation)
            .ToArray();
    }
    private bool MatchesTestThemePermutation(ITestTheme testTheme)
    {
        var permutationVariant = _testThemePermutation.Variant;
        var permutationIsDark = _testThemePermutation.Mode == ThemeMode.Dark;
        var permutationContrastLevelValue = _testThemePermutation.ContrastLevel switch
        {
            ContrastLevel.High => 1.0,
            ContrastLevel.Medium => 0.5,
            _ => 0.0
        };
        var permutationSpec = _testThemePermutation.SpecVersion;

        return testTheme.Variant == permutationVariant
            && testTheme.IsDark == permutationIsDark
            && testTheme.ContrastLevelValue == permutationContrastLevelValue
            && testTheme.SpecVersion == permutationSpec;
    }

    private IEnumerable<ITestTheme> GetAllTestThemes()
    {
        var types = Assembly.GetCallingAssembly().GetTypes();
        var testThemeTypes = types.Where(IsTestThemeType);
        return testThemeTypes.Select(InstantiateTestTheme);
    }

    private bool IsTestThemeType(Type type)
    {
        var testThemeType = typeof(ITestTheme);
        var isTestThemeImplementation = !type.IsAbstract && !type.IsInterface
            && testThemeType.IsAssignableFrom(type);
        var hasEmptyConstructors = type.GetConstructor([]) != null;
        return isTestThemeImplementation && hasEmptyConstructors;
    }

    private ITestTheme InstantiateTestTheme(Type testThemeType)
    {
        var constructor = testThemeType.GetConstructor([]);
        return (ITestTheme)constructor!.Invoke([]);
    }
}
