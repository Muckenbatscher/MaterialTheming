using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Rainbow;

internal class LightMode_HighContrast_Spec2025_Orange : ITestTheme
{
    public string SourceColor => "#D77837"; //Orange
    public bool IsDark => false;
    public Variant Variant => Variant.Rainbow;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#4B2000";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#783600";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#3E2718";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#5E4333";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#2E2E05";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#4C4B20";
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
