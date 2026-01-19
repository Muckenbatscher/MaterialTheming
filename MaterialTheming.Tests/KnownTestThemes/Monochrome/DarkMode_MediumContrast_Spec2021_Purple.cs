namespace MaterialTheming.Tests.KnownTestThemes.Monochrome;

internal class DarkMode_MediumContrast_Spec2021_Purple : ITestTheme
{
    public string SourceColor => "#945CCD"; //Purple
    public bool IsDark => true;
    public Variant Variant => Variant.Monochrome;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#FFFFFF";
    public string OnPrimary => "#1B1B1B";
    public string PrimaryContainer => "#D4D4D4";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#DCDCDC";
    public string OnSecondary => "#1B1B1B";
    public string SecondaryContainer => "#919191";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#E2E2E2";
    public string OnTertiary => "#1B1B1B";
    public string TertiaryContainer => "#919191";
    public string OnTertiaryContainer => "#000000";
    // Error
    public string Error => "#FFD2CC";
    public string OnError => "#540003";
    public string ErrorContainer => "#FF5449";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#131313";
    public string SurfaceVariant => "#474747";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#DCDCDC";
    public string SurfaceDim => "#131313";
    public string SurfaceBright => "#444444";
    public string SurfaceTint => "#C6C6C6";
    // Background
    public string Background => "#131313";
    public string OnBackground => "#E2E2E2";
    // Outline
    public string Outline => "#B2B2B2";
    public string OutlineVariant => "#909090";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#E2E2E2";
    public string InverseOnSurface => "#2A2A2A";
    public string InversePrimary => "#484848";
    // Primary Fixed
    public string PrimaryFixed => "#ABABAB";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#919191";
    public string OnPrimaryFixedVariant => "#000000";
    // Secondary Fixed
    public string SecondaryFixed => "#C6C6C6";
    public string OnSecondaryFixed => "#000000";
    public string SecondaryFixedDim => "#ABABAB";
    public string OnSecondaryFixedVariant => "#202020";
    // Tertiary Fixed
    public string TertiaryFixed => "#ABABAB";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#919191";
    public string OnTertiaryFixedVariant => "#000000";
    // Surface Container
    public string SurfaceContainerLowest => "#070707";
    public string SurfaceContainerLow => "#1D1D1D";
    public string SurfaceContainer => "#282828";
    public string SurfaceContainerHigh => "#323232";
    public string SurfaceContainerHighest => "#3E3E3E";
}
