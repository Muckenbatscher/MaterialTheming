using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class DarkMode_HighContrast_Spec2025_Red : ITestTheme
{
    public string SourceColor => "#D2463D"; //Red
    public bool IsDark => true;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#FFDEDA";
    public string OnPrimary => "#600004";
    public string PrimaryContainer => "#FF7C70";
    public string OnPrimaryContainer => "#000000";

    public string Secondary => "#FFDDE0";
    public string OnSecondary => "#5E011E";
    public string SecondaryContainer => "#FA7C90";
    public string OnSecondaryContainer => "#000000";

    public string Tertiary => "#F3DEFF";
    public string OnTertiary => "#450272";
    public string TertiaryContainer => "#CA90FA";
    public string OnTertiaryContainer => "#000000";

    public string Error => "#FFDDDF";
    public string OnError => "#5F001C";
    public string ErrorContainer => "#FF798C";
    public string OnErrorContainer => "#000000";

    public string Surface => "#240209";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#FFDDE0";

    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#2C050D";
    public string SurfaceContainer => "#360812";
    public string SurfaceContainerHigh => "#3F0D18";
    public string SurfaceContainerHighest => "#48121D";
}
