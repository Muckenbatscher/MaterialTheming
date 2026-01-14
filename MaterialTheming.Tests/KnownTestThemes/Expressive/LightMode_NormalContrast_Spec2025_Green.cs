using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class LightMode_NormalContrast_Spec2025_Green : ITestTheme
{
    public string SourceColor => "#338745"; //Green
    public bool IsDark => false;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#1C6D31";
    public string OnPrimary => "#E9FFE5";
    public string PrimaryContainer => "#9EF0A5";
    public string OnPrimaryContainer => "#005B23";
    // Secondary
    public string Secondary => "#80553B";
    public string OnSecondary => "#FFF7F5";
    public string SecondaryContainer => "#FFDBC8";
    public string OnSecondaryContainer => "#71482F";
    // Tertiary
    public string Tertiary => "#994818";
    public string OnTertiary => "#FFF7F5";
    public string TertiaryContainer => "#FFA273";
    public string OnTertiaryContainer => "#602400";
    // Error
    public string Error => "#AA371C";
    public string OnError => "#FFF7F6";
    public string ErrorContainer => "#FA7150";
    public string OnErrorContainer => "#671200";
    // Surface
    public string Surface => "#E9FFED";
    public string SurfaceVariant => "#BCEECB";
    public string OnSurface => "#083A23";
    public string OnSurfaceVariant => "#3A684D";
    public string SurfaceDim => "#AEE7C1";
    public string SurfaceBright => "#E9FFED";
    public string SurfaceTint => "#1C6D31";
    // Background
    public string Background => "#E9FFED";
    public string OnBackground => "#083A23";
    // Outline
    public string Outline => "#568567";
    public string OutlineVariant => "#8CBD9D";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#001207";
    public string InverseOnSurface => "#89A390";
    public string InversePrimary => "#9EF0A5";
    // Primary Fixed
    public string PrimaryFixed => "#9EF0A5";
    public string OnPrimaryFixed => "#004619";
    public string PrimaryFixedDim => "#90E198";
    public string OnPrimaryFixedVariant => "#11662B";
    // Secondary Fixed
    public string SecondaryFixed => "#FFDBC8";
    public string OnSecondaryFixed => "#5B361E";
    public string SecondaryFixedDim => "#FFC9AB";
    public string OnSecondaryFixedVariant => "#7C5238";
    // Tertiary Fixed
    public string TertiaryFixed => "#FFA273";
    public string OnTertiaryFixed => "#3C1400";
    public string TertiaryFixedDim => "#F7915B";
    public string OnTertiaryFixedVariant => "#6E2B00";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#DAFCE3";
    public string SurfaceContainer => "#D0F7DB";
    public string SurfaceContainerHigh => "#C6F3D3";
    public string SurfaceContainerHighest => "#BCEECB";
}
