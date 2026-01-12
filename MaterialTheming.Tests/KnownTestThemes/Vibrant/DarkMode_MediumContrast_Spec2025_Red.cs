using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class DarkMode_MediumContrast_Spec2025_Red : ITestTheme
{
    public string SourceColor => "#D2463D"; //Red
    public bool IsDark => true;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#FF9F95";
    public string OnPrimary => "#600004";
    public string PrimaryContainer => "#FF766A";
    public string OnPrimaryContainer => "#330001";

    public string Secondary => "#FF9DAA";
    public string OnSecondary => "#5F011E";
    public string SecondaryContainer => "#C04F63";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#D7A4FF";
    public string OnTertiary => "#450372";
    public string TertiaryContainer => "#CA90FA";
    public string OnTertiaryContainer => "#310053";

    public string Error => "#FF9DA8";
    public string OnError => "#5F001C";
    public string ErrorContainer => "#D73357";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#240209";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#EBA7AF";

    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#2C050D";
    public string SurfaceContainer => "#360812";
    public string SurfaceContainerHigh => "#3F0D18";
    public string SurfaceContainerHighest => "#48121D";
}
