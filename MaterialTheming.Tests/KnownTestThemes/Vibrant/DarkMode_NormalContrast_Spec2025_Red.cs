namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class DarkMode_NormalContrast_Spec2025_Red : ITestTheme
{
    public string SourceColor => "#D2463D"; //Red
    public bool IsDark => true;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#FF8E82";
    public string OnPrimary => "#650005";
    public string PrimaryContainer => "#FF766A";
    public string OnPrimaryContainer => "#4F0003";
    // Secondary
    public string Secondary => "#FD7E92";
    public string OnSecondary => "#57001B";
    public string SecondaryContainer => "#842137";
    public string OnSecondaryContainer => "#FFC0C7";
    // Tertiary
    public string Tertiary => "#D5A1FF";
    public string OnTertiary => "#4E137B";
    public string TertiaryContainer => "#CA90FA";
    public string OnTertiaryContainer => "#42006F";
    // Error
    public string Error => "#FF6E84";
    public string OnError => "#490013";
    public string ErrorContainer => "#A70138";
    public string OnErrorContainer => "#FFB2B9";
    // Surface
    public string Surface => "#240209";
    public string SurfaceVariant => "#48121D";
    public string OnSurface => "#FFDDE0";
    public string OnSurfaceVariant => "#DB9AA1";
    public string SurfaceDim => "#240209";
    public string SurfaceBright => "#521723";
    public string SurfaceTint => "#FF8E82";
    // Background
    public string Background => "#240209";
    public string OnBackground => "#FFDDE0";
    // Outline
    public string Outline => "#9F656D";
    public string OutlineVariant => "#6B3940";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#FFF8F7";
    public string InverseOnSurface => "#7A464D";
    public string InversePrimary => "#B32A25";
    // Primary Fixed
    public string PrimaryFixed => "#FF766A";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#FC5E52";
    public string OnPrimaryFixedVariant => "#600004";
    // Secondary Fixed
    public string SecondaryFixed => "#FFC2C8";
    public string OnSecondaryFixed => "#6A0B26";
    public string SecondaryFixedDim => "#FFAEB8";
    public string OnSecondaryFixedVariant => "#912B41";
    // Tertiary Fixed
    public string TertiaryFixed => "#D199FF";
    public string OnTertiaryFixed => "#280046";
    public string TertiaryFixedDim => "#C48BF4";
    public string OnTertiaryFixedVariant => "#531A80";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#2C050D";
    public string SurfaceContainer => "#360812";
    public string SurfaceContainerHigh => "#3F0D18";
    public string SurfaceContainerHighest => "#48121D";
}
