namespace MaterialTheming.Tests.KnownTestThemes.Rainbow;

internal class LightMode_MediumContrast_Spec2021_Red : ITestTheme
{
    public string SourceColor => "#D2463D"; //Red
    public bool IsDark => false;
    public Variant Variant => Variant.Rainbow;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#671A16";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#AF5047";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#4B2F2C";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#876561";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#453309";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#816A3B";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#740006";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#CF2C27";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#F9F9F9";
    public string SurfaceVariant => "#E2E2E2";
    public string OnSurface => "#111111";
    public string OnSurfaceVariant => "#363636";
    public string SurfaceDim => "#C6C6C6";
    public string SurfaceBright => "#F9F9F9";
    public string SurfaceTint => "#9C423A";
    // Background
    public string Background => "#F9F9F9";
    public string OnBackground => "#1B1B1B";
    // Outline
    public string Outline => "#525252";
    public string OutlineVariant => "#6D6D6D";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#303030";
    public string InverseOnSurface => "#F1F1F1";
    public string InversePrimary => "#FFB4AB";
    // Primary Fixed
    public string PrimaryFixed => "#AF5047";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#903831";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#876561";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#6D4D49";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#816A3B";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#675225";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F3F3F3";
    public string SurfaceContainer => "#E8E8E8";
    public string SurfaceContainerHigh => "#DDDDDD";
    public string SurfaceContainerHighest => "#D1D1D1";
}
