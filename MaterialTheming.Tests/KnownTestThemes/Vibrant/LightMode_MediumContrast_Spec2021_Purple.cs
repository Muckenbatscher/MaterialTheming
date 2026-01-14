using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class LightMode_MediumContrast_Spec2021_Purple : ITestTheme
{
    public string SourceColor => "#945CCD"; //Purple
    public bool IsDark => false;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#51008E";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#9A23FF";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#452E4B";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#7E6484";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#50284B";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#8C5E85";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#740006";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#CF2C27";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#FFF7FE";
    public string SurfaceVariant => "#EBDEF0";
    public string OnSurface => "#140F19";
    public string OnSurfaceVariant => "#3B3341";
    public string SurfaceDim => "#CDC3D1";
    public string SurfaceBright => "#FFF7FE";
    public string SurfaceTint => "#8900EA";
    // Background
    public string Background => "#FFF7FE";
    public string OnBackground => "#1F1923";
    // Outline
    public string Outline => "#584F5E";
    public string OutlineVariant => "#736A79";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#342E39";
    public string InverseOnSurface => "#F8EDFC";
    public string InversePrimary => "#DCB8FF";
    // Primary Fixed
    public string PrimaryFixed => "#9A23FF";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#7B00D4";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#7E6484";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#654C6B";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#8C5E85";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#72466C";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FBF0FF";
    public string SurfaceContainer => "#F0E5F3";
    public string SurfaceContainerHigh => "#E4D9E8";
    public string SurfaceContainerHighest => "#D9CEDC";
}
