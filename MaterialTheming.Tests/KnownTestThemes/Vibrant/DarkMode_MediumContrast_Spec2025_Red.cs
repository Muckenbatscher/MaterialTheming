using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class DarkMode_MediumContrast_Spec2025_Red : ITestTheme
{
    public string SourceColor => "#D2463D"; //Red
    public bool IsDark => true;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#FF9F95";
    public string OnPrimary => "#600004";
    public string PrimaryContainer => "#FF766A";
    public string OnPrimaryContainer => "#330001";
    // Secondary
    public string Secondary => "#FF9DAA";
    public string OnSecondary => "#5F011E";
    public string SecondaryContainer => "#C04F63";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#D7A4FF";
    public string OnTertiary => "#450372";
    public string TertiaryContainer => "#CA90FA";
    public string OnTertiaryContainer => "#310053";
    // Error
    public string Error => "#FF9DA8";
    public string OnError => "#5F001C";
    public string ErrorContainer => "#D73357";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#240209";
    public string SurfaceVariant => "#48121D";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#EBA7AF";
    public string SurfaceDim => "#240209";
    public string SurfaceBright => "#521723";
    public string SurfaceTint => "#FF9F95";
    // Background
    public string Background => "#240209";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#C1828A";
    public string OutlineVariant => "#9F656D";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#FFF8F7";
    public string InverseOnSurface => "#582A31";
    public string InversePrimary => "#A51F1C";
    // Primary Fixed
    public string PrimaryFixed => "#FF766A";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#FC5E52";
    public string OnPrimaryFixedVariant => "#000000";
    // Secondary Fixed
    public string SecondaryFixed => "#FFC2C8";
    public string OnSecondaryFixed => "#250007";
    public string SecondaryFixedDim => "#FFAEB8";
    public string OnSecondaryFixedVariant => "#6A0B26";
    // Tertiary Fixed
    public string TertiaryFixed => "#D199FF";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#C48BF4";
    public string OnTertiaryFixedVariant => "#280046";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#2C050D";
    public string SurfaceContainer => "#360812";
    public string SurfaceContainerHigh => "#3F0D18";
    public string SurfaceContainerHighest => "#48121D";
}
