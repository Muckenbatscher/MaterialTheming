using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class LightMode_MediumContrast_Spec2021_Magenta : ITestTheme
{
    public string SourceColor => "#E85DAE"; //Magenta
    public bool IsDark => false;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#6C004A";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#CF0092";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#512A36";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#8F606C";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#5A252A";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#9C5B5F";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#740006";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#CF2C27";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#FFF8F8";
    public string SurfaceVariant => "#F7DBE6";
    public string OnSurface => "#190E13";
    public string OnSurfaceVariant => "#433139";
    public string SurfaceDim => "#D7C1C9";
    public string SurfaceBright => "#FFF8F8";
    public string SurfaceTint => "#B4007F";
    // Background
    public string Background => "#FFF8F8";
    public string OnBackground => "#24181E";
    // Outline
    public string Outline => "#614D56";
    public string OutlineVariant => "#7D6770";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#3B2C33";
    public string InverseOnSurface => "#FFECF2";
    public string InversePrimary => "#FFAFD6";
    // Primary Fixed
    public string PrimaryFixed => "#CF0092";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#A30072";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#8F606C";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#744854";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#9C5B5F";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#7F4347";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFF0F4";
    public string SurfaceContainer => "#FAE2EB";
    public string SurfaceContainerHigh => "#EED7DF";
    public string SurfaceContainerHighest => "#E2CCD4";
}
