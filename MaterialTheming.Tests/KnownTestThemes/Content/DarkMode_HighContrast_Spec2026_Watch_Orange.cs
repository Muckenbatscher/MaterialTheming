namespace MaterialTheming.Tests.KnownTestThemes.Content;

internal class DarkMode_HighContrast_Spec2026_Watch_Orange : ITestTheme
{
    public string SourceColor => "#D77837"; //Orange
    public bool IsDark => true;
    public Variant Variant => Variant.Content;
    public Platform Platform => Platform.Watch;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#FFFFFF";
    public string OnPrimary => "#000000";
    public string PrimaryContainer => "#F18C49";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#FFFFFF";
    public string OnSecondary => "#000000";
    public string SecondaryContainer => "#D09A7A";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#FFFFFF";
    public string OnTertiary => "#000000";
    public string TertiaryContainer => "#E3AA2E";
    public string OnTertiaryContainer => "#000000";
    // Error
    public string Error => "#FFBFB0";
    public string OnError => "#000000";
    public string ErrorContainer => "#F7866B";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#000000";
    public string SurfaceVariant => "#372012";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#FFFEFF";
    public string SurfaceDim => "#1C0901";
    public string SurfaceBright => "#3F2617";
    public string SurfaceTint => "#FFFFFF";
    // Background
    public string Background => "#000000";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#EEC6AF";
    public string OutlineVariant => "#C39E89";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#FFF8F5";
    public string InverseOnSurface => "#000000";
    public string InversePrimary => "#000000";
    // Primary Fixed
    public string PrimaryFixed => "#FFC29E";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#FE9753";
    public string OnPrimaryFixedVariant => "#000000";
    // Secondary Fixed
    public string SecondaryFixed => "#FDC2A0";
    public string OnSecondaryFixed => "#000000";
    public string SecondaryFixedDim => "#EEB593";
    public string OnSecondaryFixedVariant => "#140500";
    // Tertiary Fixed
    public string TertiaryFixed => "#FFC655";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#F3B73C";
    public string OnTertiaryFixedVariant => "#0E0700";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#372012";
    public string SurfaceContainer => "#432B1B";
    public string SurfaceContainerHigh => "#503525";
    public string SurfaceContainerHighest => "#372012";
}
