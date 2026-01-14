using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class DarkMode_HighContrast_Spec2025_Cyan : ITestTheme
{
    public string SourceColor => "#00BCD1"; //Cyan
    public bool IsDark => true;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#A7F1FF";
    public string OnPrimary => "#003138";
    public string PrimaryContainer => "#00E3FC";
    public string OnPrimaryContainer => "#001E23";
    // Secondary
    public string Secondary => "#BBEDFF";
    public string OnSecondary => "#00313C";
    public string SecondaryContainer => "#00B2D6";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#DAE6FF";
    public string OnTertiary => "#002C58";
    public string TertiaryContainer => "#65A5FF";
    public string OnTertiaryContainer => "#000000";
    // Error
    public string Error => "#FFDEDB";
    public string OnError => "#60000A";
    public string ErrorContainer => "#FF7C76";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#001016";
    public string SurfaceVariant => "#002A34";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#BBEDFF";
    public string SurfaceDim => "#001016";
    public string SurfaceBright => "#00313C";
    public string SurfaceTint => "#A7F1FF";
    // Background
    public string Background => "#001016";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#8DC1D2";
    public string OutlineVariant => "#78ABBC";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#F2FBFF";
    public string InverseOnSurface => "#000000";
    public string InversePrimary => "#003F47";
    // Primary Fixed
    public string PrimaryFixed => "#00E3FC";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#00D4EC";
    public string OnPrimaryFixedVariant => "#000A0D";
    // Secondary Fixed
    public string SecondaryFixed => "#76DFFF";
    public string OnSecondaryFixed => "#000000";
    public string SecondaryFixedDim => "#00D5FF";
    public string OnSecondaryFixedVariant => "#000F15";
    // Tertiary Fixed
    public string TertiaryFixed => "#7FB2FF";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#64A4FF";
    public string OnTertiaryFixedVariant => "#000000";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#00161D";
    public string SurfaceContainer => "#001D25";
    public string SurfaceContainerHigh => "#00232C";
    public string SurfaceContainerHighest => "#002A34";
}
