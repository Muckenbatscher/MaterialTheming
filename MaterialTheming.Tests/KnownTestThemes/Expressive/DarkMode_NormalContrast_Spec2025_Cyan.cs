namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class DarkMode_NormalContrast_Spec2025_Cyan : ITestTheme
{
    public string SourceColor => "#00BCD1"; //Cyan
    public bool IsDark => true;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#9EEFFE";
    public string OnPrimary => "#005B65";
    public string PrimaryContainer => "#006E7B";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#CFC2DA";
    public string OnSecondary => "#453C50";
    public string SecondaryContainer => "#2A2235";
    public string OnSecondaryContainer => "#AB9FB7";
    // Tertiary
    public string Tertiary => "#DEB7FF";
    public string OnTertiary => "#552B7B";
    public string TertiaryContainer => "#D5A5FE";
    public string OnTertiaryContainer => "#4B2171";
    // Error
    public string Error => "#FF716C";
    public string OnError => "#490006";
    public string ErrorContainer => "#8A1A1E";
    public string OnErrorContainer => "#FF9993";
    // Surface
    public string Surface => "#001116";
    public string SurfaceVariant => "#002A34";
    public string OnSurface => "#C5ECFA";
    public string OnSurfaceVariant => "#8CB1BE";
    public string SurfaceDim => "#001116";
    public string SurfaceBright => "#00313C";
    public string SurfaceTint => "#9EEFFE";
    // Background
    public string Background => "#001116";
    public string OnBackground => "#C5ECFA";
    // Outline
    public string Outline => "#567B87";
    public string OutlineVariant => "#284D58";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#F2FBFF";
    public string InverseOnSurface => "#45585F";
    public string InversePrimary => "#006975";
    // Primary Fixed
    public string PrimaryFixed => "#9EEFFE";
    public string OnPrimaryFixed => "#00464F";
    public string PrimaryFixedDim => "#90E1EF";
    public string OnPrimaryFixedVariant => "#006571";
    // Secondary Fixed
    public string SecondaryFixed => "#F1E3FD";
    public string OnSecondaryFixed => "#483F53";
    public string SecondaryFixedDim => "#E3D5EE";
    public string OnSecondaryFixedVariant => "#655B70";
    // Tertiary Fixed
    public string TertiaryFixed => "#D5A5FE";
    public string OnTertiaryFixed => "#330259";
    public string TertiaryFixedDim => "#C698F0";
    public string OnTertiaryFixedVariant => "#542B7A";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#00161D";
    public string SurfaceContainer => "#001D25";
    public string SurfaceContainerHigh => "#00232C";
    public string SurfaceContainerHighest => "#002A34";
}
