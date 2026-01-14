using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Rainbow;

internal class DarkMode_NormalContrast_Spec2021_Green : ITestTheme
{
    public string SourceColor => "#338745"; //Green
    public bool IsDark => true;
    public Variant Variant => Variant.Rainbow;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#88D990";
    public string OnPrimary => "#003913";
    public string PrimaryContainer => "#00531F";
    public string OnPrimaryContainer => "#A3F5AA";
    // Secondary
    public string Secondary => "#B8CCB5";
    public string OnSecondary => "#243424";
    public string SecondaryContainer => "#3A4B3A";
    public string OnSecondaryContainer => "#D4E8D1";
    // Tertiary
    public string Tertiary => "#A1CED6";
    public string OnTertiary => "#00363D";
    public string TertiaryContainer => "#1F4D54";
    public string OnTertiaryContainer => "#BDEAF3";
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
    public string SurfaceTint => "#88D990";
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
    public string InversePrimary => "#1B6C31";
    // Primary Fixed
    public string PrimaryFixed => "#A3F5AA";
    public string OnPrimaryFixed => "#002108";
    public string PrimaryFixedDim => "#88D990";
    public string OnPrimaryFixedVariant => "#00531F";
    // Secondary Fixed
    public string SecondaryFixed => "#D4E8D1";
    public string OnSecondaryFixed => "#0F1F11";
    public string SecondaryFixedDim => "#B8CCB5";
    public string OnSecondaryFixedVariant => "#3A4B3A";
    // Tertiary Fixed
    public string TertiaryFixed => "#BDEAF3";
    public string OnTertiaryFixed => "#001F24";
    public string TertiaryFixedDim => "#A1CED6";
    public string OnTertiaryFixedVariant => "#1F4D54";
    // Surface Container
    public string SurfaceContainerLowest => "#0E0E0E";
    public string SurfaceContainerLow => "#1B1B1B";
    public string SurfaceContainer => "#1F1F1F";
    public string SurfaceContainerHigh => "#2A2A2A";
    public string SurfaceContainerHighest => "#353535";
}
