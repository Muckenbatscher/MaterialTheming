using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class DarkMode_MediumContrast_Spec2021_Blue : ITestTheme
{
    public string SourceColor => "#185FAA"; //Blue
    public bool IsDark => true;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#CBDDFF";
    public string OnPrimary => "#00264C";
    public string PrimaryContainer => "#2B91FF";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#D4DBFF";
    public string OnSecondary => "#1C2442";
    public string SecondaryContainer => "#888FB3";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#DDD8FF";
    public string OnTertiary => "#231F4D";
    public string TertiaryContainer => "#908BC0";
    public string OnTertiaryContainer => "#000000";
    // Error
    public string Error => "#FFD2CC";
    public string OnError => "#540003";
    public string ErrorContainer => "#FF5449";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#0E141C";
    public string SurfaceVariant => "#404753";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#D6DCEC";
    public string SurfaceDim => "#0E141C";
    public string SurfaceBright => "#40454E";
    public string SurfaceTint => "#A6C8FF";
    // Background
    public string Background => "#0E141C";
    public string OnBackground => "#DEE2EF";
    // Outline
    public string Outline => "#ACB2C0";
    public string OutlineVariant => "#8A909E";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#DEE2EF";
    public string InverseOnSurface => "#252A33";
    public string InversePrimary => "#004889";
    // Primary Fixed
    public string PrimaryFixed => "#D5E3FF";
    public string OnPrimaryFixed => "#001128";
    public string PrimaryFixedDim => "#A6C8FF";
    public string OnPrimaryFixedVariant => "#003669";
    // Secondary Fixed
    public string SecondaryFixed => "#DCE1FF";
    public string OnSecondaryFixed => "#070F2C";
    public string SecondaryFixedDim => "#BDC5EB";
    public string OnSecondaryFixedVariant => "#2D3553";
    // Tertiary Fixed
    public string TertiaryFixed => "#E4DFFF";
    public string OnTertiaryFixed => "#0E0838";
    public string TertiaryFixedDim => "#C6C0F9";
    public string OnTertiaryFixedVariant => "#34305F";
    // Surface Container
    public string SurfaceContainerLowest => "#04080F";
    public string SurfaceContainerLow => "#191E26";
    public string SurfaceContainer => "#232831";
    public string SurfaceContainerHigh => "#2E333C";
    public string SurfaceContainerHighest => "#393E47";
}
