using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Content;

internal class LightMode_HighContrast_Spec2021_Blue : ITestTheme
{
    public string SourceColor => "#185FAA"; //Blue
    public bool IsDark => false;
    public Variant Variant => Variant.Content;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#002C58";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#00498B";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#182D49";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#364A67";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#490D5E";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#6A307E";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#600004";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#98000A";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#F9F9FF";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#000000";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#EFF0F7";
    public string SurfaceContainer => "#E1E2E9";
    public string SurfaceContainerHigh => "#D3D4DB";
    public string SurfaceContainerHighest => "#C5C6CD";
}
