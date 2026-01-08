using MaterialTheming.Tests.ColorValidation;
using MaterialTheming.Tests.KnownTestThemes.TonalSpot;

namespace MaterialTheming.Tests;

[TestClass]
public sealed class TonalSpotTests
{
    [TestMethod]
    [DataRow(typeof(LightMode_NormalContrast_Green))]
    [DataRow(typeof(DarkMode_NormalContrast_Cyan))]
    [DataRow(typeof(LightMode_MediumContrast_Blue))]
    [DataRow(typeof(DarkMode_MediumContrast_Purple))]
    [DataRow(typeof(LightMode_HighContrast_Magenta))]
    [DataRow(typeof(DarkMode_HighContrast_Red))]
    public void TonalSpot_ForType(Type testThemeType)
    {
        var result = TestThemeTypeValidator.ValidateThemeType(testThemeType);

        Assert.IsTrue(result.IsValid, message: result.GetFailedValidationMessage());
    }
}
