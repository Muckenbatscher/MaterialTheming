using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class LightMode_HighContrast_Spec2025_Blue : ITestTheme
{
    public string SourceColor => "#185FAA"; //Blue
    public bool IsDark => false;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#002449";
    public string OnPrimary => "#C7DBFF";
    public string PrimaryContainer => "#36537C";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#1A2434";
    public string OnSecondary => "#D0DAF0";
    public string SecondaryContainer => "#485364";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#281D43";
    public string OnTertiary => "#E2D3FF";
    public string TertiaryContainer => "#584C75";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#510007";
    public string OnError => "#FFCFCB";
    public string ErrorContainer => "#972B2B";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#F9F9FE";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#20242B";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F2F3FA";
    public string SurfaceContainer => "#ECEDF6";
    public string SurfaceContainerHigh => "#E6E8F1";
    public string SurfaceContainerHighest => "#DFE2EC";
}
