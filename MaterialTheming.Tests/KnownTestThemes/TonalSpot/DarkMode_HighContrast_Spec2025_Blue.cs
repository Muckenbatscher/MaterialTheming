using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class DarkMode_HighContrast_Spec2025_Blue : ITestTheme
{
    public string SourceColor => "#185FAA"; //Blue
    public bool IsDark => true;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#D9E6FF";
    public string OnPrimary => "#162D4A";
    public string PrimaryContainer => "#90A5C8";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#DCE6FB";
    public string OnSecondary => "#222C3C";
    public string SecondaryContainer => "#9AA4B8";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#ECE0FF";
    public string OnTertiary => "#31254C";
    public string TertiaryContainer => "#DACAFB";
    public string OnTertiaryContainer => "#21163C";
    // Error
    public string Error => "#FFDEDB";
    public string OnError => "#60000A";
    public string ErrorContainer => "#FF7C76";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#0C0E12";
    public string SurfaceVariant => "#22262D";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#E2E5EF";
    public string SurfaceDim => "#0C0E12";
    public string SurfaceBright => "#282C34";
    public string SurfaceTint => "#D9E6FF";
    // Background
    public string Background => "#0C0E12";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#B5B9C2";
    public string OutlineVariant => "#A0A4AD";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#F9F9FE";
    public string InverseOnSurface => "#000000";
    public string InversePrimary => "#243957";
    // Primary Fixed
    public string PrimaryFixed => "#C3D8FE";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#B5CAEF";
    public string OnPrimaryFixedVariant => "#00152F";
    // Secondary Fixed
    public string SecondaryFixed => "#D9E3F8";
    public string OnSecondaryFixed => "#000000";
    public string SecondaryFixedDim => "#CAD5EA";
    public string OnSecondaryFixedVariant => "#16202F";
    // Tertiary Fixed
    public string TertiaryFixed => "#DACAFB";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#CBBCED";
    public string OnTertiaryFixedVariant => "#11052B";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#111318";
    public string SurfaceContainer => "#171A1F";
    public string SurfaceContainerHigh => "#1C2026";
    public string SurfaceContainerHighest => "#22262D";
}
