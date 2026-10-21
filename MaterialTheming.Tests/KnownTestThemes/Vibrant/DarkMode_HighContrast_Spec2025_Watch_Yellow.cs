namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class DarkMode_HighContrast_Spec2025_Watch_Yellow : ITestTheme
{
    public string SourceColor => "#B2B037"; //Yellow
    public bool IsDark => true;
    public Variant Variant => Variant.Vibrant;
    public Platform Platform => Platform.Watch;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#FFFFFF";
    public string OnPrimary => "#000000";
    public string PrimaryContainer => "#ACAA38";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#FFFFFF";
    public string OnSecondary => "#000000";
    public string SecondaryContainer => "#AFA856";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#FFFFFF";
    public string OnTertiary => "#000000";
    public string TertiaryContainer => "#7CE0A6";
    public string OnTertiaryContainer => "#001D0E";
    // Error
    public string Error => "#FFBFB0";
    public string OnError => "#000000";
    public string ErrorContainer => "#F4886D";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#000000";
    public string SurfaceVariant => "#292700";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#FFFEFF";
    public string SurfaceDim => "#100F00";
    public string SurfaceBright => "#302D00";
    public string SurfaceTint => "#FFFFFF";
    // Background
    public string Background => "#000000";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#D5D0A1";
    public string OutlineVariant => "#ACA77C";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#FFFADF";
    public string InverseOnSurface => "#000000";
    public string InversePrimary => "#000000";
    // Primary Fixed
    public string PrimaryFixed => "#FFFC80";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#F0EE73";
    public string OnPrimaryFixedVariant => "#302F00";
    // Secondary Fixed
    public string SecondaryFixed => "#EDE68C";
    public string OnSecondaryFixed => "#000000";
    public string SecondaryFixedDim => "#DFD780";
    public string OnSecondaryFixedVariant => "#232000";
    // Tertiary Fixed
    public string TertiaryFixed => "#98FDC1";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#8AEEB4";
    public string OnTertiaryFixedVariant => "#002A17";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#292707";
    public string SurfaceContainer => "#343110";
    public string SurfaceContainerHigh => "#3F3C1A";
    public string SurfaceContainerHighest => "#292700";
}
