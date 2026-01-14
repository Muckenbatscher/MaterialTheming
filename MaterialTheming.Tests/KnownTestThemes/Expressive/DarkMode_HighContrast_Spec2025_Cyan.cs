using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class DarkMode_HighContrast_Spec2025_Cyan : ITestTheme
{
    public string SourceColor => "#00BCD1"; //Cyan
    public bool IsDark => true;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#D1F8FF";
    public string OnPrimary => "#003940";
    public string PrimaryContainer => "#9EEFFE";
    public string OnPrimaryContainer => "#002F35";
    // Secondary
    public string Secondary => "#EEE0FA";
    public string OnSecondary => "#31283B";
    public string SecondaryContainer => "#AB9FB7";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#F3DEFF";
    public string OnTertiary => "#401465";
    public string TertiaryContainer => "#D5A5FE";
    public string OnTertiaryContainer => "#000000";
    // Error
    public string Error => "#FFDEDB";
    public string OnError => "#60000A";
    public string ErrorContainer => "#FF7C76";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#001116";
    public string SurfaceVariant => "#002A34";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#C5ECFA";
    public string SurfaceDim => "#001116";
    public string SurfaceBright => "#00313C";
    public string SurfaceTint => "#D1F8FF";
    // Background
    public string Background => "#001116";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#99BFCC";
    public string OutlineVariant => "#84A9B7";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#F2FBFF";
    public string InverseOnSurface => "#000000";
    public string InversePrimary => "#003F47";
    // Primary Fixed
    public string PrimaryFixed => "#9EEFFE";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#90E1EF";
    public string OnPrimaryFixedVariant => "#002429";
    // Secondary Fixed
    public string SecondaryFixed => "#F1E3FD";
    public string OnSecondaryFixed => "#000000";
    public string SecondaryFixedDim => "#E3D5EE";
    public string OnSecondaryFixedVariant => "#282033";
    // Tertiary Fixed
    public string TertiaryFixed => "#D5A5FE";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#C698F0";
    public string OnTertiaryFixedVariant => "#000000";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#00161D";
    public string SurfaceContainer => "#001D25";
    public string SurfaceContainerHigh => "#00232C";
    public string SurfaceContainerHighest => "#002A34";
}
