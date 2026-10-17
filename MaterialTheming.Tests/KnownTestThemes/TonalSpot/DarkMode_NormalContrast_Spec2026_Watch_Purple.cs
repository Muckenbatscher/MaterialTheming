namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class DarkMode_NormalContrast_Spec2026_Watch_Purple : ITestTheme
{
    public string SourceColor => "#945CCD"; //Purple
    public bool IsDark => true;
    public Variant Variant => Variant.TonalSpot;
    public Platform Platform => Platform.Watch;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#E4C6FE";
    public string OnPrimary => "#402A57";
    public string PrimaryContainer => "#543D6B";
    public string OnPrimaryContainer => "#EED8FF";
    // Secondary
    public string Secondary => "#EDDDF6";
    public string OnSecondary => "#463B4F";
    public string SecondaryContainer => "#4D4357";
    public string OnSecondaryContainer => "#EADBF4";
    // Tertiary
    public string Tertiary => "#C5CCFF";
    public string OnTertiary => "#262F5C";
    public string TertiaryContainer => "#A8B0E5";
    public string OnTertiaryContainer => "#1B2450";
    // Error
    public string Error => "#FFBDC3";
    public string OnError => "#3F000F";
    public string ErrorContainer => "#7D2938";
    public string OnErrorContainer => "#FFD6D9";
    // Surface
    public string Surface => "#000000";
    public string SurfaceVariant => "#2C2235";
    public string OnSurface => "#EFE4F3";
    public string OnSurfaceVariant => "#D5CBD9";
    public string SurfaceDim => "#110C16";
    public string SurfaceBright => "#32283C";
    public string SurfaceTint => "#E4C6FE";
    // Background
    public string Background => "#000000";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#ACA2B0";
    public string OutlineVariant => "#8B8390";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#FFF7FE";
    public string InverseOnSurface => "#5A525E";
    public string InversePrimary => "#634B7A";
    // Primary Fixed
    public string PrimaryFixed => "#E4C6FE";
    public string OnPrimaryFixed => "#402A57";
    public string PrimaryFixedDim => "#D6B8F0";
    public string OnPrimaryFixedVariant => "#543D6B";
    // Secondary Fixed
    public string SecondaryFixed => "#EDDDF6";
    public string OnSecondaryFixed => "#463B4F";
    public string SecondaryFixedDim => "#DECFE8";
    public string OnSecondaryFixedVariant => "#4D4357";
    // Tertiary Fixed
    public string TertiaryFixed => "#C5CCFF";
    public string OnTertiaryFixed => "#262F5C";
    public string TertiaryFixedDim => "#B6BEF4";
    public string OnTertiaryFixedVariant => "#3B4472";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#29242E";
    public string SurfaceContainer => "#342E39";
    public string SurfaceContainerHigh => "#3F3944";
    public string SurfaceContainerHighest => "#2C2235";
}
