namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class LightMode_MediumContrast_Spec2025_Watch_Yellow : ITestTheme
{
    public string SourceColor => "#B2B037"; //Yellow
    public bool IsDark => false;
    public Variant Variant => Variant.Expressive;
    public Platform Platform => Platform.Watch;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#FFFEFF";
    public string OnPrimary => "#302F00";
    public string PrimaryContainer => "#8B8931";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#FFFEFF";
    public string OnSecondary => "#061732";
    public string SecondaryContainer => "#7786A6";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#FFFEFF";
    public string OnTertiary => "#000000";
    public string TertiaryContainer => "#7F9EF1";
    public string OnTertiaryContainer => "#001239";
    // Error
    public string Error => "#FFBFB0";
    public string OnError => "#390600";
    public string ErrorContainer => "#CD6951";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#000000";
    public string SurfaceVariant => "#282700";
    public string OnSurface => "#FFFEFF";
    public string OnSurfaceVariant => "#D2CFB4";
    public string SurfaceDim => "#0F0F02";
    public string SurfaceBright => "#2E2E00";
    public string SurfaceTint => "#FFFEFF";
    // Background
    public string Background => "#000000";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#A9A78E";
    public string OutlineVariant => "#88876F";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#FEFADE";
    public string InverseOnSurface => "#3A3926";
    public string InversePrimary => "#3B3A00";
    // Primary Fixed
    public string PrimaryFixed => "#FEFB96";
    public string OnPrimaryFixed => "#302F00";
    public string PrimaryFixedDim => "#EFED89";
    public string OnPrimaryFixedVariant => "#4A4900";
    // Secondary Fixed
    public string SecondaryFixed => "#CBDAFE";
    public string OnSecondaryFixed => "#061732";
    public string SecondaryFixedDim => "#BDCCF0";
    public string OnSecondaryFixedVariant => "#2B3A56";
    // Tertiary Fixed
    public string TertiaryFixed => "#BECEFF";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#8CACFF";
    public string OnTertiaryFixedVariant => "#001F56";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#272715";
    public string SurfaceContainer => "#32311F";
    public string SurfaceContainerHigh => "#3D3C29";
    public string SurfaceContainerHighest => "#282700";
}
