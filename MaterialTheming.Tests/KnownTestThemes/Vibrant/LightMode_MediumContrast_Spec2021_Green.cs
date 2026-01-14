using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class LightMode_MediumContrast_Spec2021_Green : ITestTheme
{
    public string SourceColor => "#338745"; //Green
    public bool IsDark => false;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#004016";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#007E33";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#163D2C";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#4F7561";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#003E34";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#33786A";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#740006";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#CF2C27";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#F2FCEE";
    public string SurfaceVariant => "#D9E6D5";
    public string OnSurface => "#0B130B";
    public string OnSurfaceVariant => "#2D392D";
    public string SurfaceDim => "#BFC9BC";
    public string SurfaceBright => "#F2FCEE";
    public string SurfaceTint => "#006E2B";
    // Background
    public string Background => "#F2FCEE";
    public string OnBackground => "#151E15";
    // Outline
    public string Outline => "#495648";
    public string OutlineVariant => "#647062";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#2A3329";
    public string InverseOnSurface => "#E9F4E5";
    public string InversePrimary => "#00E563";
    // Primary Fixed
    public string PrimaryFixed => "#007E33";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#006326";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#4F7561";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#365C49";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#33786A";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#145F52";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#ECF7E8";
    public string SurfaceContainer => "#E1EBDD";
    public string SurfaceContainerHigh => "#D6E0D2";
    public string SurfaceContainerHighest => "#CAD5C7";
}
