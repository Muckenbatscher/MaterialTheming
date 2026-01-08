using MaterialTheming.Tests.ColorValidation;
using MaterialTheming.Tests.KnownTestThemes;

namespace MaterialTheming.Tests;

[TestClass]
public sealed class TonalSpotTests
{
    [TestMethod]
    [DataRow(typeof(TonalSpot_LightMode_NormalContrast_Green))]
    [DataRow(typeof(TonalSpot_DarkMode_NormalContrast_Cyan))]
    public void TonalSpot_ForType(Type testThemeType)
    {
        var result = TestThemeTypeValidator.ValidateThemeType(testThemeType);

        Assert.IsTrue(result.IsValid, message: result.GetFailedValidationMessage());
    }
}
