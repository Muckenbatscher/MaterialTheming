using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Rainbow;

internal class LightMode_NormalContrast_Spec2021_Purple : ITestTheme
{
    public string SourceColor => "#945CCD"; //Purple
    public bool IsDark => false;
    public Variant Variant => Variant.Rainbow;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#744C9D";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#F0DBFF";
    public string OnPrimaryContainer => "#5B3383";
    // Secondary
    public string Secondary => "#665A6F";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#EDDDF6";
    public string OnSecondaryContainer => "#4D4357";
    // Tertiary
    public string Tertiary => "#805158";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#FFD9DD";
    public string OnTertiaryContainer => "#653A41";
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
    public string SurfaceTint => "#744C9D";
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
    public string InversePrimary => "#DCB8FF";
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
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F3F3F3";
    public string SurfaceContainer => "#EEEEEE";
    public string SurfaceContainerHigh => "#E8E8E8";
    public string SurfaceContainerHighest => "#E2E2E2";
}
