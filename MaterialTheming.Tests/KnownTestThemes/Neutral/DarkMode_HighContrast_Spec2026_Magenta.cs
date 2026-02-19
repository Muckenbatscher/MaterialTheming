namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class DarkMode_HighContrast_Spec2026_Magenta : ITestTheme
{
    public string SourceColor => "#E85DAE"; //Magenta
    public bool IsDark => true;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#F4E1E7";
    public string OnPrimary => "#34292E";
    public string PrimaryContainer => "#B09FA5";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#EEE3E5";
    public string OnSecondary => "#302A2D";
    public string SecondaryContainer => "#ABA1A4";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#FEEFFF";
    public string OnTertiary => "#3F2F47";
    public string TertiaryContainer => "#F6DDFD";
    public string OnTertiaryContainer => "#36263D";
    // Error
    public string Error => "#FFDDDF";
    public string OnError => "#5B0A1E";
    public string ErrorContainer => "#F38190";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#0F0E0E";
    public string SurfaceVariant => "#292526";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#ECE3E5";
    public string SurfaceDim => "#0F0E0E";
    public string SurfaceBright => "#302B2D";
    public string SurfaceTint => "#F4E1E7";
    // Background
    public string Background => "#0F0E0E";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#BFB7B8";
    public string OutlineVariant => "#A9A2A3";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#FEF8F8";
    public string InverseOnSurface => "#000000";
    public string InversePrimary => "#41353A";
    // Primary Fixed
    public string PrimaryFixed => "#F1DEE4";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#E2D0D6";
    public string OnPrimaryFixedVariant => "#271D21";
    // Secondary Fixed
    public string SecondaryFixed => "#EBE0E2";
    public string OnSecondaryFixed => "#000000";
    public string SecondaryFixedDim => "#DCD2D4";
    public string OnSecondaryFixedVariant => "#231E20";
    // Tertiary Fixed
    public string TertiaryFixed => "#F6DDFD";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#E7CFEE";
    public string OnTertiaryFixedVariant => "#2B1C33";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#151313";
    public string SurfaceContainer => "#1C191A";
    public string SurfaceContainerHigh => "#221F20";
    public string SurfaceContainerHighest => "#292526";
}
