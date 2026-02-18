namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class DarkMode_HighContrast_Spec2026_Red : ITestTheme
{
    public string SourceColor => "#D2463D"; //Red
    public bool IsDark => true;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#FFDEDA";
    public string OnPrimary => "#600004";
    public string PrimaryContainer => "#FF7C70";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#FFDDE0";
    public string OnSecondary => "#5E011E";
    public string SecondaryContainer => "#FA7C90";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#F3DEFF";
    public string OnTertiary => "#450272";
    public string TertiaryContainer => "#CA90FA";
    public string OnTertiaryContainer => "#000000";
    // Error
    public string Error => "#FFDDDF";
    public string OnError => "#5F001C";
    public string ErrorContainer => "#FF798C";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#240209";
    public string SurfaceVariant => "#48121D";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#FFDDE0";
    public string SurfaceDim => "#240209";
    public string SurfaceBright => "#521723";
    public string SurfaceTint => "#FFDEDA";
    // Background
    public string Background => "#240209";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#EBA7AF";
    public string OutlineVariant => "#D3929A";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#FFF8F7";
    public string InverseOnSurface => "#000000";
    public string InversePrimary => "#770007";
    // Primary Fixed
    public string PrimaryFixed => "#FF7C70";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#FF6256";
    public string OnPrimaryFixedVariant => "#000000";
    // Secondary Fixed
    public string SecondaryFixed => "#FFC2C8";
    public string OnSecondaryFixed => "#000000";
    public string SecondaryFixedDim => "#FFAEB8";
    public string OnSecondaryFixedVariant => "#250007";
    // Tertiary Fixed
    public string TertiaryFixed => "#D199FF";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#C48BF4";
    public string OnTertiaryFixedVariant => "#000000";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#2C050D";
    public string SurfaceContainer => "#360812";
    public string SurfaceContainerHigh => "#3F0D18";
    public string SurfaceContainerHighest => "#48121D";
}
