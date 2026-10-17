namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class DarkMode_HighContrast_Spec2025_Watch_Yellow : ITestTheme
{
    public string SourceColor => "#B2B037"; //Yellow
    public bool IsDark => true;
    public Variant Variant => Variant.Expressive;
    public Platform Platform => Platform.Watch;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#FFFFFF";
    public string OnPrimary => "#000000";
    public string PrimaryContainer => "#ACAA4E";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#FFFFFF";
    public string OnSecondary => "#000000";
    public string SecondaryContainer => "#97A6C8";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#FFFFFF";
    public string OnTertiary => "#000000";
    public string TertiaryContainer => "#84A3F6";
    public string OnTertiaryContainer => "#000000";
    // Error
    public string Error => "#FFBFB0";
    public string OnError => "#000000";
    public string ErrorContainer => "#F4886D";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#000000";
    public string SurfaceVariant => "#282700";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#FFFEFF";
    public string SurfaceDim => "#0F0F02";
    public string SurfaceBright => "#2E2E00";
    public string SurfaceTint => "#FFFFFF";
    // Background
    public string Background => "#000000";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#D2CFB4";
    public string OutlineVariant => "#A9A78E";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#FEFADE";
    public string InverseOnSurface => "#000000";
    public string InversePrimary => "#000000";
    // Primary Fixed
    public string PrimaryFixed => "#FEFB96";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#EFED89";
    public string OnPrimaryFixedVariant => "#302F00";
    // Secondary Fixed
    public string SecondaryFixed => "#CBDAFE";
    public string OnSecondaryFixed => "#000000";
    public string SecondaryFixedDim => "#BDCCF0";
    public string OnSecondaryFixedVariant => "#061732";
    // Tertiary Fixed
    public string TertiaryFixed => "#BECEFF";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#8CACFF";
    public string OnTertiaryFixedVariant => "#000000";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#272715";
    public string SurfaceContainer => "#32311F";
    public string SurfaceContainerHigh => "#3D3C29";
    public string SurfaceContainerHighest => "#282700";
}
