using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class DarkMode_MediumContrast_Spec2025_Cyan : ITestTheme
{
    public string SourceColor => "#00BCD1"; //Cyan
    public bool IsDark => true;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#D1F8FF";
    public string OnPrimary => "#005964";
    public string PrimaryContainer => "#9EEFFE";
    public string OnPrimaryContainer => "#00505A";
    // Secondary
    public string Secondary => "#CFC2DA";
    public string OnSecondary => "#3B3246";
    public string SecondaryContainer => "#7B7086";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#DEB7FF";
    public string OnTertiary => "#4B2070";
    public string TertiaryContainer => "#D5A5FE";
    public string OnTertiaryContainer => "#401465";
    // Error
    public string Error => "#FF9F99";
    public string OnError => "#60000A";
    public string ErrorContainer => "#C94947";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#001116";
    public string SurfaceVariant => "#002A34";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#99BFCC";
    public string SurfaceDim => "#001116";
    public string SurfaceBright => "#00313C";
    public string SurfaceTint => "#D1F8FF";
    // Background
    public string Background => "#001116";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#7499A6";
    public string OutlineVariant => "#567B87";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#F2FBFF";
    public string InverseOnSurface => "#293B41";
    public string InversePrimary => "#005E69";
    // Primary Fixed
    public string PrimaryFixed => "#9EEFFE";
    public string OnPrimaryFixed => "#002429";
    public string PrimaryFixedDim => "#90E1EF";
    public string OnPrimaryFixedVariant => "#00464F";
    // Secondary Fixed
    public string SecondaryFixed => "#F1E3FD";
    public string OnSecondaryFixed => "#282033";
    public string SecondaryFixedDim => "#E3D5EE";
    public string OnSecondaryFixedVariant => "#483F53";
    // Tertiary Fixed
    public string TertiaryFixed => "#D5A5FE";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#C698F0";
    public string OnTertiaryFixedVariant => "#330259";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#00161D";
    public string SurfaceContainer => "#001D25";
    public string SurfaceContainerHigh => "#00232C";
    public string SurfaceContainerHighest => "#002A34";
}
