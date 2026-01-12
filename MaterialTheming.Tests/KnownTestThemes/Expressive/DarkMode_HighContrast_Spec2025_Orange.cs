using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class DarkMode_HighContrast_Spec2025_Orange : ITestTheme
{
    public string SourceColor => "#D77837"; //Orange
    public bool IsDark => true;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#FFDFCE";
    public string OnPrimary => "#4B1F00";
    public string PrimaryContainer => "#FFAF7E";
    public string OnPrimaryContainer => "#140500";

    public string Secondary => "#D8E7FA";
    public string OnSecondary => "#1F2D3B";
    public string SecondaryContainer => "#97A5B7";
    public string OnSecondaryContainer => "#000000";

    public string Tertiary => "#D2E8FF";
    public string OnTertiary => "#002F4A";
    public string TertiaryContainer => "#6FC0FF";
    public string OnTertiaryContainer => "#000000";

    public string Error => "#FFDED7";
    public string OnError => "#5A0E00";
    public string ErrorContainer => "#FF7E5E";
    public string OnErrorContainer => "#000000";

    public string Surface => "#190B01";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#FFE0C8";

    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#200F02";
    public string SurfaceContainer => "#291503";
    public string SurfaceContainerHigh => "#311A04";
    public string SurfaceContainerHighest => "#3A1F05";
}
