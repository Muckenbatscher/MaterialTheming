using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.FruitSalad;

internal class LightMode_MediumContrast_Spec2021_Purple : ITestTheme
{
    public string SourceColor => "#945CCD"; //Purple
    public bool IsDark => false;
    public Variant Variant => Variant.FruitSalad;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#00366A";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#356EB6";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#0D3665";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#4D6EA0";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#442A5F";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#7E619A";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#740006";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#CF2C27";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#FFF7FE";
    public string SurfaceVariant => "#EDDDF6";
    public string OnSurface => "#140F19";
    public string OnSurfaceVariant => "#3C3245";
    public string SurfaceDim => "#CDC3D1";
    public string SurfaceBright => "#FFF7FE";
    public string SurfaceTint => "#215FA6";
    // Background
    public string Background => "#FFF7FE";
    public string OnBackground => "#1F1923";
    // Outline
    public string Outline => "#594E63";
    public string OutlineVariant => "#75697E";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#342E39";
    public string InverseOnSurface => "#F8EDFC";
    public string InversePrimary => "#A6C8FF";
    // Primary Fixed
    public string PrimaryFixed => "#356EB6";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#10559C";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#4D6EA0";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#335686";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#7E619A";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#644980";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FBF0FF";
    public string SurfaceContainer => "#F0E5F3";
    public string SurfaceContainerHigh => "#E4D9E8";
    public string SurfaceContainerHighest => "#D9CEDC";
}
