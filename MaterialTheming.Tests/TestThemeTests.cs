using MaterialTheming.Tests.ColorValidation;
using MaterialTheming.Tests.KnownTestThemes;
using MaterialTheming.Tests.TestThemeTypeDiscovery;

namespace MaterialTheming.Tests;

public abstract class TestThemeTests
{
    public required TestContext TestContext { get; set; }
    protected abstract Variant ThemeVariant { get; }

    private void TestDiscoveredThemes(ThemeMode mode, ContrastLevel contrastLevel, SpecVersion specVersion)
    {
        var permutation = new TestThemePermutation(ThemeVariant, mode, contrastLevel, specVersion);
        var testThemeProvider = TestThemeProvider.CreateForPermutation(permutation);
        var testThemes = testThemeProvider.GetTestThemes();
        bool discoveredAny = false;
        foreach (var theme in testThemes)
        {
            discoveredAny = true;
            TestContext.WriteLine($"[{ThemeVariant}] Discovered: {theme.GetType().Name}");
            var result = ThemeValidator.ValidateThemeColors(theme);
            Assert.IsTrue(result.IsValid, message: result.GetFailedValidationMessage());
        }
        if (!discoveredAny)
        {
            TestContext.WriteLine($"No {nameof(ITestTheme)} implementations were found");
            TestContext.WriteLine($"Variant={ThemeVariant}, Mode={mode}, ContrastLevel={contrastLevel}, specVersion={specVersion}");
        }
    }

    [TestMethod]
    public void LightMode_NormalContrast_Spec2021()
    {
        TestDiscoveredThemes(ThemeMode.Light, ContrastLevel.Normal, SpecVersion.Spec2021);
    }
    [TestMethod]
    public void DarkMode_NormalContrast_Spec2021()
    {
        TestDiscoveredThemes(ThemeMode.Dark, ContrastLevel.Normal, SpecVersion.Spec2021);
    }

    [TestMethod]
    public void LightMode_MediumContrast_Spec2021()
    {
        TestDiscoveredThemes(ThemeMode.Light, ContrastLevel.Medium, SpecVersion.Spec2021);
    }
    [TestMethod]
    public void DarkMode_MediumContrast_Spec2021()
    {
        TestDiscoveredThemes(ThemeMode.Dark, ContrastLevel.Medium, SpecVersion.Spec2021);
    }

    [TestMethod]
    public void LightMode_HighContrast_Spec2021()
    {
        TestDiscoveredThemes(ThemeMode.Light, ContrastLevel.High, SpecVersion.Spec2021);
    }
    [TestMethod]
    public void DarkMode_HighContrast_Spec2021()
    {
        TestDiscoveredThemes(ThemeMode.Dark, ContrastLevel.High, SpecVersion.Spec2021);
    }

    [TestMethod]
    public void LightMode_NormalContrast_Spec2025()
    {
        TestDiscoveredThemes(ThemeMode.Light, ContrastLevel.Normal, SpecVersion.Spec2025);
    }
    [TestMethod]
    public void DarkMode_NormalContrast_Spec2025()
    {
        TestDiscoveredThemes(ThemeMode.Dark, ContrastLevel.Normal, SpecVersion.Spec2025);
    }
    [TestMethod]
    public void LightMode_MediumContrast_Spec2025()
    {
        TestDiscoveredThemes(ThemeMode.Light, ContrastLevel.Medium, SpecVersion.Spec2025);
    }
    [TestMethod]
    public void DarkMode_MediumContrast_Spec2025()
    {
        TestDiscoveredThemes(ThemeMode.Dark, ContrastLevel.Medium, SpecVersion.Spec2025);
    }
    [TestMethod]
    public void LightMode_HighContrast_Spec2025()
    {
        TestDiscoveredThemes(ThemeMode.Light, ContrastLevel.High, SpecVersion.Spec2025);
    }
    [TestMethod]
    public void DarkMode_HighContrast_Spec2025()
    {
        TestDiscoveredThemes(ThemeMode.Dark, ContrastLevel.High, SpecVersion.Spec2025);
    }

    [TestMethod]
    public void LightMode_NormalContrast_Spec2026()
    {
        TestDiscoveredThemes(ThemeMode.Light, ContrastLevel.Normal, SpecVersion.Spec2026);
    }
    [TestMethod]
    public void DarkMode_NormalContrast_Spec2026()
    {
        TestDiscoveredThemes(ThemeMode.Dark, ContrastLevel.Normal, SpecVersion.Spec2026);
    }
    [TestMethod]
    public void LightMode_MediumContrast_Spec2026()
    {
        TestDiscoveredThemes(ThemeMode.Light, ContrastLevel.Medium, SpecVersion.Spec2026);
    }
    [TestMethod]
    public void DarkMode_MediumContrast_Spec2026()
    {
        TestDiscoveredThemes(ThemeMode.Dark, ContrastLevel.Medium, SpecVersion.Spec2026);
    }
    [TestMethod]
    public void LightMode_HighContrast_Spec2026()
    {
        TestDiscoveredThemes(ThemeMode.Light, ContrastLevel.High, SpecVersion.Spec2026);
    }
    [TestMethod]
    public void DarkMode_HighContrast_Spec2026()
    {
        TestDiscoveredThemes(ThemeMode.Dark, ContrastLevel.High, SpecVersion.Spec2026);
    }
}
