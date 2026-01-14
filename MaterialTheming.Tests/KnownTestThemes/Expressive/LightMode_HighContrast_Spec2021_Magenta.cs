using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class LightMode_HighContrast_Spec2021_Magenta : ITestTheme
{
    public string SourceColor => "#E85DAE"; //Magenta
    public bool IsDark => false;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#003041";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#004F68";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#472217";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#693E31";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#2F2E00";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#4D4B0D";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#600004";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#98000A";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#FFF8F7";
    public string SurfaceVariant => "#FADBE0";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#000000";
    public string SurfaceDim => "#C8B4B7";
    public string SurfaceBright => "#FFF8F7";
    public string SurfaceTint => "#006685";
    // Background
    public string Background => "#FFF8F7";
    public string OnBackground => "#24191B";
    // Outline
    public string Outline => "#3A272B";
    public string OutlineVariant => "#594448";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#3A2D2F";
    public string InverseOnSurface => "#FFFFFF";
    public string InversePrimary => "#81D1F6";
    // Primary Fixed
    public string PrimaryFixed => "#004F68";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#00374A";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#693E31";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#4F281C";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#4D4B0D";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#353400";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFECEE";
    public string SurfaceContainer => "#F3DDE0";
    public string SurfaceContainerHigh => "#E4CFD2";
    public string SurfaceContainerHighest => "#D6C2C4";
}
