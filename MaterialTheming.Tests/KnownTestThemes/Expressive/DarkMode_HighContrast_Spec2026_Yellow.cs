namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class DarkMode_HighContrast_Spec2026_Yellow : ITestTheme
{
    public string SourceColor => "#B2B037"; //Yellow
    public bool IsDark => true;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#FFFCC6";
    public string OnPrimary => "#3B3A00";
    public string PrimaryContainer => "#F2EF96";
    public string OnPrimaryContainer => "#323100";
    // Secondary
    public string Secondary => "#DDE5FC";
    public string OnSecondary => "#242C3D";
    public string SecondaryContainer => "#9CA4B9";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#DEE5FF";
    public string OnTertiary => "#002869";
    public string TertiaryContainer => "#9DB7FF";
    public string OnTertiaryContainer => "#000000";
    // Error
    public string Error => "#FFDED7";
    public string OnError => "#5A0E00";
    public string ErrorContainer => "#FF7E5E";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#0F0E07";
    public string SurfaceVariant => "#272712";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#EAE7BD";
    public string SurfaceDim => "#0F0E07";
    public string SurfaceBright => "#2E2D14";
    public string SurfaceTint => "#FFFCC6";
    // Background
    public string Background => "#0F0E07";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#BDBB93";
    public string OutlineVariant => "#A7A57F";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#FDF9EC";
    public string InverseOnSurface => "#000000";
    public string InversePrimary => "#3B3A00";
    // Primary Fixed
    public string PrimaryFixed => "#E9E78E";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#DBD982";
    public string OnPrimaryFixedVariant => "#212100";
    // Secondary Fixed
    public string SecondaryFixed => "#E0E8FF";
    public string OnSecondaryFixed => "#000000";
    public string SecondaryFixedDim => "#D2DAF0";
    public string OnSecondaryFixedVariant => "#1C2434";
    // Tertiary Fixed
    public string TertiaryFixed => "#9DB7FF";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#89A9FC";
    public string OnTertiaryFixedVariant => "#000000";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#14140A";
    public string SurfaceContainer => "#1B1A0D";
    public string SurfaceContainerHigh => "#212010";
    public string SurfaceContainerHighest => "#272712";
}
