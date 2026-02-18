namespace MaterialTheming.Tests.KnownTestThemes.FruitSalad;

internal class LightMode_MediumContrast_Spec2026_Orange : ITestTheme
{
    public string SourceColor => "#D77837"; //Orange
    public bool IsDark => false;
    public Variant Variant => Variant.FruitSalad;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#651738";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#AA4F6F";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#5B2238";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#9D586F";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#5A2802";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#9D5D33";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#740006";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#CF2C27";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#FFF8F5";
    public string SurfaceVariant => "#FFDBC8";
    public string OnSurface => "#1B0E07";
    public string OnSurfaceVariant => "#493121";
    public string SurfaceDim => "#DBC2B4";
    public string SurfaceBright => "#FFF8F5";
    public string SurfaceTint => "#984061";
    // Background
    public string Background => "#FFF8F5";
    public string OnBackground => "#261910";
    // Outline
    public string Outline => "#694C3C";
    public string OutlineVariant => "#856655";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#3D2D24";
    public string InverseOnSurface => "#FFEDE5";
    public string InversePrimary => "#FFB1C8";
    // Primary Fixed
    public string PrimaryFixed => "#AA4F6F";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#8C3757";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#9D586F";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#804056";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#9D5D33";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#80461E";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFF1EA";
    public string SurfaceContainer => "#FEE3D5";
    public string SurfaceContainerHigh => "#F2D8CA";
    public string SurfaceContainerHighest => "#E6CDBF";
}
