using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class DarkMode_MediumContrast_Spec2021_Magenta : ITestTheme
{
    public string SourceColor => "#E85DAE"; //Magenta
    public bool IsDark => true;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#AFE4FF";
    public string OnPrimary => "#002938";
    public string PrimaryContainer => "#479ABD";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#FFD3C6";
    public string OnSecondary => "#3F1C11";
    public string SecondaryContainer => "#BA8474";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#E3E093";
    public string OnTertiary => "#282700";
    public string TertiaryContainer => "#96944F";
    public string OnTertiaryContainer => "#000000";
    // Error
    public string Error => "#FFD2CC";
    public string OnError => "#540003";
    public string ErrorContainer => "#FF5449";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#1B1013";
    public string SurfaceVariant => "#564145";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#F4D5DA";
    public string SurfaceDim => "#1B1013";
    public string SurfaceBright => "#4F4143";
    public string SurfaceTint => "#81D1F6";
    // Background
    public string Background => "#1B1013";
    public string OnBackground => "#F3DDE0";
    // Outline
    public string Outline => "#C7ABAF";
    public string OutlineVariant => "#A48A8E";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#F3DDE0";
    public string InverseOnSurface => "#332729";
    public string InversePrimary => "#004E67";
    // Primary Fixed
    public string PrimaryFixed => "#BFE9FF";
    public string OnPrimaryFixed => "#00131C";
    public string PrimaryFixedDim => "#81D1F6";
    public string OnPrimaryFixedVariant => "#003B4F";
    // Secondary Fixed
    public string SecondaryFixed => "#FFDBD1";
    public string OnSecondaryFixed => "#250802";
    public string SecondaryFixedDim => "#F5B8A7";
    public string OnSecondaryFixedVariant => "#532C20";
    // Tertiary Fixed
    public string TertiaryFixed => "#E9E698";
    public string OnTertiaryFixed => "#121200";
    public string TertiaryFixedDim => "#CCCA7F";
    public string OnTertiaryFixedVariant => "#393800";
    // Surface Container
    public string SurfaceContainerLowest => "#0E0507";
    public string SurfaceContainerLow => "#261B1D";
    public string SurfaceContainer => "#312527";
    public string SurfaceContainerHigh => "#3C2F32";
    public string SurfaceContainerHighest => "#483A3D";
}
