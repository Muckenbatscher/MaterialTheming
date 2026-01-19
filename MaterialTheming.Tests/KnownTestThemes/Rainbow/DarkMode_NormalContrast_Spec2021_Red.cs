namespace MaterialTheming.Tests.KnownTestThemes.Rainbow;

internal class DarkMode_NormalContrast_Spec2021_Red : ITestTheme
{
    public string SourceColor => "#D2463D"; //Red
    public bool IsDark => true;
    public Variant Variant => Variant.Rainbow;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#FFB4AB";
    public string OnPrimary => "#5F1411";
    public string PrimaryContainer => "#7D2B25";
    public string OnPrimaryContainer => "#FFDAD6";
    // Secondary
    public string Secondary => "#E7BDB8";
    public string OnSecondary => "#442926";
    public string SecondaryContainer => "#5D3F3C";
    public string OnSecondaryContainer => "#FFDAD6";
    // Tertiary
    public string Tertiary => "#E0C38C";
    public string OnTertiary => "#3F2E04";
    public string TertiaryContainer => "#584419";
    public string OnTertiaryContainer => "#FDDFA6";
    // Error
    public string Error => "#FFB4AB";
    public string OnError => "#690005";
    public string ErrorContainer => "#93000A";
    public string OnErrorContainer => "#FFDAD6";
    // Surface
    public string Surface => "#131313";
    public string SurfaceVariant => "#474747";
    public string OnSurface => "#E2E2E2";
    public string OnSurfaceVariant => "#C6C6C6";
    public string SurfaceDim => "#131313";
    public string SurfaceBright => "#393939";
    public string SurfaceTint => "#FFB4AB";
    // Background
    public string Background => "#131313";
    public string OnBackground => "#E2E2E2";
    // Outline
    public string Outline => "#919191";
    public string OutlineVariant => "#474747";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#E2E2E2";
    public string InverseOnSurface => "#303030";
    public string InversePrimary => "#9C423A";
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
    public string SurfaceContainerLowest => "#0E0E0E";
    public string SurfaceContainerLow => "#1B1B1B";
    public string SurfaceContainer => "#1F1F1F";
    public string SurfaceContainerHigh => "#2A2A2A";
    public string SurfaceContainerHighest => "#353535";
}
