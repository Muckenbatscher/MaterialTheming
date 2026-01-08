using MaterialTheming.Tests.ColorValidation;
using MaterialTheming.Tests.KnownTestThemes.TonalSpot;

namespace MaterialTheming.Tests;

[TestClass]
public sealed class TonalSpotTests
{
    [TestMethod]
    [DataRow(typeof(LightMode_NormalContrast_Spec2021))]
    [DataRow(typeof(DarkMode_NormalContrast_Spec2021))]
    [DataRow(typeof(LightMode_MediumContrast_Spec2021))]
    [DataRow(typeof(DarkMode_MediumContrast_Spec2021))]
    [DataRow(typeof(LightMode_HighContrast_Spec2021))]
    [DataRow(typeof(DarkMode_HighContrast_Spec2021))]
    [DataRow(typeof(LightMode_NormalContrast_Spec2025))]
    [DataRow(typeof(DarkMode_MediumContrast_Spec2025))]
    [DataRow(typeof(DarkMode_HighContrast_Spec2025))]
    public void TonalSpot_ForType(Type testThemeType)
    {
        var result = TestThemeTypeValidator.ValidateThemeType(testThemeType);

        Assert.IsTrue(result.IsValid, message: result.GetFailedValidationMessage());
    }
}
