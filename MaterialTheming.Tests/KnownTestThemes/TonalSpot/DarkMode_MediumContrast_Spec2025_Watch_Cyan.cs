namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class DarkMode_MediumContrast_Spec2025_Watch_Cyan : ITestTheme
{
    public string SourceColor => "#00BCD1"; //Cyan
    public bool IsDark => true;
    public Variant Variant => Variant.TonalSpot;
    public Platform Platform => Platform.Watch;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#FEFFFF";
    public string OnPrimary => "#002429";
    public string PrimaryContainer => "#4B8F9B";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#FEFFFF";
    public string OnSecondary => "#092327";
    public string SecondaryContainer => "#718A8F";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#FFFEFF";
    public string OnTertiary => "#000F1A";
    public string TertiaryContainer => "#8DBBE0";
    public string OnTertiaryContainer => "#002D45";
    // Error
    public string Error => "#FFBEB9";
    public string OnError => "#3D0004";
    public string ErrorContainer => "#CE6762";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#000000";
    public string SurfaceVariant => "#0E292E";
    public string OnSurface => "#FEFFFF";
    public string OnSurfaceVariant => "#C3D0D3";
    public string SurfaceDim => "#051012";
    public string SurfaceBright => "#153034";
    public string SurfaceTint => "#FEFFFF";
    // Background
    public string Background => "#000000";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#9BA8AB";
    public string OutlineVariant => "#7B888B";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#EEFCFF";
    public string InverseOnSurface => "#2E3A3D";
    public string InversePrimary => "#003F47";
    // Primary Fixed
    public string PrimaryFixed => "#A9EEFA";
    public string OnPrimaryFixed => "#002429";
    public string PrimaryFixedDim => "#9BDFEC";
    public string OnPrimaryFixedVariant => "#00464F";
    // Secondary Fixed
    public string SecondaryFixed => "#CDE7EC";
    public string OnSecondaryFixed => "#092327";
    public string SecondaryFixedDim => "#BFD9DE";
    public string OnSecondaryFixedVariant => "#2B4347";
    // Tertiary Fixed
    public string TertiaryFixed => "#A9D7FD";
    public string OnTertiaryFixed => "#000F1A";
    public string TertiaryFixedDim => "#9BC9EE";
    public string OnTertiaryFixedVariant => "#003854";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#1C282A";
    public string SurfaceContainer => "#263235";
    public string SurfaceContainerHigh => "#313D40";
    public string SurfaceContainerHighest => "#0E292E";
}
