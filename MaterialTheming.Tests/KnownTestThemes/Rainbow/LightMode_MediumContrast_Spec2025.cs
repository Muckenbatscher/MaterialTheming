using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Rainbow;

internal class LightMode_MediumContrast_Spec2025 : ITestTheme
{
    public string SourceColor => "#D2463D"; //red
    public bool IsDark => false;
    public Variant Variant => Variant.Rainbow;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#671A16";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#AF5047";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#4B2F2C";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#876561";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#453309";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#816A3B";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#740006";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#CF2C27";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#F9F9F9";
    public string OnSurface => "#111111";
    public string OnSurfaceVariant => "#363636";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F3F3F3";
    public string SurfaceContainer => "#E8E8E8";
    public string SurfaceContainerHigh => "#DDDDDD";
    public string SurfaceContainerHighest => "#D1D1D1";
}
