namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class DarkMode_HighContrast_Spec2025_Watch_Blue : ITestTheme
{
    public string SourceColor => "#185FAA"; //Blue
    public bool IsDark => true;
    public Variant Variant => Variant.TonalSpot;
    public Platform Platform => Platform.Watch;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#FFFFFF";
    public string OnPrimary => "#000000";
    public string PrimaryContainer => "#8BA7D5";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#FFFFFF";
    public string OnSecondary => "#000000";
    public string SecondaryContainer => "#9CA6BA";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#FFFFFF";
    public string OnTertiary => "#000000";
    public string TertiaryContainer => "#B4ADE4";
    public string OnTertiaryContainer => "#000000";
    // Error
    public string Error => "#FFBEB9";
    public string OnError => "#000000";
    public string ErrorContainer => "#F58680";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#000000";
    public string SurfaceVariant => "#1B2637";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#FFFEFF";
    public string SurfaceDim => "#090E17";
    public string SurfaceBright => "#212D3E";
    public string SurfaceTint => "#FFFFFF";
    // Background
    public string Background => "#000000";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#C9CEDA";
    public string OutlineVariant => "#A1A6B1";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#F9F9FF";
    public string InverseOnSurface => "#000000";
    public string InversePrimary => "#000000";
    // Primary Fixed
    public string PrimaryFixed => "#B4D0FF";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#A6C2F2";
    public string OnPrimaryFixedVariant => "#000819";
    // Secondary Fixed
    public string SecondaryFixed => "#D9E3F8";
    public string OnSecondaryFixed => "#000000";
    public string SecondaryFixedDim => "#CAD5EA";
    public string OnSecondaryFixedVariant => "#16202F";
    // Tertiary Fixed
    public string TertiaryFixed => "#D0C8FF";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#C2BAF3";
    public string OnTertiaryFixedVariant => "#07002F";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#21262F";
    public string SurfaceContainer => "#2B313A";
    public string SurfaceContainerHigh => "#363C45";
    public string SurfaceContainerHighest => "#1B2637";
}
