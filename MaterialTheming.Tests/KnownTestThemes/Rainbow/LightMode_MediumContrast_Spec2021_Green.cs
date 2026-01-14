using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Rainbow;

internal class LightMode_MediumContrast_Spec2021_Green : ITestTheme
{
    public string SourceColor => "#338745"; //Green
    public bool IsDark => false;
    public Variant Variant => Variant.Rainbow;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#004016";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#2D7C3E";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#2A3A2A";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#60725F";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#083C43";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#48747B";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#740006";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#CF2C27";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#F9F9F9";
    public string SurfaceVariant => "#E2E2E2";
    public string OnSurface => "#111111";
    public string OnSurfaceVariant => "#363636";
    public string SurfaceDim => "#C6C6C6";
    public string SurfaceBright => "#F9F9F9";
    public string SurfaceTint => "#1B6C31";
    // Background
    public string Background => "#F9F9F9";
    public string OnBackground => "#1B1B1B";
    // Outline
    public string Outline => "#525252";
    public string OutlineVariant => "#6D6D6D";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#303030";
    public string InverseOnSurface => "#F1F1F1";
    public string InversePrimary => "#88D990";
    // Primary Fixed
    public string PrimaryFixed => "#2D7C3E";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#0B6228";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#60725F";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#485947";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#48747B";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#2F5B62";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F3F3F3";
    public string SurfaceContainer => "#E8E8E8";
    public string SurfaceContainerHigh => "#DDDDDD";
    public string SurfaceContainerHighest => "#D1D1D1";
}
