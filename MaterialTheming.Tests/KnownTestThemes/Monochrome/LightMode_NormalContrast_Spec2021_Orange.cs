namespace MaterialTheming.Tests.KnownTestThemes.Monochrome;

internal class LightMode_NormalContrast_Spec2021_Orange : ITestTheme
{
    public string SourceColor => "#D77837"; //Orange
    public bool IsDark => false;
    public Variant Variant => Variant.Monochrome;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#000000";
    public string OnPrimary => "#E2E2E2";
    public string PrimaryContainer => "#3B3B3B";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#5E5E5E";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#D4D4D4";
    public string OnSecondaryContainer => "#1B1B1B";
    // Tertiary
    public string Tertiary => "#3B3B3B";
    public string OnTertiary => "#E2E2E2";
    public string TertiaryContainer => "#747474";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#BA1A1A";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#FFDAD6";
    public string OnErrorContainer => "#410002";
    // Surface
    public string Surface => "#F9F9F9";
    public string SurfaceVariant => "#E2E2E2";
    public string OnSurface => "#1B1B1B";
    public string OnSurfaceVariant => "#474747";
    public string SurfaceDim => "#DADADA";
    public string SurfaceBright => "#F9F9F9";
    public string SurfaceTint => "#5E5E5E";
    // Background
    public string Background => "#F9F9F9";
    public string OnBackground => "#1B1B1B";
    // Outline
    public string Outline => "#777777";
    public string OutlineVariant => "#C6C6C6";
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
    public string OnPrimaryFixedVariant => "#E2E2E2";
    // Secondary Fixed
    public string SecondaryFixed => "#C6C6C6";
    public string OnSecondaryFixed => "#1B1B1B";
    public string SecondaryFixedDim => "#ABABAB";
    public string OnSecondaryFixedVariant => "#3B3B3B";
    // Tertiary Fixed
    public string TertiaryFixed => "#5E5E5E";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#474747";
    public string OnTertiaryFixedVariant => "#E2E2E2";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F3F3F3";
    public string SurfaceContainer => "#EEEEEE";
    public string SurfaceContainerHigh => "#E8E8E8";
    public string SurfaceContainerHighest => "#E2E2E2";
}
