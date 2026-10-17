namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class DarkMode_NormalContrast_Spec2025_Watch_Cyan : ITestTheme
{
    public string SourceColor => "#00BCD1"; //Cyan
    public bool IsDark => true;
    public Variant Variant => Variant.TonalSpot;
    public Platform Platform => Platform.Watch;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#A9EEFA";
    public string OnPrimary => "#00464F";
    public string PrimaryContainer => "#004F58";
    public string OnPrimaryContainer => "#A7EBF8";
    // Secondary
    public string Secondary => "#CDE7EC";
    public string OnSecondary => "#2B4347";
    public string SecondaryContainer => "#334B4F";
    public string OnSecondaryContainer => "#CBE5EA";
    // Tertiary
    public string Tertiary => "#A9D7FD";
    public string OnTertiary => "#003854";
    public string TertiaryContainer => "#8DBBE0";
    public string OnTertiaryContainer => "#002D45";
    // Error
    public string Error => "#FFBEB9";
    public string OnError => "#3F0004";
    public string ErrorContainer => "#7E2A29";
    public string OnErrorContainer => "#FFD7D4";
    // Surface
    public string Surface => "#000000";
    public string SurfaceVariant => "#0E292E";
    public string OnSurface => "#DDEAED";
    public string OnSurfaceVariant => "#C3D0D3";
    public string SurfaceDim => "#051012";
    public string SurfaceBright => "#153034";
    public string SurfaceTint => "#A9EEFA";
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
    public string InverseOnSurface => "#4B575A";
    public string InversePrimary => "#095E69";
    // Primary Fixed
    public string PrimaryFixed => "#A9EEFA";
    public string OnPrimaryFixed => "#00464F";
    public string PrimaryFixedDim => "#9BDFEC";
    public string OnPrimaryFixedVariant => "#004F58";
    // Secondary Fixed
    public string SecondaryFixed => "#CDE7EC";
    public string OnSecondaryFixed => "#2B4347";
    public string SecondaryFixedDim => "#BFD9DE";
    public string OnSecondaryFixedVariant => "#334B4F";
    // Tertiary Fixed
    public string TertiaryFixed => "#A9D7FD";
    public string OnTertiaryFixed => "#003854";
    public string TertiaryFixedDim => "#9BC9EE";
    public string OnTertiaryFixedVariant => "#164B6B";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#1C282A";
    public string SurfaceContainer => "#263235";
    public string SurfaceContainerHigh => "#313D40";
    public string SurfaceContainerHighest => "#0E292E";
}
