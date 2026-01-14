using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class DarkMode_NormalContrast_Spec2025_Yellow : ITestTheme
{
    public string SourceColor => "#B2B037"; //Yellow
    public bool IsDark => true;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#FFFCC6";
    public string OnPrimary => "#636218";
    public string PrimaryContainer => "#F2EF96";
    public string OnPrimaryContainer => "#5B590F";
    // Secondary
    public string Secondary => "#BEC6DC";
    public string OnSecondary => "#384052";
    public string SecondaryContainer => "#1E2636";
    public string OnSecondaryContainer => "#9CA4B9";
    // Tertiary
    public string Tertiary => "#B2C5FF";
    public string OnTertiary => "#143C88";
    public string TertiaryContainer => "#9DB7FF";
    public string OnTertiaryContainer => "#01327E";
    // Error
    public string Error => "#FE7453";
    public string OnError => "#450900";
    public string ErrorContainer => "#881F05";
    public string OnErrorContainer => "#FF9B82";
    // Surface
    public string Surface => "#0F0E07";
    public string SurfaceVariant => "#272712";
    public string OnSurface => "#EAE7BD";
    public string OnSurfaceVariant => "#AFAD86";
    public string SurfaceDim => "#0F0E07";
    public string SurfaceBright => "#2E2D14";
    public string SurfaceTint => "#FFFCC6";
    // Background
    public string Background => "#0F0E07";
    public string OnBackground => "#EAE7BD";
    // Outline
    public string Outline => "#797754";
    public string OutlineVariant => "#4A492A";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#FDF9EC";
    public string InverseOnSurface => "#57554B";
    public string InversePrimary => "#636218";
    // Primary Fixed
    public string PrimaryFixed => "#E9E78E";
    public string OnPrimaryFixed => "#424100";
    public string PrimaryFixedDim => "#DBD982";
    public string OnPrimaryFixedVariant => "#5F5E14";
    // Secondary Fixed
    public string SecondaryFixed => "#E0E8FF";
    public string OnSecondaryFixed => "#3B4355";
    public string SecondaryFixedDim => "#D2DAF0";
    public string OnSecondaryFixedVariant => "#575F72";
    // Tertiary Fixed
    public string TertiaryFixed => "#9DB7FF";
    public string OnTertiaryFixed => "#001D51";
    public string TertiaryFixedDim => "#89A9FC";
    public string OnTertiaryFixedVariant => "#133B88";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#14140A";
    public string SurfaceContainer => "#1B1A0D";
    public string SurfaceContainerHigh => "#212010";
    public string SurfaceContainerHighest => "#272712";
}
