using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class DarkMode_MediumContrast_Spec2025_Blue : ITestTheme
{
    public string SourceColor => "#185FAA"; //Blue
    public bool IsDark => true;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#B2C8ED";
    public string OnPrimary => "#213755";
    public string PrimaryContainer => "#617597";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#BDC7DC";
    public string OnSecondary => "#2D3747";
    public string SecondaryContainer => "#6B7588";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#E7DAFF";
    public string OnTertiary => "#4B4068";
    public string TertiaryContainer => "#DACAFB";
    public string OnTertiaryContainer => "#42375F";
    // Error
    public string Error => "#FF9F99";
    public string OnError => "#60000A";
    public string ErrorContainer => "#C54D4A";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#0C0E12";
    public string SurfaceVariant => "#22262D";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#B5B9C2";
    public string SurfaceDim => "#0C0E12";
    public string SurfaceBright => "#282C34";
    public string SurfaceTint => "#B2C8ED";
    // Background
    public string Background => "#0C0E12";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#90939D";
    public string OutlineVariant => "#72757E";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#F9F9FE";
    public string InverseOnSurface => "#36383C";
    public string InversePrimary => "#415676";
    // Primary Fixed
    public string PrimaryFixed => "#C3D8FE";
    public string OnPrimaryFixed => "#00152F";
    public string PrimaryFixedDim => "#B5CAEF";
    public string OnPrimaryFixedVariant => "#233957";
    // Secondary Fixed
    public string SecondaryFixed => "#D9E3F8";
    public string OnSecondaryFixed => "#16202F";
    public string SecondaryFixedDim => "#CAD5EA";
    public string OnSecondaryFixedVariant => "#364051";
    // Tertiary Fixed
    public string TertiaryFixed => "#DACAFB";
    public string OnTertiaryFixed => "#11052B";
    public string TertiaryFixedDim => "#CBBCED";
    public string OnTertiaryFixedVariant => "#392E55";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#111318";
    public string SurfaceContainer => "#171A1F";
    public string SurfaceContainerHigh => "#1C2026";
    public string SurfaceContainerHighest => "#22262D";
}
