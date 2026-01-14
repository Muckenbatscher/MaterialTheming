using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class LightMode_MediumContrast_Spec2021_Red : ITestTheme
{
    public string SourceColor => "#D2463D"; //Red
    public bool IsDark => false;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#46312E";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#816764";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#413331";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#7B6967";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#4B2F2C";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#876561";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#740006";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#CF2C27";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#FFF8F7";
    public string SurfaceVariant => "#E9E1DF";
    public string OnSurface => "#131010";
    public string OnSurfaceVariant => "#393535";
    public string SurfaceDim => "#CCC5C4";
    public string SurfaceBright => "#FFF8F7";
    public string SurfaceTint => "#715855";
    // Background
    public string Background => "#FFF8F7";
    public string OnBackground => "#1E1B1A";
    // Outline
    public string Outline => "#565151";
    public string OutlineVariant => "#716C6B";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#332F2F";
    public string InverseOnSurface => "#F7EFEE";
    public string InversePrimary => "#DFBFBB";
    // Primary Fixed
    public string PrimaryFixed => "#816764";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#674F4C";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#7B6967";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#61514F";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#876561";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#6D4D49";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FAF2F0";
    public string SurfaceContainer => "#EFE6E5";
    public string SurfaceContainerHigh => "#E3DBDA";
    public string SurfaceContainerHighest => "#D8D0CF";
}
