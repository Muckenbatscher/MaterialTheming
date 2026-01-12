using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class LightMode_MediumContrast_Spec2021_Red : ITestTheme
{
    public string SourceColor => "#D2463D"; //Red
    public bool IsDark => false;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#5E231E";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#A25851";
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

    public string Surface => "#FFF8F7";
    public string OnSurface => "#180F0E";
    public string OnSurfaceVariant => "#413331";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFF0EE";
    public string SurfaceContainer => "#F6E4E2";
    public string SurfaceContainerHigh => "#EBD9D7";
    public string SurfaceContainerHighest => "#DFCECB";
}
