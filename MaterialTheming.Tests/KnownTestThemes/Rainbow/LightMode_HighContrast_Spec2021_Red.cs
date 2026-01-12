using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Rainbow;

internal class LightMode_HighContrast_Spec2021_Red : ITestTheme
{
    public string SourceColor => "#D2463D"; //Red
    public bool IsDark => false;
    public Variant Variant => Variant.Rainbow;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#59100D";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#812D27";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#3F2522";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#60423E";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#3A2902";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#5A461B";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#600004";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#98000A";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#F9F9F9";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#000000";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F1F1F1";
    public string SurfaceContainer => "#E2E2E2";
    public string SurfaceContainerHigh => "#D4D4D4";
    public string SurfaceContainerHighest => "#C6C6C6";
}
