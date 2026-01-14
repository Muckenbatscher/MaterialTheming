using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class LightMode_MediumContrast_Spec2021_Purple : ITestTheme
{
    public string SourceColor => "#945CCD"; //Purple
    public bool IsDark => false;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#003E3A";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#007A74";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#4F2B3A";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#8D6071";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#4D284F";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#895F89";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#740006";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#CF2C27";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#FFF7FA";
    public string SurfaceVariant => "#EFDDED";
    public string OnSurface => "#150F16";
    public string OnSurfaceVariant => "#3E323F";
    public string SurfaceDim => "#CFC3CD";
    public string SurfaceBright => "#FFF7FA";
    public string SurfaceTint => "#006A64";
    // Background
    public string Background => "#FFF7FA";
    public string OnBackground => "#201920";
    // Outline
    public string Outline => "#5B4E5C";
    public string OutlineVariant => "#776977";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#362E36";
    public string InverseOnSurface => "#FAEDF7";
    public string InversePrimary => "#73D7CE";
    // Primary Fixed
    public string PrimaryFixed => "#007A74";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#005F5A";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#8D6071";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#724959";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#895F89";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#6F476F";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FDF0FA";
    public string SurfaceContainer => "#F2E4EE";
    public string SurfaceContainerHigh => "#E6D9E3";
    public string SurfaceContainerHighest => "#DBCED8";
}
