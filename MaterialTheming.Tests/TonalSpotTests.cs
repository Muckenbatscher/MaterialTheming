using MaterialTheming.Tests.ColorValidation;
using MaterialTheming.Tests.KnownTestThemes;

namespace MaterialTheming.Tests;

[TestClass]
public sealed class TonalSpotTests
{
    [TestMethod]
    [DataRow(typeof(TonalSpot_LightMode_NormalContrast_Green))]
    [DataRow(typeof(TonalSpot_DarkMode_NormalContrast_Cyan))]
    [DataRow(typeof(TonalSpot_LightMode_MediumContrast_Blue))]
    [DataRow(typeof(TonalSpot_DarkMode_MediumContrast_Purple))]
    [DataRow(typeof(TonalSpot_LightMode_HighContrast_Magenta))]
    [DataRow(typeof(TonalSpot_DarkMode_HighContrast_Red))]
    public void TonalSpot_ForType(Type testThemeType)
    {
        var result = TestThemeTypeValidator.ValidateThemeType(testThemeType);

        Assert.IsTrue(result.IsValid, message: result.GetFailedValidationMessage());
    }
}
