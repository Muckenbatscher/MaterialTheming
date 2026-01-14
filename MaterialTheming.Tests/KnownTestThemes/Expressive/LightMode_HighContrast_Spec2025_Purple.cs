using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class LightMode_HighContrast_Spec2025_Purple : ITestTheme
{
    public string SourceColor => "#945CCD"; //Purple
    public bool IsDark => false;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#36085E";
    public string OnPrimary => "#EAD0FF";
    public string PrimaryContainer => "#673F90";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#112910";
    public string OnSecondary => "#C4E3BC";
    public string SecondaryContainer => "#3F593B";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#062B00";
    public string OnTertiary => "#ACEB92";
    public string TertiaryContainer => "#285E16";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#500016";
    public string OnError => "#FFCED2";
    public string ErrorContainer => "#9A243D";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#FFF7FE";
    public string SurfaceVariant => "#F0DBFF";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#2E1B41";
    public string SurfaceDim => "#EAD0FF";
    public string SurfaceBright => "#FFF7FE";
    public string SurfaceTint => "#36085E";
    // Background
    public string Background => "#FFF7FE";
    public string OnBackground => "#000000";
    // Outline
    public string Outline => "#4E3A62";
    public string OutlineVariant => "#5E4973";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#130A1E";
    public string InverseOnSurface => "#FFFFFF";
    public string InversePrimary => "#DBB6FF";
    // Primary Fixed
    public string PrimaryFixed => "#673F90";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#5B3383";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#3F593B";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#334D30";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#285E16";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#1B510A";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FBF0FF";
    public string SurfaceContainer => "#F7E9FF";
    public string SurfaceContainerHigh => "#F4E2FF";
    public string SurfaceContainerHighest => "#F0DBFF";
}
