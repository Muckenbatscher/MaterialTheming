using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class LightMode_MediumContrast_Spec2021_Green : ITestTheme
{
    public string SourceColor => "#338745"; //Green
    public bool IsDark => false;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#2D392D";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#647062";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#313830";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#686F66";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#2A3A2A";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#60725F";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#740006";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#CF2C27";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#FBF9F6";
    public string SurfaceVariant => "#E4E2DF";
    public string OnSurface => "#101110";
    public string OnSurfaceVariant => "#363634";
    public string SurfaceDim => "#C7C6C3";
    public string SurfaceBright => "#FBF9F6";
    public string SurfaceTint => "#556254";
    // Background
    public string Background => "#FBF9F6";
    public string OnBackground => "#1B1C1A";
    // Outline
    public string Outline => "#525350";
    public string OutlineVariant => "#6D6D6B";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#30312F";
    public string InverseOnSurface => "#F2F0ED";
    public string InversePrimary => "#BDCABA";
    // Primary Fixed
    public string PrimaryFixed => "#647062";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#4C584B";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#686F66";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#50574E";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#60725F";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#485947";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F5F3F0";
    public string SurfaceContainer => "#EAE8E5";
    public string SurfaceContainerHigh => "#DEDDDA";
    public string SurfaceContainerHighest => "#D3D1CE";
}
