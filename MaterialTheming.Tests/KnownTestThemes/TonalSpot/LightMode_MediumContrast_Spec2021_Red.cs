using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class LightMode_MediumContrast_Spec2021_Red : ITestTheme
{
    public string SourceColor => "#D2463D"; //Red
    public bool IsDark => false;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#5E231E";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#A25851";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#4B2F2C";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#876561";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#453309";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#816A3B";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#740006";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#CF2C27";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#FFF8F7";
    public string SurfaceVariant => "#F5DDDA";
    public string OnSurface => "#180F0E";
    public string OnSurfaceVariant => "#413331";
    public string SurfaceDim => "#D4C3C0";
    public string SurfaceBright => "#FFF8F7";
    public string SurfaceTint => "#904A43";
    // Background
    public string Background => "#FFF8F7";
    public string OnBackground => "#231918";
    // Outline
    public string Outline => "#5F4F4D";
    public string OutlineVariant => "#7B6967";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#392E2D";
    public string InverseOnSurface => "#FFEDEA";
    public string InversePrimary => "#FFB4AB";
    // Primary Fixed
    public string PrimaryFixed => "#A25851";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#84413A";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#876561";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#6D4D49";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#816A3B";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#675225";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFF0EE";
    public string SurfaceContainer => "#F6E4E2";
    public string SurfaceContainerHigh => "#EBD9D7";
    public string SurfaceContainerHighest => "#DFCECB";
}
