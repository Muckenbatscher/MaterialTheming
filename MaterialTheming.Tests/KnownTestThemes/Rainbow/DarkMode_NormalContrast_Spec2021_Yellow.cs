using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Rainbow;

internal class DarkMode_NormalContrast_Spec2021_Yellow : ITestTheme
{
    public string SourceColor => "#B2B037"; //Yellow
    public bool IsDark => true;
    public Variant Variant => Variant.Rainbow;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#CECB56";
    public string OnPrimary => "#333200";
    public string PrimaryContainer => "#4A4900";
    public string OnPrimaryContainer => "#EAE86E";
    // Secondary
    public string Secondary => "#CBC8A4";
    public string OnSecondary => "#323218";
    public string SecondaryContainer => "#49482D";
    public string OnSecondaryContainer => "#E7E4BF";
    // Tertiary
    public string Tertiary => "#A4D0BC";
    public string OnTertiary => "#0C3729";
    public string TertiaryContainer => "#264E3F";
    public string OnTertiaryContainer => "#C0ECD7";
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
    public string SurfaceTint => "#CECB56";
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
    public string InversePrimary => "#636100";
    // Primary Fixed
    public string PrimaryFixed => "#EAE86E";
    public string OnPrimaryFixed => "#1D1D00";
    public string PrimaryFixedDim => "#CECB56";
    public string OnPrimaryFixedVariant => "#4A4900";
    // Secondary Fixed
    public string SecondaryFixed => "#E7E4BF";
    public string OnSecondaryFixed => "#1D1D06";
    public string SecondaryFixedDim => "#CBC8A4";
    public string OnSecondaryFixedVariant => "#49482D";
    // Tertiary Fixed
    public string TertiaryFixed => "#C0ECD7";
    public string OnTertiaryFixed => "#002116";
    public string TertiaryFixedDim => "#A4D0BC";
    public string OnTertiaryFixedVariant => "#264E3F";
    // Surface Container
    public string SurfaceContainerLowest => "#0E0E0E";
    public string SurfaceContainerLow => "#1B1B1B";
    public string SurfaceContainer => "#1F1F1F";
    public string SurfaceContainerHigh => "#2A2A2A";
    public string SurfaceContainerHighest => "#353535";
}
