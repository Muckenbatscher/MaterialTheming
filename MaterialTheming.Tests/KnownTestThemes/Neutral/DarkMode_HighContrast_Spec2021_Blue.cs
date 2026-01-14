using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class DarkMode_HighContrast_Spec2021_Blue : ITestTheme
{
    public string SourceColor => "#185FAA"; //Blue
    public bool IsDark => true;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#EAF0FF";
    public string OnPrimary => "#000000";
    public string PrimaryContainer => "#BCC3D1";
    public string OnPrimaryContainer => "#050B16";
    // Secondary
    public string Secondary => "#EDF0F9";
    public string OnSecondary => "#000000";
    public string SecondaryContainer => "#C0C2CB";
    public string OnSecondaryContainer => "#080B12";
    // Tertiary
    public string Tertiary => "#EAF0FF";
    public string OnTertiary => "#000000";
    public string TertiaryContainer => "#B9C3D8";
    public string OnTertiaryContainer => "#020B1A";
    // Error
    public string Error => "#FFECE9";
    public string OnError => "#000000";
    public string ErrorContainer => "#FFAEA4";
    public string OnErrorContainer => "#220001";
    // Surface
    public string Surface => "#131315";
    public string SurfaceVariant => "#474648";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#FFFFFF";
    public string SurfaceDim => "#131315";
    public string SurfaceBright => "#505051";
    public string SurfaceTint => "#C0C7D5";
    // Background
    public string Background => "#131315";
    public string OnBackground => "#E4E2E3";
    // Outline
    public string Outline => "#F2EFF1";
    public string OutlineVariant => "#C4C2C3";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#E4E2E3";
    public string InverseOnSurface => "#000000";
    public string InversePrimary => "#424854";
    // Primary Fixed
    public string PrimaryFixed => "#DCE2F2";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#C0C7D5";
    public string OnPrimaryFixedVariant => "#0B111C";
    // Secondary Fixed
    public string SecondaryFixed => "#E0E2EC";
    public string OnSecondaryFixed => "#000000";
    public string SecondaryFixedDim => "#C4C6CF";
    public string OnSecondaryFixedVariant => "#0E1118";
    // Tertiary Fixed
    public string TertiaryFixed => "#D9E3F8";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#BDC7DC";
    public string OnTertiaryFixedVariant => "#071120";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#1F1F21";
    public string SurfaceContainer => "#303032";
    public string SurfaceContainerHigh => "#3B3B3D";
    public string SurfaceContainerHighest => "#474648";
}
