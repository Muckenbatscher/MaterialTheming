using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class LightMode_HighContrast_Spec2021_Red : ITestTheme
{
    public string SourceColor => "#D2463D"; //Red
    public bool IsDark => false;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#511A15";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#763630";
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

    public string Surface => "#FFF8F7";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#000000";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFEDEA";
    public string SurfaceContainer => "#F1DEDC";
    public string SurfaceContainerHigh => "#E2D0CE";
    public string SurfaceContainerHighest => "#D4C3C0";
}
