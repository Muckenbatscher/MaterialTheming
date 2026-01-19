namespace MaterialTheming.Tests.KnownTestThemes.FruitSalad;

internal class LightMode_MediumContrast_Spec2021_Red : ITestTheme
{
    public string SourceColor => "#D2463D"; //Red
    public bool IsDark => false;
    public Variant Variant => Variant.FruitSalad;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#5C1A59";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#9B5394";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#53254F";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#905B89";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#5E231E";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#A25851";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#740006";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#CF2C27";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#FFF8F7";
    public string SurfaceVariant => "#FFDAD6";
    public string OnSurface => "#1B0E0C";
    public string OnSurfaceVariant => "#4B2F2C";
    public string SurfaceDim => "#DCC0BD";
    public string SurfaceBright => "#FFF8F7";
    public string SurfaceTint => "#8A4484";
    // Background
    public string Background => "#FFF8F7";
    public string OnBackground => "#271816";
    // Outline
    public string Outline => "#6A4B47";
    public string OutlineVariant => "#876561";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#3D2C2A";
    public string InverseOnSurface => "#FFEDEA";
    public string InversePrimary => "#FFABF3";
    // Primary Fixed
    public string PrimaryFixed => "#9B5394";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#7F3A7A";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#905B89";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#75436F";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#A25851";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#84413A";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFF0EE";
    public string SurfaceContainer => "#FFE2DE";
    public string SurfaceContainerHigh => "#F3D7D3";
    public string SurfaceContainerHighest => "#E7CBC8";
}
