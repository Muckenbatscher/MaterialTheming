using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class DarkMode_NormalContrast_Spec2021_Yellow : ITestTheme
{
    public string SourceColor => "#B2B037"; //Yellow
    public bool IsDark => true;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#CAC7AD";
    public string OnPrimary => "#32311F";
    public string PrimaryContainer => "#494833";
    public string OnPrimaryContainer => "#E7E3C8";
    // Secondary
    public string Secondary => "#CAC7B6";
    public string OnSecondary => "#323125";
    public string SecondaryContainer => "#48473A";
    public string OnSecondaryContainer => "#E6E3D1";
    // Tertiary
    public string Tertiary => "#CBC8A4";
    public string OnTertiary => "#323218";
    public string TertiaryContainer => "#49482D";
    public string OnTertiaryContainer => "#E7E4BF";
    // Error
    public string Error => "#FFB4AB";
    public string OnError => "#690005";
    public string ErrorContainer => "#93000A";
    public string OnErrorContainer => "#FFDAD6";
    // Surface
    public string Surface => "#141311";
    public string SurfaceVariant => "#484744";
    public string OnSurface => "#E6E2DD";
    public string OnSurfaceVariant => "#C9C6C2";
    public string SurfaceDim => "#141311";
    public string SurfaceBright => "#3A3936";
    public string SurfaceTint => "#CAC7AD";
    // Background
    public string Background => "#141311";
    public string OnBackground => "#E6E2DD";
    // Outline
    public string Outline => "#93908C";
    public string OutlineVariant => "#484744";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#E6E2DD";
    public string InverseOnSurface => "#31302D";
    public string InversePrimary => "#615F4A";
    // Primary Fixed
    public string PrimaryFixed => "#E7E3C8";
    public string OnPrimaryFixed => "#1D1C0B";
    public string PrimaryFixedDim => "#CAC7AD";
    public string OnPrimaryFixedVariant => "#494833";
    // Secondary Fixed
    public string SecondaryFixed => "#E6E3D1";
    public string OnSecondaryFixed => "#1D1C11";
    public string SecondaryFixedDim => "#CAC7B6";
    public string OnSecondaryFixedVariant => "#48473A";
    // Tertiary Fixed
    public string TertiaryFixed => "#E7E4BF";
    public string OnTertiaryFixed => "#1D1D06";
    public string TertiaryFixedDim => "#CBC8A4";
    public string OnTertiaryFixedVariant => "#49482D";
    // Surface Container
    public string SurfaceContainerLowest => "#0F0E0C";
    public string SurfaceContainerLow => "#1C1C19";
    public string SurfaceContainer => "#20201D";
    public string SurfaceContainerHigh => "#2B2A27";
    public string SurfaceContainerHighest => "#363532";
}
