using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class DarkMode_HighContrast_Spec2025_Orange : ITestTheme
{
    public string SourceColor => "#D77837"; //Orange
    public bool IsDark => true;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#FFDFCE";
    public string OnPrimary => "#4B1F00";
    public string PrimaryContainer => "#FFAF7E";
    public string OnPrimaryContainer => "#140500";
    // Secondary
    public string Secondary => "#D8E7FA";
    public string OnSecondary => "#1F2D3B";
    public string SecondaryContainer => "#97A5B7";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#D2E8FF";
    public string OnTertiary => "#002F4A";
    public string TertiaryContainer => "#6FC0FF";
    public string OnTertiaryContainer => "#000000";
    // Error
    public string Error => "#FFDED7";
    public string OnError => "#5A0E00";
    public string ErrorContainer => "#FF7E5E";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#190B01";
    public string SurfaceVariant => "#3A1F05";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#FFE0C8";
    public string SurfaceDim => "#190B01";
    public string SurfaceBright => "#432507";
    public string SurfaceTint => "#FFDFCE";
    // Background
    public string Background => "#190B01";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#DEB08A";
    public string OutlineVariant => "#C79B77";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#FFF8F5";
    public string InverseOnSurface => "#000000";
    public string InversePrimary => "#5D2A03";
    // Primary Fixed
    public string PrimaryFixed => "#FFAF7E";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#EFA172";
    public string OnPrimaryFixedVariant => "#000000";
    // Secondary Fixed
    public string SecondaryFixed => "#DBE9FD";
    public string OnSecondaryFixed => "#000000";
    public string SecondaryFixedDim => "#CDDBEE";
    public string OnSecondaryFixedVariant => "#172533";
    // Tertiary Fixed
    public string TertiaryFixed => "#6FC0FF";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#5FB2F1";
    public string OnTertiaryFixedVariant => "#000000";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#200F02";
    public string SurfaceContainer => "#291503";
    public string SurfaceContainerHigh => "#311A04";
    public string SurfaceContainerHighest => "#3A1F05";
}
