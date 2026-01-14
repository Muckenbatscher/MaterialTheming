using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class DarkMode_HighContrast_Spec2021_Blue : ITestTheme
{
    public string SourceColor => "#185FAA"; //Blue
    public bool IsDark => true;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#EAF0FF";
    public string OnPrimary => "#000000";
    public string PrimaryContainer => "#9FC4FF";
    public string OnPrimaryContainer => "#000B1E";
    // Secondary
    public string Secondary => "#EEEFFF";
    public string OnSecondary => "#000000";
    public string SecondaryContainer => "#B9C1E7";
    public string OnSecondaryContainer => "#020926";
    // Tertiary
    public string Tertiary => "#F2EEFF";
    public string OnTertiary => "#000000";
    public string TertiaryContainer => "#C2BCF5";
    public string OnTertiaryContainer => "#080233";
    // Error
    public string Error => "#FFECE9";
    public string OnError => "#000000";
    public string ErrorContainer => "#FFAEA4";
    public string OnErrorContainer => "#220001";
    // Surface
    public string Surface => "#0E141C";
    public string SurfaceVariant => "#404753";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#FFFFFF";
    public string SurfaceDim => "#0E141C";
    public string SurfaceBright => "#4B505A";
    public string SurfaceTint => "#A6C8FF";
    // Background
    public string Background => "#0E141C";
    public string OnBackground => "#DEE2EF";
    // Outline
    public string Outline => "#EAF0FF";
    public string OutlineVariant => "#BCC3D1";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#DEE2EF";
    public string InverseOnSurface => "#000000";
    public string InversePrimary => "#004889";
    // Primary Fixed
    public string PrimaryFixed => "#D5E3FF";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#A6C8FF";
    public string OnPrimaryFixedVariant => "#001128";
    // Secondary Fixed
    public string SecondaryFixed => "#DCE1FF";
    public string OnSecondaryFixed => "#000000";
    public string SecondaryFixedDim => "#BDC5EB";
    public string OnSecondaryFixedVariant => "#070F2C";
    // Tertiary Fixed
    public string TertiaryFixed => "#E4DFFF";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#C6C0F9";
    public string OnTertiaryFixedVariant => "#0E0838";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#1B2029";
    public string SurfaceContainer => "#2B313A";
    public string SurfaceContainerHigh => "#363C45";
    public string SurfaceContainerHighest => "#424751";
}
