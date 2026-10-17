namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class DarkMode_NormalContrast_Spec2025_Watch_Magenta : ITestTheme
{
    public string SourceColor => "#E85DAE"; //Magenta
    public bool IsDark => true;
    public Variant Variant => Variant.Neutral;
    public Platform Platform => Platform.Watch;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#F7DBE6";
    public string OnPrimary => "#4C3A42";
    public string PrimaryContainer => "#54424A";
    public string OnPrimaryContainer => "#F4D9E3";
    // Secondary
    public string Secondary => "#EEDFE3";
    public string OnSecondary => "#463D40";
    public string SecondaryContainer => "#4E4448";
    public string OnSecondaryContainer => "#EBDCE1";
    // Tertiary
    public string Tertiary => "#FFBFC1";
    public string OnTertiary => "#561D23";
    public string TertiaryContainer => "#EF999E";
    public string OnTertiaryContainer => "#481219";
    // Error
    public string Error => "#FFBDC3";
    public string OnError => "#3C0311";
    public string ErrorContainer => "#76303A";
    public string OnErrorContainer => "#FFD6D9";
    // Surface
    public string Surface => "#000000";
    public string SurfaceVariant => "#322129";
    public string OnSurface => "#F3E4E9";
    public string OnSurfaceVariant => "#D9CACF";
    public string SurfaceDim => "#130C0F";
    public string SurfaceBright => "#3B2630";
    public string SurfaceTint => "#F7DBE6";
    // Background
    public string Background => "#000000";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#AFA2A7";
    public string OutlineVariant => "#8E8387";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#FFF8F8";
    public string InverseOnSurface => "#5D5256";
    public string InversePrimary => "#635058";
    // Primary Fixed
    public string PrimaryFixed => "#F7DBE6";
    public string OnPrimaryFixed => "#4C3A42";
    public string PrimaryFixedDim => "#E8CDD8";
    public string OnPrimaryFixedVariant => "#54424A";
    // Secondary Fixed
    public string SecondaryFixed => "#EEDFE3";
    public string OnSecondaryFixed => "#463D40";
    public string SecondaryFixedDim => "#DFD1D5";
    public string OnSecondaryFixedVariant => "#4E4448";
    // Tertiary Fixed
    public string TertiaryFixed => "#FFBFC1";
    public string OnTertiaryFixed => "#561D23";
    public string TertiaryFixedDim => "#FFA6AB";
    public string OnTertiaryFixedVariant => "#723338";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#2C2427";
    public string SurfaceContainer => "#372E32";
    public string SurfaceContainerHigh => "#42393D";
    public string SurfaceContainerHighest => "#322129";
}
