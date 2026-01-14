using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class DarkMode_HighContrast_Spec2025_Purple : ITestTheme
{
    public string SourceColor => "#945CCD"; //Purple
    public bool IsDark => true;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#ECE2EE";
    public string OnPrimary => "#2F2A32";
    public string PrimaryContainer => "#A9A1AB";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#EAE4E8";
    public string OnSecondary => "#2E2B2F";
    public string SecondaryContainer => "#A7A2A7";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#EFE7FF";
    public string OnTertiary => "#312C45";
    public string TertiaryContainer => "#E1D8FA";
    public string OnTertiaryContainer => "#27233B";
    // Error
    public string Error => "#FFDDDF";
    public string OnError => "#5B0A1E";
    public string ErrorContainer => "#F38190";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#0F0E0F";
    public string SurfaceVariant => "#272528";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#EAE4E7";
    public string SurfaceDim => "#0F0E0F";
    public string SurfaceBright => "#2E2B2E";
    public string SurfaceTint => "#ECE2EE";
    // Background
    public string Background => "#0F0E0F";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#BCB7BB";
    public string OutlineVariant => "#A7A2A5";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#FDF8F9";
    public string InverseOnSurface => "#000000";
    public string InversePrimary => "#3B363F";
    // Primary Fixed
    public string PrimaryFixed => "#E9DFEB";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#DBD1DC";
    public string OnPrimaryFixedVariant => "#221E26";
    // Secondary Fixed
    public string SecondaryFixed => "#E7E1E5";
    public string OnSecondaryFixed => "#000000";
    public string SecondaryFixedDim => "#D9D3D7";
    public string OnSecondaryFixedVariant => "#211F22";
    // Tertiary Fixed
    public string TertiaryFixed => "#E1D8FA";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#D3CAEB";
    public string OnTertiaryFixedVariant => "#1C172F";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#141314";
    public string SurfaceContainer => "#1B191B";
    public string SurfaceContainerHigh => "#211F21";
    public string SurfaceContainerHighest => "#272528";
}
