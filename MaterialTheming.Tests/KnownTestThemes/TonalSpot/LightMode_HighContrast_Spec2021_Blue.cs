using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class LightMode_HighContrast_Spec2021_Blue : ITestTheme
{
    public string SourceColor => "#185FAA"; //Blue
    public bool IsDark => false;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#002C58";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#264A79";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#222D3D";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#3F4A5B";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#392441";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#584160";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#600004";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#98000A";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#F9F9FF";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#000000";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F0F0F7";
    public string SurfaceContainer => "#E1E2E9";
    public string SurfaceContainerHigh => "#D3D4DA";
    public string SurfaceContainerHighest => "#C5C6CD";
}
