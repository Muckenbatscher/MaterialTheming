using MaterialTheming.Tests.TestThemeDiscovery.Json;
using MaterialTheming.Tests.ThemeCreation;
using System.ComponentModel;
using System.Text.Json;

namespace MaterialTheming.Tests.TestThemeDiscovery;

internal class TestThemeProvider
{
    private readonly TestThemePermutation _testThemePermutation;

    private TestThemeProvider(TestThemePermutation testThemePermutation)
    {
        _testThemePermutation = testThemePermutation;
    }

    public static TestThemeProvider CreateForPermutation(TestThemePermutation testThemePermutation)
        => new(testThemePermutation);

    public IEnumerable<TestTheme> GetTestThemes()
    {
        var filePath = BuildTestThemeFilePath();
        var jsonContent = File.ReadAllText(filePath);
        var testThemes = JsonSerializer.Deserialize<TestThemeSerialization[]>(jsonContent);
        return testThemes!.Select(CreateThemeColors);
    }
    private static TestTheme CreateThemeColors(TestThemeSerialization testTheme)
    {
        return new TestTheme(
            testTheme.Name,
            testTheme.Inputs.CreateThemeColors(),
            testTheme.Outputs.CreateThemeColors());
    }

    private string BuildTestThemeFilePath()
    {
        return Path.Combine(
            AppContext.BaseDirectory,
            "GeneratedTestThemes",
            GetVariantDirectoryName(_testThemePermutation.Variant),
            GetSpecVersionDirectoryName(_testThemePermutation.SpecVersion),
            GetPlatformDirectoryName(_testThemePermutation.Platform),
            GetModeDirectoryName(_testThemePermutation.Mode),
            GetContrastLevelFileName(_testThemePermutation.ContrastLevel));
    }
    private static string GetVariantDirectoryName(Variant variant)
    {
        return variant switch
        {
            Variant.CMF => "CMF",
            Variant.Content => "Content",
            Variant.Expressive => "Expressive",
            Variant.Fidelity => "Fidelity",
            Variant.FruitSalad => "FruitSalad",
            Variant.Monochrome => "Monochrome",
            Variant.Neutral => "Neutral",
            Variant.Rainbow => "Rainbow",
            Variant.TonalSpot => "TonalSpot",
            Variant.Vibrant => "Vibrant",
            _ => throw new InvalidEnumArgumentException(nameof(variant), (int)variant, typeof(Variant))
        };
    }
    private static string GetSpecVersionDirectoryName(SpecVersion specVersion)
    {
        return specVersion switch
        {
            SpecVersion.Spec2021 => "spec2021",
            SpecVersion.Spec2025 => "spec2025",
            SpecVersion.Spec2026 => "spec2026",
            _ => throw new InvalidEnumArgumentException(nameof(specVersion), (int)specVersion, typeof(SpecVersion))
        };
    }
    private static string GetPlatformDirectoryName(Platform platform)
    {
        return platform switch
        {
            Platform.Phone => "phone",
            Platform.Watch => "watch",
            _ => throw new InvalidEnumArgumentException(nameof(platform), (int)platform, typeof(Platform))
        };
    }
    private static string GetModeDirectoryName(ThemeMode mode)
    {
        return mode switch
        {
            ThemeMode.Dark => "dark",
            ThemeMode.Light => "light",
            _ => throw new InvalidEnumArgumentException(nameof(mode), (int)mode, typeof(ThemeMode))
        };
    }
    private static string GetContrastLevelFileName(ContrastLevel contrastLevel)
    {
        var fileName = contrastLevel switch
        {
            ContrastLevel.High => "high",
            ContrastLevel.Medium => "medium",
            ContrastLevel.Normal => "normal",
            _ => throw new InvalidEnumArgumentException(nameof(contrastLevel), (int)contrastLevel, typeof(ContrastLevel))
        };
        return $"{fileName}.json";
    }
}
