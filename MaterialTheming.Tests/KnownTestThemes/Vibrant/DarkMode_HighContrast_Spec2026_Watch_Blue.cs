namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class DarkMode_HighContrast_Spec2026_Watch_Blue : ITestTheme
{
    public string SourceColor => "#185FAA"; //Blue
    public bool IsDark => true;
    public Variant Variant => Variant.Vibrant;
    public Platform Platform => Platform.Watch;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#FFFFFF";
    public string OnPrimary => "#000000";
    public string PrimaryContainer => "#73A7F3";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#FFFFFF";
    public string OnSecondary => "#000000";
    public string SecondaryContainer => "#90A4DE";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#FFFFFF";
    public string OnTertiary => "#000000";
    public string TertiaryContainer => "#DC9CEE";
    public string OnTertiaryContainer => "#000000";
    // Error
    public string Error => "#FFBEB9";
    public string OnError => "#000000";
    public string ErrorContainer => "#F58680";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#000000";
    public string SurfaceVariant => "#082355";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#FFFEFF";
    public string SurfaceDim => "#000C2B";
    public string SurfaceBright => "#0D295F";
    public string SurfaceTint => "#FFFFFF";
    // Background
    public string Background => "#000000";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#BFCDFA";
    public string OutlineVariant => "#97A5CF";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#FAF8FF";
    public string InverseOnSurface => "#000000";
    public string InversePrimary => "#000000";
    // Primary Fixed
    public string PrimaryFixed => "#B4D0FF";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#7EB2FF";
    public string OnPrimaryFixedVariant => "#000000";
    // Secondary Fixed
    public string SecondaryFixed => "#BDCEFF";
    public string OnSecondaryFixed => "#000000";
    public string SecondaryFixedDim => "#ABC0FB";
    public string OnSecondaryFixedVariant => "#00071F";
    // Tertiary Fixed
    public string TertiaryFixed => "#F1BCFF";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#EAAAFD";
    public string OnTertiaryFixedVariant => "#14001E";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#152448";
    public string SurfaceContainer => "#212F53";
    public string SurfaceContainerHigh => "#2C3A5F";
    public string SurfaceContainerHighest => "#082355";
}
