namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class DarkMode_MediumContrast_Spec2026_Watch_Yellow : ITestTheme
{
    public string SourceColor => "#B2B037"; //Yellow
    public bool IsDark => true;
    public Variant Variant => Variant.Vibrant;
    public Platform Platform => Platform.Watch;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#FFFEFF";
    public string OnPrimary => "#302F00";
    public string PrimaryContainer => "#8B8A17";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#FFFEFF";
    public string OnSecondary => "#232000";
    public string SecondaryContainer => "#8E883A";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#FEFFFB";
    public string OnTertiary => "#002A17";
    public string TertiaryContainer => "#7CE0A6";
    public string OnTertiaryContainer => "#004327";
    // Error
    public string Error => "#FFBFB0";
    public string OnError => "#390600";
    public string ErrorContainer => "#CD6951";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#000000";
    public string SurfaceVariant => "#292700";
    public string OnSurface => "#FFFEFF";
    public string OnSurfaceVariant => "#D5D0A1";
    public string SurfaceDim => "#100F00";
    public string SurfaceBright => "#302D00";
    public string SurfaceTint => "#FFFEFF";
    // Background
    public string Background => "#000000";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#ACA77C";
    public string OutlineVariant => "#8B875E";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#FFFADF";
    public string InverseOnSurface => "#3C3917";
    public string InversePrimary => "#3B3A00";
    // Primary Fixed
    public string PrimaryFixed => "#FFFC80";
    public string OnPrimaryFixed => "#302F00";
    public string PrimaryFixedDim => "#F0EE73";
    public string OnPrimaryFixedVariant => "#4A4900";
    // Secondary Fixed
    public string SecondaryFixed => "#EDE68C";
    public string OnSecondaryFixed => "#232000";
    public string SecondaryFixedDim => "#DFD780";
    public string OnSecondaryFixedVariant => "#454100";
    // Tertiary Fixed
    public string TertiaryFixed => "#98FDC1";
    public string OnTertiaryFixed => "#002A17";
    public string TertiaryFixedDim => "#8AEEB4";
    public string OnTertiaryFixedVariant => "#004D2E";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#292707";
    public string SurfaceContainer => "#343110";
    public string SurfaceContainerHigh => "#3F3C1A";
    public string SurfaceContainerHighest => "#292700";
}
