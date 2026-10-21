namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class DarkMode_NormalContrast_Spec2026_Watch_Yellow : ITestTheme
{
    public string SourceColor => "#B2B037"; //Yellow
    public bool IsDark => true;
    public Variant Variant => Variant.Expressive;
    public Platform Platform => Platform.Watch;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#FEFB96";
    public string OnPrimary => "#4F4E00";
    public string PrimaryContainer => "#4A4900";
    public string OnPrimaryContainer => "#E7E582";
    // Secondary
    public string Secondary => "#CBDAFE";
    public string OnSecondary => "#2B3A56";
    public string SecondaryContainer => "#384764";
    public string OnSecondaryContainer => "#D4E0FF";
    // Tertiary
    public string Tertiary => "#BECEFF";
    public string OnTertiary => "#001F56";
    public string TertiaryContainer => "#7F9EF1";
    public string OnTertiaryContainer => "#001239";
    // Error
    public string Error => "#FFBFB0";
    public string OnError => "#3B0600";
    public string ErrorContainer => "#7D2C19";
    public string OnErrorContainer => "#FFD7CE";
    // Surface
    public string Surface => "#000000";
    public string SurfaceVariant => "#282700";
    public string OnSurface => "#ECE9CD";
    public string OnSurfaceVariant => "#D2CFB4";
    public string SurfaceDim => "#0F0F02";
    public string SurfaceBright => "#2E2E00";
    public string SurfaceTint => "#FEFB96";
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
    public string InverseOnSurface => "#575641";
    public string InversePrimary => "#595800";
    // Primary Fixed
    public string PrimaryFixed => "#FEFB96";
    public string OnPrimaryFixed => "#4F4E00";
    public string PrimaryFixedDim => "#EFED89";
    public string OnPrimaryFixedVariant => "#4A4900";
    // Secondary Fixed
    public string SecondaryFixed => "#CBDAFE";
    public string OnSecondaryFixed => "#2B3A56";
    public string SecondaryFixedDim => "#BDCCF0";
    public string OnSecondaryFixedVariant => "#384764";
    // Tertiary Fixed
    public string TertiaryFixed => "#BECEFF";
    public string OnTertiaryFixed => "#001F56";
    public string TertiaryFixedDim => "#8CACFF";
    public string OnTertiaryFixedVariant => "#163D8A";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#272715";
    public string SurfaceContainer => "#32311F";
    public string SurfaceContainerHigh => "#3D3C29";
    public string SurfaceContainerHighest => "#282700";
}
