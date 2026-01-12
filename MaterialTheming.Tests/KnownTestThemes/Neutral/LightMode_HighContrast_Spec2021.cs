using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class LightMode_HighContrast_Spec2021 : ITestTheme
{
    public string SourceColor => "#185FAA"; //blue
    public bool IsDark => false;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#262C38";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#434956";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#292C33";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#464951";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#222D3D";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#3F4A5B";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#600004";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#98000A";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#FBF8FA";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#000000";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F3F0F1";
    public string SurfaceContainer => "#E4E2E3";
    public string SurfaceContainerHigh => "#D6D4D5";
    public string SurfaceContainerHighest => "#C8C6C7";
}
