using MaterialTheming.Tests.ColorValidation;
using MaterialTheming.Tests.TestThemeDiscovery;

namespace MaterialTheming.Tests;

public abstract class TestThemeTests
{
    public required TestContext TestContext { get; set; }
    protected abstract Variant ThemeVariant { get; }

    private void TestDiscoveredThemes(ThemeMode mode, Platform platform, ContrastLevel contrastLevel, SpecVersion specVersion)
    {
        var permutation = new TestThemePermutation(
            Variant: ThemeVariant,
            Platform: platform,
            Mode: mode,
            ContrastLevel: contrastLevel,
            SpecVersion: specVersion);
        var testThemeProvider = TestThemeProvider.CreateForPermutation(permutation);
        var testThemes = testThemeProvider.GetTestThemes();

        var resultCollection = new TestThemeResultCollection();
        bool discoveredAny = false;
        foreach (var theme in testThemes)
        {
            discoveredAny = true;
            TestContext.WriteLine($"[{ThemeVariant}] Discovered: {theme.Name}");
            var result = ThemeValidator.ValidateThemeColors(theme);
            resultCollection.AddResult(result);
        }
        if (!discoveredAny)
        {
            var messageLines = new List<string>()
            {
                $"No {nameof(TestTheme)} implementations were found",
                $"Variant={ThemeVariant}, Mode={mode}, ContrastLevel={contrastLevel}, specVersion={specVersion}"
            };
            Assert.Fail(string.Join(Environment.NewLine, messageLines));
            return;
        }

        Assert.IsFalse(
            condition: resultCollection.HasInvalidResults,
            message: resultCollection.GetConcatenatedFailedResultMessage());
    }

    [TestMethod]
    public virtual void LightMode_NormalContrast_Spec2021_Phone()
    {
        TestDiscoveredThemes(ThemeMode.Light, Platform.Phone, ContrastLevel.Normal, SpecVersion.Spec2021);
    }
    [TestMethod]
    public virtual void LightMode_NormalContrast_Spec2021_Watch()
    {
        TestDiscoveredThemes(ThemeMode.Light, Platform.Watch, ContrastLevel.Normal, SpecVersion.Spec2021);
    }
    [TestMethod]
    public virtual void DarkMode_NormalContrast_Spec2021_Phone()
    {
        TestDiscoveredThemes(ThemeMode.Dark, Platform.Phone, ContrastLevel.Normal, SpecVersion.Spec2021);
    }
    [TestMethod]
    public virtual void DarkMode_NormalContrast_Spec2021_Watch()
    {
        TestDiscoveredThemes(ThemeMode.Dark, Platform.Watch, ContrastLevel.Normal, SpecVersion.Spec2021);
    }

    [TestMethod]
    public virtual void LightMode_MediumContrast_Spec2021_Phone()
    {
        TestDiscoveredThemes(ThemeMode.Light, Platform.Phone, ContrastLevel.Medium, SpecVersion.Spec2021);
    }
    [TestMethod]
    public virtual void LightMode_MediumContrast_Spec2021_Watch()
    {
        TestDiscoveredThemes(ThemeMode.Light, Platform.Watch, ContrastLevel.Medium, SpecVersion.Spec2021);
    }
    [TestMethod]
    public virtual void DarkMode_MediumContrast_Spec2021_Phone()
    {
        TestDiscoveredThemes(ThemeMode.Dark, Platform.Phone, ContrastLevel.Medium, SpecVersion.Spec2021);
    }
    [TestMethod]
    public virtual void DarkMode_MediumContrast_Spec2021_Watch()
    {
        TestDiscoveredThemes(ThemeMode.Dark, Platform.Watch, ContrastLevel.Medium, SpecVersion.Spec2021);
    }

    [TestMethod]
    public virtual void LightMode_HighContrast_Spec2021_Phone()
    {
        TestDiscoveredThemes(ThemeMode.Light, Platform.Phone, ContrastLevel.High, SpecVersion.Spec2021);
    }
    [TestMethod]
    public virtual void LightMode_HighContrast_Spec2021_Watch()
    {
        TestDiscoveredThemes(ThemeMode.Light, Platform.Watch, ContrastLevel.High, SpecVersion.Spec2021);
    }
    [TestMethod]
    public virtual void DarkMode_HighContrast_Spec2021_Phone()
    {
        TestDiscoveredThemes(ThemeMode.Dark, Platform.Phone, ContrastLevel.High, SpecVersion.Spec2021);
    }
    [TestMethod]
    public virtual void DarkMode_HighContrast_Spec2021_Watch()
    {
        TestDiscoveredThemes(ThemeMode.Dark, Platform.Watch, ContrastLevel.High, SpecVersion.Spec2021);
    }

