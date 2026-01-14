using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Monochrome;

internal class DarkMode_HighContrast_Spec2021_Green : ITestTheme
{
    public string SourceColor => "#338745"; //Green
    public bool IsDark => true;
    public Variant Variant => Variant.Monochrome;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#FFFFFF";
    public string OnPrimary => "#000000";
    public string PrimaryContainer => "#D4D4D4";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#F0F0F0";
    public string OnSecondary => "#000000";
    public string SecondaryContainer => "#C2C2C2";
    public string OnSecondaryContainer => "#0B0B0B";
    // Tertiary
    public string Tertiary => "#F0F0F0";
    public string OnTertiary => "#000000";
    public string TertiaryContainer => "#C2C2C2";
    public string OnTertiaryContainer => "#000000";
    // Error
    public string Error => "#FFECE9";
    public string OnError => "#000000";
    public string ErrorContainer => "#FFAEA4";
    public string OnErrorContainer => "#220001";
    // Surface
    public string Surface => "#131313";
    public string SurfaceVariant => "#474747";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#FFFFFF";
    public string SurfaceDim => "#131313";
    public string SurfaceBright => "#505050";
    public string SurfaceTint => "#C6C6C6";
    // Background
    public string Background => "#131313";
    public string OnBackground => "#E2E2E2";
    // Outline
    public string Outline => "#F0F0F0";
    public string OutlineVariant => "#C2C2C2";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#E2E2E2";
    public string InverseOnSurface => "#000000";
    public string InversePrimary => "#484848";
    // Primary Fixed
    public string PrimaryFixed => "#DEDEDE";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#C2C2C2";
    public string OnPrimaryFixedVariant => "#0B0B0B";
    // Secondary Fixed
    public string SecondaryFixed => "#DEDEDE";
    public string OnSecondaryFixed => "#000000";
    public string SecondaryFixedDim => "#C2C2C2";
    public string OnSecondaryFixedVariant => "#0B0B0B";
    // Tertiary Fixed
    public string TertiaryFixed => "#DEDEDE";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#C2C2C2";
    public string OnTertiaryFixedVariant => "#0B0B0B";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#1F1F1F";
    public string SurfaceContainer => "#303030";
    public string SurfaceContainerHigh => "#3B3B3B";
    public string SurfaceContainerHighest => "#474747";
}
