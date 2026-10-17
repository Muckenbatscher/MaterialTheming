namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class DarkMode_MediumContrast_Spec2025_Watch_Magenta : ITestTheme
{
    public string SourceColor => "#E85DAE"; //Magenta
    public bool IsDark => true;
    public Variant Variant => Variant.Neutral;
    public Platform Platform => Platform.Watch;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#FFFEFF";
    public string OnPrimary => "#2A1B22";
    public string PrimaryContainer => "#968089";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#FFFEFF";
    public string OnSecondary => "#251D21";
    public string SecondaryContainer => "#8E8387";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#FFFEFF";
    public string OnTertiary => "#0E0001";
    public string TertiaryContainer => "#EF999E";
    public string OnTertiaryContainer => "#481219";
    // Error
    public string Error => "#FFBDC3";
    public string OnError => "#3B0310";
    public string ErrorContainer => "#C26C77";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#000000";
    public string SurfaceVariant => "#322129";
    public string OnSurface => "#FFFEFF";
    public string OnSurfaceVariant => "#D9CACF";
    public string SurfaceDim => "#130C0F";
    public string SurfaceBright => "#3B2630";
    public string SurfaceTint => "#FFFEFF";
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
    public string InverseOnSurface => "#3F3639";
    public string InversePrimary => "#45333B";
    // Primary Fixed
    public string PrimaryFixed => "#F7DBE6";
    public string OnPrimaryFixed => "#2A1B22";
    public string PrimaryFixedDim => "#E8CDD8";
    public string OnPrimaryFixedVariant => "#4C3A42";
    // Secondary Fixed
    public string SecondaryFixed => "#EEDFE3";
    public string OnSecondaryFixed => "#251D21";
    public string SecondaryFixedDim => "#DFD1D5";
    public string OnSecondaryFixedVariant => "#463D40";
    // Tertiary Fixed
    public string TertiaryFixed => "#FFBFC1";
    public string OnTertiaryFixed => "#0E0001";
    public string TertiaryFixedDim => "#FFA6AB";
    public string OnTertiaryFixedVariant => "#561D23";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#2C2427";
    public string SurfaceContainer => "#372E32";
    public string SurfaceContainerHigh => "#42393D";
    public string SurfaceContainerHighest => "#322129";
}
