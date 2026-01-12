using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class LightMode_MediumContrast_Spec2021_Blue : ITestTheme
{
    public string SourceColor => "#185FAA"; //Blue
    public bool IsDark => false;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#0C3765";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#4C6EA0";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#2D3747";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#636D80";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#442E4C";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#7D6485";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#740006";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#CF2C27";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#F9F9FF";
    public string OnSurface => "#0F1116";
    public string OnSurfaceVariant => "#33363D";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F3F3FA";
    public string SurfaceContainer => "#E7E8EE";
    public string SurfaceContainerHigh => "#DCDCE3";
    public string SurfaceContainerHighest => "#D0D1D8";
}
