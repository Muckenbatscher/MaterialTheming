namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class DarkMode_HighContrast_Spec2025_Blue : ITestTheme
{
    public string SourceColor => "#185FAA"; //Blue
    public bool IsDark => true;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#DFE5F5";
    public string OnPrimary => "#262C38";
    public string PrimaryContainer => "#9DA4B2";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#E4E5EC";
    public string OnSecondary => "#2A2C31";
    public string SecondaryContainer => "#A2A3AA";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#EBE9FF";
    public string OnTertiary => "#2C2D46";
    public string TertiaryContainer => "#DBDAFB";
    public string OnTertiaryContainer => "#23243C";
    // Error
    public string Error => "#FFDEDB";
    public string OnError => "#5A0D10";
    public string ErrorContainer => "#F5827C";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#0E0E0F";
    public string SurfaceVariant => "#252628";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#E6E5E7";
    public string SurfaceDim => "#0E0E0F";
    public string SurfaceBright => "#2B2C2F";
    public string SurfaceTint => "#DFE5F5";
    // Background
    public string Background => "#0E0E0F";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#B9B8BB";
    public string OutlineVariant => "#A4A3A6";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#FCF8F9";
    public string InverseOnSurface => "#000000";
    public string InversePrimary => "#323844";
    // Primary Fixed
    public string PrimaryFixed => "#DCE2F2";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#CED4E3";
    public string OnPrimaryFixedVariant => "#19202B";
    // Secondary Fixed
    public string SecondaryFixed => "#E1E2E9";
    public string OnSecondaryFixed => "#000000";
    public string SecondaryFixedDim => "#D3D4DA";
    public string OnSecondaryFixedVariant => "#1D1F24";
    // Tertiary Fixed
    public string TertiaryFixed => "#DBDAFB";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#CDCCEC";
    public string OnTertiaryFixedVariant => "#171830";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#131314";
    public string SurfaceContainer => "#19191B";
    public string SurfaceContainerHigh => "#1F1F21";
    public string SurfaceContainerHighest => "#252628";
}
