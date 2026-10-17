namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class DarkMode_HighContrast_Spec2025_Watch_Cyan : ITestTheme
{
    public string SourceColor => "#00BCD1"; //Cyan
    public bool IsDark => true;
    public Variant Variant => Variant.TonalSpot;
    public Platform Platform => Platform.Watch;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#FFFFFF";
    public string OnPrimary => "#000000";
    public string PrimaryContainer => "#6DB0BC";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#FFFFFF";
    public string OnSecondary => "#000000";
    public string SecondaryContainer => "#91AAAF";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#FFFFFF";
    public string OnTertiary => "#000000";
    public string TertiaryContainer => "#8DBBE0";
    public string OnTertiaryContainer => "#000000";
    // Error
    public string Error => "#FFBEB9";
    public string OnError => "#000000";
    public string ErrorContainer => "#F58680";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#000000";
    public string SurfaceVariant => "#0E292E";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#FEFFFF";
    public string SurfaceDim => "#051012";
    public string SurfaceBright => "#153034";
    public string SurfaceTint => "#FFFFFF";
    // Background
    public string Background => "#000000";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#C3D0D3";
    public string OutlineVariant => "#9BA8AB";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#EEFCFF";
    public string InverseOnSurface => "#000000";
    public string InversePrimary => "#000000";
    // Primary Fixed
    public string PrimaryFixed => "#A9EEFA";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#9BDFEC";
    public string OnPrimaryFixedVariant => "#002429";
    // Secondary Fixed
    public string SecondaryFixed => "#CDE7EC";
    public string OnSecondaryFixed => "#000000";
    public string SecondaryFixedDim => "#BFD9DE";
    public string OnSecondaryFixedVariant => "#092327";
    // Tertiary Fixed
    public string TertiaryFixed => "#A9D7FD";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#9BC9EE";
    public string OnTertiaryFixedVariant => "#000F1A";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#1C282A";
    public string SurfaceContainer => "#263235";
    public string SurfaceContainerHigh => "#313D40";
    public string SurfaceContainerHighest => "#0E292E";
}
