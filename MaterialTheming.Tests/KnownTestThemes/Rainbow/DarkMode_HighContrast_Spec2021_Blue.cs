using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Rainbow;

internal class DarkMode_HighContrast_Spec2021_Blue : ITestTheme
{
    public string SourceColor => "#185FAA"; //Blue
    public bool IsDark => true;
    public Variant Variant => Variant.Rainbow;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#EAF0FF";
    public string OnPrimary => "#000000";
    public string PrimaryContainer => "#9FC4FF";
    public string OnPrimaryContainer => "#000B1E";
    // Secondary
    public string Secondary => "#EAF0FF";
    public string OnSecondary => "#000000";
    public string SecondaryContainer => "#B9C3D8";
    public string OnSecondaryContainer => "#020B1A";
    // Tertiary
    public string Tertiary => "#FDEAFF";
    public string OnTertiary => "#000000";
    public string TertiaryContainer => "#D6B9DE";
    public string OnTertiaryContainer => "#15041E";
    // Error
    public string Error => "#FFECE9";
    public string OnError => "#000000";
    public string ErrorContainer => "#FFAEA4";
    public string OnErrorContainer => "#220001";
    // Surface
    public string Surface => "#131313";
    public string SurfaceVariant => "#474747";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#FFFFFF";
    public string SurfaceDim => "#131313";
    public string SurfaceBright => "#505050";
    public string SurfaceTint => "#A6C8FF";
    // Background
    public string Background => "#131313";
    public string OnBackground => "#E2E2E2";
    // Outline
    public string Outline => "#F0F0F0";
    public string OutlineVariant => "#C2C2C2";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#E2E2E2";
    public string InverseOnSurface => "#000000";
    public string InversePrimary => "#004889";
    // Primary Fixed
    public string PrimaryFixed => "#D5E3FF";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#A6C8FF";
    public string OnPrimaryFixedVariant => "#001128";
    // Secondary Fixed
    public string SecondaryFixed => "#D9E3F8";
    public string OnSecondaryFixed => "#000000";
    public string SecondaryFixedDim => "#BDC7DC";
    public string OnSecondaryFixedVariant => "#071120";
    // Tertiary Fixed
    public string TertiaryFixed => "#F7D8FF";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#DABDE2";
    public string OnTertiaryFixedVariant => "#1C0924";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#1F1F1F";
    public string SurfaceContainer => "#303030";
    public string SurfaceContainerHigh => "#3B3B3B";
    public string SurfaceContainerHighest => "#474747";
}
