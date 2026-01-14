using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Fidelity;

internal class LightMode_MediumContrast_Spec2021_Purple : ITestTheme
{
    public string SourceColor => "#945CCD"; //Purple
    public bool IsDark => false;
    public Variant Variant => Variant.Fidelity;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#4F0E86";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#8A52C2";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#422D57";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#7B6491";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#413500";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#806C00";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#740006";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#CF2C27";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#FFF7FE";
    public string SurfaceVariant => "#EBDEF0";
    public string OnSurface => "#131017";
    public string OnSurfaceVariant => "#3B3340";
    public string SurfaceDim => "#CCC4CE";
    public string SurfaceBright => "#FFF7FE";
    public string SurfaceTint => "#7A42B2";
    // Background
    public string Background => "#FFF7FE";
    public string OnBackground => "#1E1A21";
    // Outline
    public string Outline => "#584F5D";
    public string OutlineVariant => "#736A78";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#332F36";
    public string InverseOnSurface => "#F7EEF8";
    public string InversePrimary => "#DCB8FF";
    // Primary Fixed
    public string PrimaryFixed => "#8A52C2";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#7037A7";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#7B6491";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#624B77";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#806C00";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#645400";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FAF1FB";
    public string SurfaceContainer => "#EEE5F0";
    public string SurfaceContainerHigh => "#E3DAE4";
    public string SurfaceContainerHighest => "#D7CFD9";
}
