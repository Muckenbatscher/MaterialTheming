using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Content;

internal class DarkMode_NormalContrast_Spec2025_Yellow : ITestTheme
{
    public string SourceColor => "#B2B037"; //Yellow
    public bool IsDark => true;
    public Variant Variant => Variant.Content;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#CECC50";
    public string OnPrimary => "#333200";
    public string PrimaryContainer => "#B2B037";
    public string OnPrimaryContainer => "#434200";
    // Secondary
    public string Secondary => "#CCC990";
    public string OnSecondary => "#333207";
    public string SecondaryContainer => "#49491C";
    public string OnSecondaryContainer => "#BAB880";
    // Tertiary
    public string Tertiary => "#91D882";
    public string OnTertiary => "#003A02";
    public string TertiaryContainer => "#77BC69";
    public string OnTertiaryContainer => "#014B04";
    // Error
    public string Error => "#FFB4AB";
    public string OnError => "#690005";
    public string ErrorContainer => "#93000A";
    public string OnErrorContainer => "#FFDAD6";
    // Surface
    public string Surface => "#14140C";
    public string SurfaceVariant => "#484736";
    public string OnSurface => "#E6E3D5";
    public string OnSurfaceVariant => "#CAC7B1";
    public string SurfaceDim => "#14140C";
    public string SurfaceBright => "#3A3930";
    public string SurfaceTint => "#CECC50";
    // Background
    public string Background => "#14140C";
    public string OnBackground => "#E6E3D5";
    // Outline
    public string Outline => "#94917D";
    public string OutlineVariant => "#484736";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#E6E3D5";
    public string InverseOnSurface => "#323127";
    public string InversePrimary => "#636100";
    // Primary Fixed
    public string PrimaryFixed => "#EAE869";
    public string OnPrimaryFixed => "#1D1D00";
    public string PrimaryFixedDim => "#CECC50";
    public string OnPrimaryFixedVariant => "#4A4900";
    // Secondary Fixed
    public string SecondaryFixed => "#E8E5AA";
    public string OnSecondaryFixed => "#1D1D00";
    public string SecondaryFixedDim => "#CCC990";
    public string OnSecondaryFixedVariant => "#49491C";
    // Tertiary Fixed
    public string TertiaryFixed => "#ACF59B";
    public string OnTertiaryFixed => "#002201";
    public string TertiaryFixedDim => "#91D881";
    public string OnTertiaryFixedVariant => "#0D530C";
    // Surface Container
    public string SurfaceContainerLowest => "#0F0F07";
    public string SurfaceContainerLow => "#1C1C14";
    public string SurfaceContainer => "#202017";
    public string SurfaceContainerHigh => "#2B2A21";
    public string SurfaceContainerHighest => "#36352C";
}
