using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class LightMode_HighContrast_Spec2021_Orange : ITestTheme
{
    public string SourceColor => "#D77837"; //Orange
    public bool IsDark => false;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#4B2000";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#723A13";
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

    public string Surface => "#FFF8F5";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#000000";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFEDE5";
    public string SurfaceContainer => "#F0DFD7";
    public string SurfaceContainerHigh => "#E2D1C9";
    public string SurfaceContainerHighest => "#D3C3BC";
}
