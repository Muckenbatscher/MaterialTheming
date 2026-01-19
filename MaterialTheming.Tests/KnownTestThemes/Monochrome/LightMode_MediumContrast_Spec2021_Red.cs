namespace MaterialTheming.Tests.KnownTestThemes.Monochrome;

internal class LightMode_MediumContrast_Spec2021_Red : ITestTheme
{
    public string SourceColor => "#D2463D"; //Red
    public bool IsDark => false;
    public Variant Variant => Variant.Monochrome;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#000000";
    public string OnPrimary => "#E2E2E2";
    public string PrimaryContainer => "#3B3B3B";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#363636";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#6D6D6D";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#363636";
    public string OnTertiary => "#F5F5F5";
    public string TertiaryContainer => "#6D6D6D";
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
    public string SurfaceTint => "#5E5E5E";
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
    public string InversePrimary => "#C6C6C6";
    // Primary Fixed
    public string PrimaryFixed => "#5E5E5E";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#474747";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#6D6D6D";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#555555";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#5E5E5E";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#474747";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F3F3F3";
    public string SurfaceContainer => "#E8E8E8";
    public string SurfaceContainerHigh => "#DDDDDD";
    public string SurfaceContainerHighest => "#D1D1D1";
}