    [TestMethod]
    public virtual void LightMode_NormalContrast_Spec2025_Phone()
    {
        TestDiscoveredThemes(ThemeMode.Light, Platform.Phone, ContrastLevel.Normal, SpecVersion.Spec2025);
    }
    [TestMethod]
    public virtual void LightMode_NormalContrast_Spec2025_Watch()
    {
        TestDiscoveredThemes(ThemeMode.Light, Platform.Watch, ContrastLevel.Normal, SpecVersion.Spec2025);
    }
    [TestMethod]
    public virtual void DarkMode_NormalContrast_Spec2025_Phone()
    {
        TestDiscoveredThemes(ThemeMode.Dark, Platform.Phone, ContrastLevel.Normal, SpecVersion.Spec2025);
    }
    [TestMethod]
    public virtual void DarkMode_NormalContrast_Spec2025_Watch()
    {
        TestDiscoveredThemes(ThemeMode.Dark, Platform.Watch, ContrastLevel.Normal, SpecVersion.Spec2025);
    }
    [TestMethod]
    public virtual void LightMode_MediumContrast_Spec2025_Phone()
    {
        TestDiscoveredThemes(ThemeMode.Light, Platform.Phone, ContrastLevel.Medium, SpecVersion.Spec2025);
    }
    [TestMethod]
    public virtual void LightMode_MediumContrast_Spec2025_Watch()
    {
        TestDiscoveredThemes(ThemeMode.Light, Platform.Watch, ContrastLevel.Medium, SpecVersion.Spec2025);
    }
    [TestMethod]
    public virtual void DarkMode_MediumContrast_Spec2025_Phone()
    {
        TestDiscoveredThemes(ThemeMode.Dark, Platform.Phone, ContrastLevel.Medium, SpecVersion.Spec2025);
    }
    [TestMethod]
    public virtual void DarkMode_MediumContrast_Spec2025_Watch()
    {
        TestDiscoveredThemes(ThemeMode.Dark, Platform.Watch, ContrastLevel.Medium, SpecVersion.Spec2025);
    }
    [TestMethod]
    public virtual void LightMode_HighContrast_Spec2025_Phone()
    {
        TestDiscoveredThemes(ThemeMode.Light, Platform.Phone, ContrastLevel.High, SpecVersion.Spec2025);
    }
    [TestMethod]
    public virtual void LightMode_HighContrast_Spec2025_Watch()
    {
        TestDiscoveredThemes(ThemeMode.Light, Platform.Watch, ContrastLevel.High, SpecVersion.Spec2025);
    }
    [TestMethod]
    public virtual void DarkMode_HighContrast_Spec2025_Phone()
    {
        TestDiscoveredThemes(ThemeMode.Dark, Platform.Phone, ContrastLevel.High, SpecVersion.Spec2025);
    }
    [TestMethod]
    public virtual void DarkMode_HighContrast_Spec2025_Watch()
    {
        TestDiscoveredThemes(ThemeMode.Dark, Platform.Watch, ContrastLevel.High, SpecVersion.Spec2025);
    }

    [TestMethod]
    public virtual void LightMode_NormalContrast_Spec2026_Phone()
    {
        TestDiscoveredThemes(ThemeMode.Light, Platform.Phone, ContrastLevel.Normal, SpecVersion.Spec2026);
    }
    [TestMethod]
    public virtual void LightMode_NormalContrast_Spec2026_Watch()
    {
        TestDiscoveredThemes(ThemeMode.Light, Platform.Watch, ContrastLevel.Normal, SpecVersion.Spec2026);
    }
    [TestMethod]
    public virtual void DarkMode_NormalContrast_Spec2026_Phone()
    {
        TestDiscoveredThemes(ThemeMode.Dark, Platform.Phone, ContrastLevel.Normal, SpecVersion.Spec2026);
    }
    [TestMethod]
    public virtual void DarkMode_NormalContrast_Spec2026_Watch()
    {
        TestDiscoveredThemes(ThemeMode.Dark, Platform.Watch, ContrastLevel.Normal, SpecVersion.Spec2026);
    }
    [TestMethod]
    public virtual void LightMode_MediumContrast_Spec2026_Phone()
    {
        TestDiscoveredThemes(ThemeMode.Light, Platform.Phone, ContrastLevel.Medium, SpecVersion.Spec2026);
    }
    [TestMethod]
    public virtual void LightMode_MediumContrast_Spec2026_Watch()
    {
        TestDiscoveredThemes(ThemeMode.Light, Platform.Watch, ContrastLevel.Medium, SpecVersion.Spec2026);
    }
    [TestMethod]
    public virtual void DarkMode_MediumContrast_Spec2026_Phone()
    {
        TestDiscoveredThemes(ThemeMode.Dark, Platform.Phone, ContrastLevel.Medium, SpecVersion.Spec2026);
    }
    [TestMethod]
    public virtual void DarkMode_MediumContrast_Spec2026_Watch()
    {
        TestDiscoveredThemes(ThemeMode.Dark, Platform.Watch, ContrastLevel.Medium, SpecVersion.Spec2026);
    }
    [TestMethod]
    public virtual void LightMode_HighContrast_Spec2026_Phone()
    {
        TestDiscoveredThemes(ThemeMode.Light, Platform.Phone, ContrastLevel.High, SpecVersion.Spec2026);
    }
    [TestMethod]
    public virtual void LightMode_HighContrast_Spec2026_Watch()
    {
        TestDiscoveredThemes(ThemeMode.Light, Platform.Watch, ContrastLevel.High, SpecVersion.Spec2026);
    }
    [TestMethod]
    public virtual void DarkMode_HighContrast_Spec2026_Phone()
    {
        TestDiscoveredThemes(ThemeMode.Dark, Platform.Phone, ContrastLevel.High, SpecVersion.Spec2026);
    }
    [TestMethod]
    public virtual void DarkMode_HighContrast_Spec2026_Watch()
    {
        TestDiscoveredThemes(ThemeMode.Dark, Platform.Watch, ContrastLevel.High, SpecVersion.Spec2026);
    }
}
