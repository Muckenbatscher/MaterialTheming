using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class DarkMode_NormalContrast_Spec2021_Yellow : ITestTheme
{
    public string SourceColor => "#B2B037"; //Yellow
    public bool IsDark => true;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#CDCA75";
    public string OnPrimary => "#333200";
    public string PrimaryContainer => "#4A4900";
    public string OnPrimaryContainer => "#E9E78E";
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
    public string Surface => "#14140C";
    public string SurfaceVariant => "#48473A";
    public string OnSurface => "#E6E2D5";
    public string OnSurfaceVariant => "#CAC7B6";
    public string SurfaceDim => "#14140C";
    public string SurfaceBright => "#3A3930";
    public string SurfaceTint => "#CDCA75";
    // Background
    public string Background => "#14140C";
    public string OnBackground => "#E6E2D5";
    // Outline
    public string Outline => "#939181";
    public string OutlineVariant => "#48473A";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#E6E2D5";
    public string InverseOnSurface => "#313128";
    public string InversePrimary => "#626117";
    // Primary Fixed
    public string PrimaryFixed => "#E9E78E";
    public string OnPrimaryFixed => "#1D1D00";
    public string PrimaryFixedDim => "#CDCA75";
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
    public string SurfaceContainerLowest => "#0F0E07";
    public string SurfaceContainerLow => "#1C1C14";
    public string SurfaceContainer => "#202018";
    public string SurfaceContainerHigh => "#2B2A22";
    public string SurfaceContainerHighest => "#36352C";
}
