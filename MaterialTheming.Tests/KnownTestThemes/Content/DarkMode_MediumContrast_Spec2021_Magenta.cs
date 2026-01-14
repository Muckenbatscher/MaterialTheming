using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Content;

internal class DarkMode_MediumContrast_Spec2021_Magenta : ITestTheme
{
    public string SourceColor => "#E85DAE"; //Magenta
    public bool IsDark => true;
    public Variant Variant => Variant.Content;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#FFCFE4";
    public string OnPrimary => "#4E0035";
    public string PrimaryContainer => "#E85DAE";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#FFCFE4";
    public string OnSecondary => "#461031";
    public string SecondaryContainer => "#C37A9F";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#FFD2C9";
    public string OnTertiary => "#510700";
    public string TertiaryContainer => "#F36145";
    public string OnTertiaryContainer => "#000000";
    // Error
    public string Error => "#FFD2CC";
    public string OnError => "#540003";
    public string ErrorContainer => "#FF5449";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#1B1015";
    public string SurfaceVariant => "#55414A";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#F1D5E0";
    public string SurfaceDim => "#1B1015";
    public string SurfaceBright => "#4E4146";
    public string SurfaceTint => "#FFAFD6";
    // Background
    public string Background => "#1B1015";
    public string OnBackground => "#F2DDE4";
    // Outline
    public string Outline => "#C5ABB5";
    public string OutlineVariant => "#A28A94";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#F2DDE4";
    public string InverseOnSurface => "#33272C";
    public string InversePrimary => "#8B0461";
    // Primary Fixed
    public string PrimaryFixed => "#FFD8E8";
    public string OnPrimaryFixed => "#2A001A";
    public string PrimaryFixedDim => "#FFAFD6";
    public string OnPrimaryFixedVariant => "#6C004A";
    // Secondary Fixed
    public string SecondaryFixed => "#FFD8E8";
    public string OnSecondaryFixed => "#2A001A";
    public string SecondaryFixedDim => "#FFAFD6";
    public string OnSecondaryFixedVariant => "#5A2142";
    // Tertiary Fixed
    public string TertiaryFixed => "#FFDAD3";
    public string OnTertiaryFixed => "#2B0200";
    public string TertiaryFixedDim => "#FFB4A5";
    public string OnTertiaryFixedVariant => "#6F0D00";
    // Surface Container
    public string SurfaceContainerLowest => "#0D0509";
    public string SurfaceContainerLow => "#261A1F";
    public string SurfaceContainer => "#30252A";
    public string SurfaceContainerHigh => "#3C2F35";
    public string SurfaceContainerHighest => "#473A40";
}
