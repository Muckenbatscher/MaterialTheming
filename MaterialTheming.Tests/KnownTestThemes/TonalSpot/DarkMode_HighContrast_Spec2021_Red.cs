namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class DarkMode_HighContrast_Spec2021_Red : ITestTheme
{
    public string SourceColor => "#D2463D"; //Red
    public bool IsDark => true;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#FFECE9";
    public string OnPrimary => "#000000";
    public string PrimaryContainer => "#FFAEA5";
    public string OnPrimaryContainer => "#220001";
    // Secondary
    public string Secondary => "#FFECE9";
    public string OnSecondary => "#000000";
    public string SecondaryContainer => "#E3B9B4";
    public string OnSecondaryContainer => "#190605";
    // Tertiary
    public string Tertiary => "#FFEED2";
    public string OnTertiary => "#000000";
    public string TertiaryContainer => "#DCBF89";
    public string OnTertiaryContainer => "#120A00";
    // Error
    public string Error => "#FFECE9";
    public string OnError => "#000000";
    public string ErrorContainer => "#FFAEA4";
    public string OnErrorContainer => "#220001";
    // Surface
    public string Surface => "#1A1110";
    public string SurfaceVariant => "#534341";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#FFFFFF";
    public string SurfaceDim => "#1A1110";
    public string SurfaceBright => "#5A4D4C";
    public string SurfaceTint => "#FFB4AB";
    // Background
    public string Background => "#1A1110";
    public string OnBackground => "#F1DEDC";
    // Outline
    public string Outline => "#FFECE9";
    public string OutlineVariant => "#D4BEBB";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#F1DEDC";
    public string InverseOnSurface => "#000000";
    public string InversePrimary => "#74352F";
    // Primary Fixed
    public string PrimaryFixed => "#FFDAD6";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#FFB4AB";
    public string OnPrimaryFixedVariant => "#2C0102";
    // Secondary Fixed
    public string SecondaryFixed => "#FFDAD6";
    public string OnSecondaryFixed => "#000000";
    public string SecondaryFixedDim => "#E7BDB8";
    public string OnSecondaryFixedVariant => "#200B09";
    // Tertiary Fixed
    public string TertiaryFixed => "#FDDFA6";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#E0C38C";
    public string OnTertiaryFixedVariant => "#191000";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#271D1C";
    public string SurfaceContainer => "#392E2D";
    public string SurfaceContainerHigh => "#443937";
    public string SurfaceContainerHighest => "#504443";
}
