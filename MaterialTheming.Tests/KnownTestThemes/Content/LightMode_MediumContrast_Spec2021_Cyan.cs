using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Content;

internal class LightMode_MediumContrast_Spec2021_Cyan : ITestTheme
{
    public string SourceColor => "#00BCD1"; //Cyan
    public bool IsDark => false;
    public Variant Variant => Variant.Content;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#003C44";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#007886";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#043C44";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#46747C";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#501C6E";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#8C57AA";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#740006";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#CF2C27";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#F4FAFC";
    public string SurfaceVariant => "#D7E5E8";
    public string OnSurface => "#0C1213";
    public string OnSurfaceVariant => "#2C383B";
    public string SurfaceDim => "#C1C8C9";
    public string SurfaceBright => "#F4FAFC";
    public string SurfaceTint => "#006875";
    // Background
    public string Background => "#F4FAFC";
    public string OnBackground => "#161D1E";
    // Outline
    public string Outline => "#485557";
    public string OutlineVariant => "#626F72";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#2B3133";
    public string InverseOnSurface => "#ECF2F3";
    public string InversePrimary => "#45D8EE";
    // Primary Fixed
    public string PrimaryFixed => "#007886";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#005E69";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#46747C";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#2C5B63";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#8C57AA";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#723E90";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#EFF5F6";
    public string SurfaceContainer => "#E3E9EB";
    public string SurfaceContainerHigh => "#D8DEDF";
    public string SurfaceContainerHighest => "#CCD3D4";
}
