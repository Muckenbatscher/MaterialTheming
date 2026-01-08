using MaterialTheming.Tests.ColorValidation;
using MaterialTheming.Tests.KnownTestThemes;

namespace MaterialTheming.Tests;

[TestClass]
public sealed class TonalSpotTests
{
    [TestMethod]
    public void LightMode_NormalContrast_Green()
    {
        var result = ThemeValidator.ValidateThemeColors<
            TonalSpot_LightMode_NormalContrast_Green>();

        Assert.IsTrue(result.IsValid, message: result.GetFailedValidationMessage());
    }
}
