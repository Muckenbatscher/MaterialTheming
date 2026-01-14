using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class LightMode_NormalContrast_Spec2021_Blue : ITestTheme
{
    public string SourceColor => "#185FAA"; //Blue
    public bool IsDark => false;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#005FB0";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#D5E3FF";
    public string OnPrimaryContainer => "#004787";
    // Secondary
    public string Secondary => "#555D7E";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#DCE1FF";
    public string OnSecondaryContainer => "#3E4565";
    // Tertiary
    public string Tertiary => "#5D598A";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#E4DFFF";
    public string OnTertiaryContainer => "#454171";
    // Error
    public string Error => "#BA1A1A";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#FFDAD6";
    public string OnErrorContainer => "#93000A";
    // Surface
    public string Surface => "#F9F9FF";
    public string SurfaceVariant => "#DCE2F2";
    public string OnSurface => "#171C24";
    public string OnSurfaceVariant => "#404753";
    public string SurfaceDim => "#D5DAE6";
    public string SurfaceBright => "#F9F9FF";
    public string SurfaceTint => "#005FB0";
    // Background
    public string Background => "#F9F9FF";
    public string OnBackground => "#171C24";
    // Outline
    public string Outline => "#717785";
    public string OutlineVariant => "#C0C7D5";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#2B313A";
    public string InverseOnSurface => "#ECF1FD";
    public string InversePrimary => "#A6C8FF";
    // Primary Fixed
    public string PrimaryFixed => "#D5E3FF";
    public string OnPrimaryFixed => "#001C3B";
    public string PrimaryFixedDim => "#A6C8FF";
    public string OnPrimaryFixedVariant => "#004787";
    // Secondary Fixed
    public string SecondaryFixed => "#DCE1FF";
    public string OnSecondaryFixed => "#121A37";
    public string SecondaryFixedDim => "#BDC5EB";
    public string OnSecondaryFixedVariant => "#3E4565";
    // Tertiary Fixed
    public string TertiaryFixed => "#E4DFFF";
    public string OnTertiaryFixed => "#191443";
    public string TertiaryFixedDim => "#C6C0F9";
    public string OnTertiaryFixedVariant => "#454171";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F0F3FF";
    public string SurfaceContainer => "#E9EEFA";
    public string SurfaceContainerHigh => "#E4E8F4";
    public string SurfaceContainerHighest => "#DEE2EF";
}
