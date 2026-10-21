namespace MaterialTheming.Tests.KnownTestThemes.Content;

internal class DarkMode_NormalContrast_Spec2026_Watch_Orange : ITestTheme
{
    public string SourceColor => "#D77837"; //Orange
    public bool IsDark => true;
    public Variant Variant => Variant.Content;
    public Platform Platform => Platform.Watch;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#FFC29E";
    public string OnPrimary => "#411A00";
    public string PrimaryContainer => "#743400";
    public string OnPrimaryContainer => "#FFD8C3";
    // Secondary
    public string Secondary => "#FDC2A0";
    public string OnSecondary => "#4D2911";
    public string SecondaryContainer => "#653D23";
    public string OnSecondaryContainer => "#FFD8C3";
    // Tertiary
    public string Tertiary => "#FFC655";
    public string OnTertiary => "#442F00";
    public string TertiaryContainer => "#E3AA2E";
    public string OnTertiaryContainer => "#362500";
    // Error
    public string Error => "#FFBFB0";
    public string OnError => "#3B0600";
    public string ErrorContainer => "#7E2B17";
    public string OnErrorContainer => "#FFD7CE";
    // Surface
    public string Surface => "#000000";
    public string SurfaceVariant => "#372012";
    public string OnSurface => "#FFE2D4";
    public string OnSurfaceVariant => "#EEC6AF";
    public string SurfaceDim => "#1C0901";
    public string SurfaceBright => "#3F2617";
    public string SurfaceTint => "#FFC29E";
    // Background
    public string Background => "#000000";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#C39E89";
    public string OutlineVariant => "#A17E6B";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#FFF8F5";
    public string InverseOnSurface => "#6C4F3D";
    public string InversePrimary => "#8A4000";
    // Primary Fixed
    public string PrimaryFixed => "#FFC29E";
    public string OnPrimaryFixed => "#411A00";
    public string PrimaryFixedDim => "#FE9753";
    public string OnPrimaryFixedVariant => "#6F3200";
    // Secondary Fixed
    public string SecondaryFixed => "#FDC2A0";
    public string OnSecondaryFixed => "#4D2911";
    public string SecondaryFixedDim => "#EEB593";
    public string OnSecondaryFixedVariant => "#653D23";
    // Tertiary Fixed
    public string TertiaryFixed => "#FFC655";
    public string OnTertiaryFixed => "#442F00";
    public string TertiaryFixedDim => "#F3B73C";
    public string OnTertiaryFixedVariant => "#5E4200";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#372012";
    public string SurfaceContainer => "#432B1B";
    public string SurfaceContainerHigh => "#503525";
    public string SurfaceContainerHighest => "#372012";
}
