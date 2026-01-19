namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class LightMode_MediumContrast_Spec2021_Orange : ITestTheme
{
    public string SourceColor => "#D77837"; //Orange
    public bool IsDark => false;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#5A2802";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#9D5D33";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#493121";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#856655";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#39380E";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#706F40";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#740006";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#CF2C27";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#FFF8F5";
    public string SurfaceVariant => "#F4DED3";
    public string OnSurface => "#170F0B";
    public string OnSurfaceVariant => "#41332C";
    public string SurfaceDim => "#D3C3BC";
    public string SurfaceBright => "#FFF8F5";
    public string SurfaceTint => "#8C4F26";
    // Background
    public string Background => "#FFF8F5";
    public string OnBackground => "#221A15";
    // Outline
    public string Outline => "#5E4F47";
    public string OutlineVariant => "#7A6A61";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#382E29";
    public string InverseOnSurface => "#FFEDE5";
    public string InversePrimary => "#FFB68B";
    // Primary Fixed
    public string PrimaryFixed => "#9D5D33";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#80461E";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#856655";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#6B4F3E";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#706F40";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#58572A";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFF1EA";
    public string SurfaceContainer => "#F6E5DD";
    public string SurfaceContainerHigh => "#EADAD1";
    public string SurfaceContainerHighest => "#DFCEC6";
}
