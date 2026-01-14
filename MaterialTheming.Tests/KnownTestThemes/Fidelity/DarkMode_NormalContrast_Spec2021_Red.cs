using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Fidelity;

internal class DarkMode_NormalContrast_Spec2021_Red : ITestTheme
{
    public string SourceColor => "#D2463D"; //Red
    public bool IsDark => true;
    public Variant Variant => Variant.Fidelity;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#FFB4AB";
    public string OnPrimary => "#690005";
    public string PrimaryContainer => "#F55F53";
    public string OnPrimaryContainer => "#150000";
    // Secondary
    public string Secondary => "#FFB4AB";
    public string OnSecondary => "#581C18";
    public string SecondaryContainer => "#78342E";
    public string OnSecondaryContainer => "#FDA095";
    // Tertiary
    public string Tertiary => "#74D5E0";
    public string OnTertiary => "#00363B";
    public string TertiaryContainer => "#369EA8";
    public string OnTertiaryContainer => "#000708";
    // Error
    public string Error => "#FFB4AB";
    public string OnError => "#690005";
    public string ErrorContainer => "#93000A";
    public string OnErrorContainer => "#FFDAD6";
    // Surface
    public string Surface => "#1D100F";
    public string SurfaceVariant => "#59413E";
    public string OnSurface => "#F6DDDA";
    public string OnSurfaceVariant => "#E1BFBB";
    public string SurfaceDim => "#1D100F";
    public string SurfaceBright => "#453533";
    public string SurfaceTint => "#FFB4AB";
    // Background
    public string Background => "#1D100F";
    public string OnBackground => "#F6DDDA";
    // Outline
    public string Outline => "#A88A86";
    public string OutlineVariant => "#59413E";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#F6DDDA";
    public string InverseOnSurface => "#3C2D2B";
    public string InversePrimary => "#B02D28";
    // Primary Fixed
    public string PrimaryFixed => "#FFDAD6";
    public string OnPrimaryFixed => "#410002";
    public string PrimaryFixedDim => "#FFB4AB";
    public string OnPrimaryFixedVariant => "#8E1313";
    // Secondary Fixed
    public string SecondaryFixed => "#FFDAD6";
    public string OnSecondaryFixed => "#3C0706";
    public string SecondaryFixedDim => "#FFB4AB";
    public string OnSecondaryFixedVariant => "#75322C";
    // Tertiary Fixed
    public string TertiaryFixed => "#91F2FC";
    public string OnTertiaryFixed => "#002023";
    public string TertiaryFixedDim => "#74D5E0";
    public string OnTertiaryFixedVariant => "#004F55";
    // Surface Container
    public string SurfaceContainerLowest => "#170B0A";
    public string SurfaceContainerLow => "#261817";
    public string SurfaceContainer => "#2A1C1B";
    public string SurfaceContainerHigh => "#352625";
    public string SurfaceContainerHighest => "#41312F";
}
