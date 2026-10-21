namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class DarkMode_MediumContrast_Spec2025_Watch_Purple : ITestTheme
{
    public string SourceColor => "#945CCD"; //Purple
    public bool IsDark => true;
    public Variant Variant => Variant.TonalSpot;
    public Platform Platform => Platform.Watch;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#FFFEFF";
    public string OnPrimary => "#17012E";
    public string PrimaryContainer => "#957BAE";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#FFFEFF";
    public string OnSecondary => "#251C2E";
    public string SecondaryContainer => "#8E8197";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#FFFEFF";
    public string OnTertiary => "#000429";
    public string TertiaryContainer => "#A8B0E5";
    public string OnTertiaryContainer => "#1B2450";
    // Error
    public string Error => "#FFBDC3";
    public string OnError => "#3D000F";
    public string ErrorContainer => "#CC6674";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#000000";
    public string SurfaceVariant => "#2C2235";
    public string OnSurface => "#FFFEFF";
    public string OnSurfaceVariant => "#D5CBD9";
    public string SurfaceDim => "#110C16";
    public string SurfaceBright => "#32283C";
    public string SurfaceTint => "#FFFEFF";
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
    public string InverseOnSurface => "#3C3641";
    public string InversePrimary => "#452E5B";
    // Primary Fixed
    public string PrimaryFixed => "#E4C6FE";
    public string OnPrimaryFixed => "#17012E";
    public string PrimaryFixedDim => "#D6B8F0";
    public string OnPrimaryFixedVariant => "#402A57";
    // Secondary Fixed
    public string SecondaryFixed => "#EDDDF6";
    public string OnSecondaryFixed => "#251C2E";
    public string SecondaryFixedDim => "#DECFE8";
    public string OnSecondaryFixedVariant => "#463B4F";
    // Tertiary Fixed
    public string TertiaryFixed => "#C5CCFF";
    public string OnTertiaryFixed => "#000429";
    public string TertiaryFixedDim => "#B6BEF4";
    public string OnTertiaryFixedVariant => "#262F5C";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#29242E";
    public string SurfaceContainer => "#342E39";
    public string SurfaceContainerHigh => "#3F3944";
    public string SurfaceContainerHighest => "#2C2235";
}
