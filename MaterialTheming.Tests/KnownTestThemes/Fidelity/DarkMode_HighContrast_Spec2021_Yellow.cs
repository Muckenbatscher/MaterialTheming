using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Fidelity;

internal class DarkMode_HighContrast_Spec2021_Yellow : ITestTheme
{
    public string SourceColor => "#B2B037"; //Yellow
    public bool IsDark => true;
    public Variant Variant => Variant.Fidelity;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#F8F675";
    public string OnPrimary => "#000000";
    public string PrimaryContainer => "#CAC84D";
    public string OnPrimaryContainer => "#0C0C00";
    // Secondary
    public string Secondary => "#F6F3B6";
    public string OnSecondary => "#000000";
    public string SecondaryContainer => "#C8C58C";
    public string OnSecondaryContainer => "#0C0C00";
    // Tertiary
    public string Tertiary => "#F7ECFF";
    public string OnTertiary => "#000000";
    public string TertiaryContainer => "#D3B5FF";
    public string OnTertiaryContainer => "#13002F";
    // Error
    public string Error => "#FFECE9";
    public string OnError => "#000000";
    public string ErrorContainer => "#FFAEA4";
    public string OnErrorContainer => "#220001";
    // Surface
    public string Surface => "#14140C";
    public string SurfaceVariant => "#484736";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#FFFFFF";
    public string SurfaceDim => "#14140C";
    public string SurfaceBright => "#525046";
    public string SurfaceTint => "#CECC50";
    // Background
    public string Background => "#14140C";
    public string OnBackground => "#E6E3D5";
    // Outline
    public string Outline => "#F4F1D9";
    public string OutlineVariant => "#C6C3AD";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#E6E3D5";
    public string InverseOnSurface => "#000000";
    public string InversePrimary => "#4B4A00";
    // Primary Fixed
    public string PrimaryFixed => "#EAE869";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#CECC50";
    public string OnPrimaryFixedVariant => "#121200";
    // Secondary Fixed
    public string SecondaryFixed => "#E8E5AA";
    public string OnSecondaryFixed => "#000000";
    public string SecondaryFixedDim => "#CCC990";
    public string OnSecondaryFixedVariant => "#121200";
    // Tertiary Fixed
    public string TertiaryFixed => "#ECDCFF";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#D6BAFF";
    public string OnTertiaryFixedVariant => "#1A003D";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#202017";
    public string SurfaceContainer => "#323127";
    public string SurfaceContainerHigh => "#3D3C32";
    public string SurfaceContainerHighest => "#48473D";
}
