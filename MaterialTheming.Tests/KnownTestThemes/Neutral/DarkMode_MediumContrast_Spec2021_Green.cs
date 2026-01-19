namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class DarkMode_MediumContrast_Spec2021_Green : ITestTheme
{
    public string SourceColor => "#338745"; //Green
    public bool IsDark => true;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#D3E0CF";
    public string OnPrimary => "#1D281D";
    public string PrimaryContainer => "#879485";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#D7DED3";
    public string OnSecondary => "#212720";
    public string SecondaryContainer => "#8B9389";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#CEE2CB";
    public string OnTertiary => "#19291A";
    public string TertiaryContainer => "#839681";
    public string OnTertiaryContainer => "#000000";
    // Error
    public string Error => "#FFD2CC";
    public string OnError => "#540003";
    public string ErrorContainer => "#FF5449";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#131412";
    public string SurfaceVariant => "#464745";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#DEDCD9";
    public string SurfaceDim => "#131412";
    public string SurfaceBright => "#444543";
    public string SurfaceTint => "#BDCABA";
    // Background
    public string Background => "#131412";
    public string OnBackground => "#E4E2DF";
    // Outline
    public string Outline => "#B3B2AF";
    public string OutlineVariant => "#91908E";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#E4E2DF";
    public string InverseOnSurface => "#292A28";
    public string InversePrimary => "#3F4B3E";
    // Primary Fixed
    public string PrimaryFixed => "#D9E6D5";
    public string OnPrimaryFixed => "#09140A";
    public string PrimaryFixedDim => "#BDCABA";
    public string OnPrimaryFixedVariant => "#2D392D";
    // Secondary Fixed
    public string SecondaryFixed => "#DDE5D9";
    public string OnSecondaryFixed => "#0C130C";
    public string SecondaryFixedDim => "#C1C9BE";
    public string OnSecondaryFixedVariant => "#313830";
    // Tertiary Fixed
    public string TertiaryFixed => "#D4E8D1";
    public string OnTertiaryFixed => "#051407";
    public string TertiaryFixedDim => "#B8CCB5";
    public string OnTertiaryFixedVariant => "#2A3A2A";
    // Surface Container
    public string SurfaceContainerLowest => "#070806";
    public string SurfaceContainerLow => "#1D1E1C";
    public string SurfaceContainer => "#272826";
    public string SurfaceContainerHigh => "#323331";
    public string SurfaceContainerHighest => "#3D3E3C";
}
