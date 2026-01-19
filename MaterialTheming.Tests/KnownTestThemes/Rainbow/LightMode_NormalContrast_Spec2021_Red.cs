namespace MaterialTheming.Tests.KnownTestThemes.Rainbow;

internal class LightMode_NormalContrast_Spec2021_Red : ITestTheme
{
    public string SourceColor => "#D2463D"; //Red
    public bool IsDark => false;
    public Variant Variant => Variant.Rainbow;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#9C423A";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#FFDAD6";
    public string OnPrimaryContainer => "#7D2B25";
    // Secondary
    public string Secondary => "#775653";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#FFDAD6";
    public string OnSecondaryContainer => "#5D3F3C";
    // Tertiary
    public string Tertiary => "#715B2E";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#FDDFA6";
    public string OnTertiaryContainer => "#584419";
    // Error
    public string Error => "#BA1A1A";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#FFDAD6";
    public string OnErrorContainer => "#93000A";
    // Surface
    public string Surface => "#F9F9F9";
    public string SurfaceVariant => "#E2E2E2";
    public string OnSurface => "#1B1B1B";
    public string OnSurfaceVariant => "#474747";
    public string SurfaceDim => "#DADADA";
    public string SurfaceBright => "#F9F9F9";
    public string SurfaceTint => "#9C423A";
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
    public string InversePrimary => "#FFB4AB";
    // Primary Fixed
    public string PrimaryFixed => "#FFDAD6";
    public string OnPrimaryFixed => "#410002";
    public string PrimaryFixedDim => "#FFB4AB";
    public string OnPrimaryFixedVariant => "#7D2B25";
    // Secondary Fixed
    public string SecondaryFixed => "#FFDAD6";
    public string OnSecondaryFixed => "#2C1513";
    public string SecondaryFixedDim => "#E7BDB8";
    public string OnSecondaryFixedVariant => "#5D3F3C";
    // Tertiary Fixed
    public string TertiaryFixed => "#FDDFA6";
    public string OnTertiaryFixed => "#261900";
    public string TertiaryFixedDim => "#E0C38C";
    public string OnTertiaryFixedVariant => "#584419";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F3F3F3";
    public string SurfaceContainer => "#EEEEEE";
    public string SurfaceContainerHigh => "#E8E8E8";
    public string SurfaceContainerHighest => "#E2E2E2";
}
