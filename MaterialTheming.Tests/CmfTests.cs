namespace MaterialTheming.Tests;

[TestClass]
public class CmfTests : TestThemeTests
{
    protected override Variant ThemeVariant => Variant.CMF;

    public override void LightMode_NormalContrast_Spec2021() { }
    public override void DarkMode_NormalContrast_Spec2021() { }
    public override void LightMode_MediumContrast_Spec2021() { }
    public override void DarkMode_MediumContrast_Spec2021() { }
    public override void LightMode_HighContrast_Spec2021() { }
    public override void DarkMode_HighContrast_Spec2021() { }
    public override void LightMode_NormalContrast_Spec2025() { }
    public override void DarkMode_NormalContrast_Spec2025() { }
    public override void LightMode_MediumContrast_Spec2025() { }
    public override void DarkMode_MediumContrast_Spec2025() { }
    public override void LightMode_HighContrast_Spec2025() { }
    public override void DarkMode_HighContrast_Spec2025() { }
}
