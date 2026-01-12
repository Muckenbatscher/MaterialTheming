using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class LightMode_HighContrast_Spec2025_Cyan : ITestTheme
{
    public string SourceColor => "#00BCD1"; //Cyan
    public bool IsDark => false;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#1C2527";
    public string OnPrimary => "#D2DCDE";
    public string PrimaryContainer => "#4A5456";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#212425";
    public string OnSecondary => "#D8DADB";
    public string SecondaryContainer => "#4F5353";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#0A2735";
    public string OnTertiary => "#C2DEF1";
    public string TertiaryContainer => "#3B5565";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#4F0409";
    public string OnError => "#FFCFCB";
    public string ErrorContainer => "#8E3432";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#FBF9F8";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#222425";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F5F3F3";
    public string SurfaceContainer => "#EEEEED";
    public string SurfaceContainerHigh => "#E8E8E8";
    public string SurfaceContainerHighest => "#E2E2E3";
}
