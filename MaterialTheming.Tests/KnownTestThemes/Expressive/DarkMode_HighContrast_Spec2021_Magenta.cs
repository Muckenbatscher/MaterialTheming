using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class DarkMode_HighContrast_Spec2021_Magenta : ITestTheme
{
    public string SourceColor => "#E85DAE"; //Magenta
    public bool IsDark => true;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#DFF3FF";
    public string OnPrimary => "#000000";
    public string PrimaryContainer => "#7DCDF2";
    public string OnPrimaryContainer => "#000D14";
    // Secondary
    public string Secondary => "#FFECE7";
    public string OnSecondary => "#000000";
    public string SecondaryContainer => "#F1B5A3";
    public string OnSecondaryContainer => "#1D0400";
    // Tertiary
    public string Tertiary => "#F7F4A5";
    public string OnTertiary => "#000000";
    public string TertiaryContainer => "#C8C67B";
    public string OnTertiaryContainer => "#0C0C00";
    // Error
    public string Error => "#FFECE9";
    public string OnError => "#000000";
    public string ErrorContainer => "#FFAEA4";
    public string OnErrorContainer => "#220001";
    // Surface
    public string Surface => "#1B1013";
    public string SurfaceVariant => "#564145";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#FFFFFF";
    public string SurfaceDim => "#1B1013";
    public string SurfaceBright => "#5B4C4F";
    public string SurfaceTint => "#81D1F6";
    // Background
    public string Background => "#1B1013";
    public string OnBackground => "#F3DDE0";
    // Outline
    public string Outline => "#FFEBEE";
    public string OutlineVariant => "#D9BBC0";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#F3DDE0";
    public string InverseOnSurface => "#000000";
    public string InversePrimary => "#004E67";
    // Primary Fixed
    public string PrimaryFixed => "#BFE9FF";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#81D1F6";
    public string OnPrimaryFixedVariant => "#00131C";
    // Secondary Fixed
    public string SecondaryFixed => "#FFDBD1";
    public string OnSecondaryFixed => "#000000";
    public string SecondaryFixedDim => "#F5B8A7";
    public string OnSecondaryFixedVariant => "#250802";
    // Tertiary Fixed
    public string TertiaryFixed => "#E9E698";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#CCCA7F";
    public string OnTertiaryFixedVariant => "#121200";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#281C1F";
    public string SurfaceContainer => "#3A2D2F";
    public string SurfaceContainerHigh => "#46383A";
    public string SurfaceContainerHighest => "#524346";
}
