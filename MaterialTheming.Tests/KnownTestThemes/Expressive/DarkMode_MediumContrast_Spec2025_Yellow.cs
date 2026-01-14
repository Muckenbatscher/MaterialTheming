using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class DarkMode_MediumContrast_Spec2025_Yellow : ITestTheme
{
    public string SourceColor => "#B2B037"; //Yellow
    public bool IsDark => true;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#FFFCC6";
    public string OnPrimary => "#59580D";
    public string PrimaryContainer => "#F2EF96";
    public string OnPrimaryContainer => "#504F04";
    // Secondary
    public string Secondary => "#BEC6DC";
    public string OnSecondary => "#2E3647";
    public string SecondaryContainer => "#6C7488";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#B2C5FF";
    public string OnTertiary => "#00317E";
    public string TertiaryContainer => "#9DB7FF";
    public string OnTertiaryContainer => "#002869";
    // Error
    public string Error => "#FFA089";
    public string OnError => "#5A0E00";
    public string ErrorContainer => "#C74C2F";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#0F0E07";
    public string SurfaceVariant => "#272712";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#BDBB93";
    public string SurfaceDim => "#0F0E07";
    public string SurfaceBright => "#2E2D14";
    public string SurfaceTint => "#FFFCC6";
    // Background
    public string Background => "#0F0E07";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#979570";
    public string OutlineVariant => "#797754";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#FDF9EC";
    public string InverseOnSurface => "#39382F";
    public string InversePrimary => "#59580D";
    // Primary Fixed
    public string PrimaryFixed => "#E9E78E";
    public string OnPrimaryFixed => "#212100";
    public string PrimaryFixedDim => "#DBD982";
    public string OnPrimaryFixedVariant => "#424100";
    // Secondary Fixed
    public string SecondaryFixed => "#E0E8FF";
    public string OnSecondaryFixed => "#1C2434";
    public string SecondaryFixedDim => "#D2DAF0";
    public string OnSecondaryFixedVariant => "#3B4355";
    // Tertiary Fixed
    public string TertiaryFixed => "#9DB7FF";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#89A9FC";
    public string OnTertiaryFixedVariant => "#001D51";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#14140A";
    public string SurfaceContainer => "#1B1A0D";
    public string SurfaceContainerHigh => "#212010";
    public string SurfaceContainerHighest => "#272712";
}
