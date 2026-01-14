using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.FruitSalad;

internal class LightMode_HighContrast_Spec2021_Magenta : ITestTheme
{
    public string SourceColor => "#E85DAE"; //Magenta
    public bool IsDark => false;
    public Variant Variant => Variant.FruitSalad;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#34186D";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#52398C";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#322258";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#504078";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#4D1937";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#6F3655";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#600004";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#98000A";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#FFF8F8";
    public string SurfaceVariant => "#FDD9E8";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#000000";
    public string SurfaceDim => "#C9B3BB";
    public string SurfaceBright => "#FFF8F8";
    public string SurfaceTint => "#684FA4";
    // Background
    public string Background => "#FFF8F8";
    public string OnBackground => "#24181E";
    // Outline
    public string Outline => "#3C2630";
    public string OutlineVariant => "#5B424E";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#3B2C33";
    public string InverseOnSurface => "#FFFFFF";
    public string InversePrimary => "#D0BCFF";
    // Primary Fixed
    public string PrimaryFixed => "#52398C";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#3B2074";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#504078";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#39295F";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#6F3655";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#541F3E";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFECF2";
    public string SurfaceContainer => "#F4DDE5";
    public string SurfaceContainerHigh => "#E5CFD7";
    public string SurfaceContainerHighest => "#D7C1C9";
}
