using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class LightMode_NormalContrast_Spec2025_Cyan : ITestTheme
{
    public string SourceColor => "#00BCD1"; //Cyan
    public bool IsDark => false;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#006975";
    public string OnPrimary => "#ECFCFF";
    public string PrimaryContainer => "#61E6FB";
    public string OnPrimaryContainer => "#00515B";

    public string Secondary => "#68597B";
    public string OnSecondary => "#FEF6FF";
    public string SecondaryContainer => "#EDDCFF";
    public string OnSecondaryContainer => "#5A4B6D";

    public string Tertiary => "#764C9D";
    public string OnTertiary => "#FFF6FF";
    public string TertiaryContainer => "#D5A5FE";
    public string OnTertiaryContainer => "#4B2171";

    public string Error => "#AC3434";
    public string OnError => "#FFF7F6";
    public string ErrorContainer => "#F56965";
    public string OnErrorContainer => "#65000B";

    public string Surface => "#F2FBFF";
    public string OnSurface => "#003844";
    public string OnSurfaceVariant => "#2F6676";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#E3F7FF";
    public string SurfaceContainer => "#D3F3FF";
    public string SurfaceContainerHigh => "#C3EFFF";
    public string SurfaceContainerHighest => "#B4EBFE";
}
