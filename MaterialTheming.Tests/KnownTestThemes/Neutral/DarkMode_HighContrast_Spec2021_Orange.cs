using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class DarkMode_HighContrast_Spec2021_Orange : ITestTheme
{
    public string SourceColor => "#D77837"; //Orange
    public bool IsDark => true;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#FFECE3";
    public string OnPrimary => "#000000";
    public string PrimaryContainer => "#DABDAD";
    public string OnPrimaryContainer => "#150802";
    // Secondary
    public string Secondary => "#FFECE3";
    public string OnSecondary => "#000000";
    public string SecondaryContainer => "#D3BFB4";
    public string OnSecondaryContainer => "#120905";
    // Tertiary
    public string Tertiary => "#FFECE3";
    public string OnTertiary => "#000000";
    public string TertiaryContainer => "#E1BBA6";
    public string OnTertiaryContainer => "#180701";
    // Error
    public string Error => "#FFECE9";
    public string OnError => "#000000";
    public string ErrorContainer => "#FFAEA4";
    public string OnErrorContainer => "#220001";
    // Surface
    public string Surface => "#161311";
    public string SurfaceVariant => "#4A4644";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#FFFFFF";
    public string SurfaceDim => "#161311";
    public string SurfaceBright => "#544F4D";
    public string SurfaceTint => "#DEC1B1";
    // Background
    public string Background => "#161311";
    public string OnBackground => "#E9E1DE";
    // Outline
    public string Outline => "#F6EEEB";
    public string OutlineVariant => "#C8C1BE";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#E9E1DE";
    public string InverseOnSurface => "#000000";
    public string InversePrimary => "#584438";
    // Primary Fixed
    public string PrimaryFixed => "#FBDCCC";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#DEC1B1";
    public string OnPrimaryFixedVariant => "#1C0E05";
    // Secondary Fixed
    public string SecondaryFixed => "#F4DED3";
    public string OnSecondaryFixed => "#000000";
    public string SecondaryFixedDim => "#D7C2B8";
    public string OnSecondaryFixedVariant => "#190F09";
    // Tertiary Fixed
    public string TertiaryFixed => "#FFDBC8";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#E5BFA9";
    public string OnTertiaryFixedVariant => "#1F0C03";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#221F1D";
    public string SurfaceContainer => "#33302E";
    public string SurfaceContainerHigh => "#3F3B39";
    public string SurfaceContainerHighest => "#4A4644";
}
