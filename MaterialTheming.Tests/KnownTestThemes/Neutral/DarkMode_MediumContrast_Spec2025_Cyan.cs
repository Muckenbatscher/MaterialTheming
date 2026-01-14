using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class DarkMode_MediumContrast_Spec2025_Cyan : ITestTheme
{
    public string SourceColor => "#00BCD1"; //Cyan
    public bool IsDark => true;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#BFC8CA";
    public string OnPrimary => "#2F3839";
    public string PrimaryContainer => "#6D7678";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#B6B9BA";
    public string OnSecondary => "#292D2D";
    public string SecondaryContainer => "#727576";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#EFF8FF";
    public string OnTertiary => "#3D5766";
    public string TertiaryContainer => "#D0ECFF";
    public string OnTertiaryContainer => "#354E5E";
    // Error
    public string Error => "#FF9F99";
    public string OnError => "#5B0D10";
    public string ErrorContainer => "#BB5551";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#0E0E0E";
    public string SurfaceVariant => "#242627";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#B8B9B9";
    public string SurfaceDim => "#0E0E0E";
    public string SurfaceBright => "#2A2D2D";
    public string SurfaceTint => "#BFC8CA";
    // Background
    public string Background => "#0E0E0E";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#929494";
    public string OutlineVariant => "#747676";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#FBF9F8";
    public string InverseOnSurface => "#383838";
    public string InversePrimary => "#4D5758";
    // Primary Fixed
    public string PrimaryFixed => "#DBE4E6";
    public string OnPrimaryFixed => "#182123";
    public string PrimaryFixedDim => "#CDD6D8";
    public string OnPrimaryFixedVariant => "#384143";
    // Secondary Fixed
    public string SecondaryFixed => "#E1E3E3";
    public string OnSecondaryFixed => "#1D2021";
    public string SecondaryFixedDim => "#D2D5D5";
    public string OnSecondaryFixedVariant => "#3C4041";
    // Tertiary Fixed
    public string TertiaryFixed => "#D0ECFF";
    public string OnTertiaryFixed => "#0A2735";
    public string TertiaryFixedDim => "#C2DEF0";
    public string OnTertiaryFixedVariant => "#2C4655";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#121414";
    public string SurfaceContainer => "#181A1A";
    public string SurfaceContainerHigh => "#1E2020";
    public string SurfaceContainerHighest => "#242627";
}
