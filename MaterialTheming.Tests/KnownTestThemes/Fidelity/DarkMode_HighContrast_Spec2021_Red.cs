using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Fidelity;

internal class DarkMode_HighContrast_Spec2021_Red : ITestTheme
{
    public string SourceColor => "#D2463D"; //Red
    public bool IsDark => true;
    public Variant Variant => Variant.Fidelity;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#FFECE9";
    public string OnPrimary => "#000000";
    public string PrimaryContainer => "#FFAEA5";
    public string OnPrimaryContainer => "#150000";
    // Secondary
    public string Secondary => "#FFECE9";
    public string OnSecondary => "#000000";
    public string SecondaryContainer => "#FFAEA5";
    public string OnSecondaryContainer => "#220001";
    // Tertiary
    public string Tertiary => "#C6F9FF";
    public string OnTertiary => "#000000";
    public string TertiaryContainer => "#70D1DC";
    public string OnTertiaryContainer => "#000708";
    // Error
    public string Error => "#FFECE9";
    public string OnError => "#000000";
    public string ErrorContainer => "#FFAEA4";
    public string OnErrorContainer => "#220001";
    // Surface
    public string Surface => "#1D100F";
    public string SurfaceVariant => "#59413E";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#FFFFFF";
    public string SurfaceDim => "#1D100F";
    public string SurfaceBright => "#5E4C4A";
    public string SurfaceTint => "#FFB4AB";
    // Background
    public string Background => "#1D100F";
    public string OnBackground => "#F6DDDA";
    // Outline
    public string Outline => "#FFECE9";
    public string OutlineVariant => "#DDBBB7";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#F6DDDA";
    public string InverseOnSurface => "#000000";
    public string InversePrimary => "#901414";
    // Primary Fixed
    public string PrimaryFixed => "#FFDAD6";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#FFB4AB";
    public string OnPrimaryFixedVariant => "#2D0001";
    // Secondary Fixed
    public string SecondaryFixed => "#FFDAD6";
    public string OnSecondaryFixed => "#000000";
    public string SecondaryFixedDim => "#FFB4AB";
    public string OnSecondaryFixedVariant => "#2D0001";
    // Tertiary Fixed
    public string TertiaryFixed => "#91F2FC";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#74D5E0";
    public string OnTertiaryFixedVariant => "#001416";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#2A1C1B";
    public string SurfaceContainer => "#3C2D2B";
    public string SurfaceContainerHigh => "#483836";
    public string SurfaceContainerHighest => "#544341";
}
