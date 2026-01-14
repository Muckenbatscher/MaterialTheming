using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class LightMode_NormalContrast_Spec2025_Orange : ITestTheme
{
    public string SourceColor => "#D77837"; //Orange
    public bool IsDark => false;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#6B5B53";
    public string OnPrimary => "#FFF6F2";
    public string PrimaryContainer => "#F4DED3";
    public string OnPrimaryContainer => "#5E4F47";
    // Secondary
    public string Secondary => "#665D59";
    public string OnSecondary => "#FFF7F5";
    public string SecondaryContainer => "#ECE0DB";
    public string OnSecondaryContainer => "#58504C";
    // Tertiary
    public string Tertiary => "#735B38";
    public string OnTertiary => "#FFF8F2";
    public string TertiaryContainer => "#FFDDB1";
    public string OnTertiaryContainer => "#654E2C";
    // Error
    public string Error => "#9E422C";
    public string OnError => "#FFF7F6";
    public string ErrorContainer => "#FE8B70";
    public string OnErrorContainer => "#742410";
    // Surface
    public string Surface => "#FFF8F6";
    public string SurfaceVariant => "#EBE0DC";
    public string OnSurface => "#37312F";
    public string OnSurfaceVariant => "#645E5A";
    public string SurfaceDim => "#E3D8D3";
    public string SurfaceBright => "#FFF8F6";
    public string SurfaceTint => "#6B5B53";
    // Background
    public string Background => "#FFF8F6";
    public string OnBackground => "#37312F";
    // Outline
    public string Outline => "#817976";
    public string OutlineVariant => "#B9B0AC";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#100E0D";
    public string InverseOnSurface => "#A19C9A";
    public string InversePrimary => "#FDE7DC";
    // Primary Fixed
    public string PrimaryFixed => "#F4DED3";
    public string OnPrimaryFixed => "#4A3C35";
    public string PrimaryFixedDim => "#E5D0C6";
    public string OnPrimaryFixedVariant => "#685850";
    // Secondary Fixed
    public string SecondaryFixed => "#ECE0DB";
    public string OnSecondaryFixed => "#453E3A";
    public string SecondaryFixedDim => "#DED2CD";
    public string OnSecondaryFixedVariant => "#625A56";
    // Tertiary Fixed
    public string TertiaryFixed => "#FFDDB1";
    public string OnTertiaryFixed => "#513C1C";
    public string TertiaryFixedDim => "#F0CFA4";
    public string OnTertiaryFixedVariant => "#6F5835";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FAF2EF";
    public string SurfaceContainer => "#F5ECE9";
    public string SurfaceContainerHigh => "#F0E6E2";
    public string SurfaceContainerHighest => "#EBE0DC";
}
