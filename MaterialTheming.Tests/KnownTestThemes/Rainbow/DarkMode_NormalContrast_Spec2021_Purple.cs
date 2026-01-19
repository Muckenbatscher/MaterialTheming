namespace MaterialTheming.Tests.KnownTestThemes.Rainbow;

internal class DarkMode_NormalContrast_Spec2021_Purple : ITestTheme
{
    public string SourceColor => "#945CCD"; //Purple
    public bool IsDark => true;
    public Variant Variant => Variant.Rainbow;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#DCB8FF";
    public string OnPrimary => "#431A6B";
    public string PrimaryContainer => "#5B3383";
    public string OnPrimaryContainer => "#F0DBFF";
    // Secondary
    public string Secondary => "#D0C1DA";
    public string OnSecondary => "#362C3F";
    public string SecondaryContainer => "#4D4357";
    public string OnSecondaryContainer => "#EDDDF6";
    // Tertiary
    public string Tertiary => "#F3B7BE";
    public string OnTertiary => "#4B252B";
    public string TertiaryContainer => "#653A41";
    public string OnTertiaryContainer => "#FFD9DD";
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
    public string SurfaceTint => "#DCB8FF";
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
    public string InversePrimary => "#744C9D";
    // Primary Fixed
    public string PrimaryFixed => "#F0DBFF";
    public string OnPrimaryFixed => "#2C0051";
    public string PrimaryFixedDim => "#DCB8FF";
    public string OnPrimaryFixedVariant => "#5B3383";
    // Secondary Fixed
    public string SecondaryFixed => "#EDDDF6";
    public string OnSecondaryFixed => "#211829";
    public string SecondaryFixedDim => "#D0C1DA";
    public string OnSecondaryFixedVariant => "#4D4357";
    // Tertiary Fixed
    public string TertiaryFixed => "#FFD9DD";
    public string OnTertiaryFixed => "#321017";
    public string TertiaryFixedDim => "#F3B7BE";
    public string OnTertiaryFixedVariant => "#653A41";
    // Surface Container
    public string SurfaceContainerLowest => "#0E0E0E";
    public string SurfaceContainerLow => "#1B1B1B";
    public string SurfaceContainer => "#1F1F1F";
    public string SurfaceContainerHigh => "#2A2A2A";
    public string SurfaceContainerHighest => "#353535";
}
