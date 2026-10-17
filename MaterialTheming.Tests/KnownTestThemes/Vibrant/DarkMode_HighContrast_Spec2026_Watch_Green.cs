namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class DarkMode_HighContrast_Spec2026_Watch_Green : ITestTheme
{
    public string SourceColor => "#338745"; //Green
    public bool IsDark => true;
    public Variant Variant => Variant.Vibrant;
    public Platform Platform => Platform.Watch;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#FFFFFF";
    public string OnPrimary => "#000000";
    public string PrimaryContainer => "#68B772";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#FFFFFF";
    public string OnSecondary => "#000000";
    public string SecondaryContainer => "#7DB280";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#FFFFFF";
    public string OnTertiary => "#000000";
    public string TertiaryContainer => "#49D6E2";
    public string OnTertiaryContainer => "#001012";
    // Error
    public string Error => "#FFBFB0";
    public string OnError => "#000000";
    public string ErrorContainer => "#F4886D";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#000000";
    public string SurfaceVariant => "#0C2C13";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#FFFFFA";
    public string SurfaceDim => "#001203";
    public string SurfaceBright => "#113317";
    public string SurfaceTint => "#FFFFFF";
    // Background
    public string Background => "#000000";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#BBD5B8";
    public string OutlineVariant => "#93AC91";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#EBFFE7";
    public string InverseOnSurface => "#000000";
    public string InversePrimary => "#000000";
    // Primary Fixed
    public string PrimaryFixed => "#ACFEB2";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#9EF0A5";
    public string OnPrimaryFixedVariant => "#002D0D";
    // Secondary Fixed
    public string SecondaryFixed => "#B8F1B9";
    public string OnSecondaryFixed => "#000000";
    public string SecondaryFixedDim => "#AAE2AC";
    public string OnSecondaryFixedVariant => "#00260A";
    // Tertiary Fixed
    public string TertiaryFixed => "#6CF2FF";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#5BE4F0";
    public string OnTertiaryFixedVariant => "#002124";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#152A17";
    public string SurfaceContainer => "#1F3521";
    public string SurfaceContainerHigh => "#2A412C";
    public string SurfaceContainerHighest => "#0C2C13";
}
