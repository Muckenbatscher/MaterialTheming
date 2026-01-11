using MaterialTheming.Tests.ColorValidation;
using MaterialTheming.Tests.KnownTestThemes.TonalSpot;

namespace MaterialTheming.Tests;

[TestClass]
public sealed class TonalSpotTests
{
    [TestMethod]
    public void TonalSpot_LightMode_NormalContrast_Spec2021()
    {
        var result = ThemeValidator.ValidateThemeColors<LightMode_NormalContrast_Spec2021>();
        Assert.IsTrue(result.IsValid, message: result.GetFailedValidationMessage());
    }
    [TestMethod]
    public void TonalSpot_DarkMode_NormalContrast_Spec2021()
    {
        var result = ThemeValidator.ValidateThemeColors<DarkMode_NormalContrast_Spec2021>();
        Assert.IsTrue(result.IsValid, message: result.GetFailedValidationMessage());
    }

    [TestMethod]
    public void TonalSpot_LightMode_MediumContrast_Spec2021()
    {
        var result = ThemeValidator.ValidateThemeColors<LightMode_MediumContrast_Spec2021>();
        Assert.IsTrue(result.IsValid, message: result.GetFailedValidationMessage());
    }
    [TestMethod]
    public void TonalSpot_DarkMode_MediumContrast_Spec2021()
    {
        var result = ThemeValidator.ValidateThemeColors<DarkMode_MediumContrast_Spec2021>();
        Assert.IsTrue(result.IsValid, message: result.GetFailedValidationMessage());
    }

    [TestMethod]
    public void TonalSpot_LightMode_HighContrast_Spec2021()
    {
        var result = ThemeValidator.ValidateThemeColors<LightMode_HighContrast_Spec2021>();
        Assert.IsTrue(result.IsValid, message: result.GetFailedValidationMessage());
    }
    [TestMethod]
    public void TonalSpot_DarkMode_HighContrast_Spec2021()
    {
        var result = ThemeValidator.ValidateThemeColors<DarkMode_HighContrast_Spec2021>();
        Assert.IsTrue(result.IsValid, message: result.GetFailedValidationMessage());
    }

    [TestMethod]
    public void TonalSpot_LightMode_NormalContrast_Spec2025()
    {
        var result = ThemeValidator.ValidateThemeColors<LightMode_NormalContrast_Spec2025>();
        Assert.IsTrue(result.IsValid, message: result.GetFailedValidationMessage());
    }
    [TestMethod]
    public void TonalSpot_DarkMode_NormalContrast_Spec2025()
    {
        var result = ThemeValidator.ValidateThemeColors<DarkMode_NormalContrast_Spec2025>();
        Assert.IsTrue(result.IsValid, message: result.GetFailedValidationMessage());
    }
    [TestMethod]
    public void TonalSpot_LightMode_MediumContrast_Spec2025()
    {
        var result = ThemeValidator.ValidateThemeColors<LightMode_MediumContrast_Spec2025>();
        Assert.IsTrue(result.IsValid, message: result.GetFailedValidationMessage());
    }
    [TestMethod]
    public void TonalSpot_DarkMode_MediumContrast_Spec2025()
    {
        var result = ThemeValidator.ValidateThemeColors<DarkMode_MediumContrast_Spec2025>();
        Assert.IsTrue(result.IsValid, message: result.GetFailedValidationMessage());
    }
    [TestMethod]
    public void TonalSpot_LightMode_HighContrast_Spec2025()
    {
        var result = ThemeValidator.ValidateThemeColors<LightMode_HighContrast_Spec2025>();
        Assert.IsTrue(result.IsValid, message: result.GetFailedValidationMessage());
    }
    [TestMethod]
    public void TonalSpot_DarkMode_HighContrast_Spec2025()
    {
        var result = ThemeValidator.ValidateThemeColors<DarkMode_HighContrast_Spec2025>();
        Assert.IsTrue(result.IsValid, message: result.GetFailedValidationMessage());
    }
}
