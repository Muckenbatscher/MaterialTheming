using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class DarkMode_MediumContrast_Spec2021_Cyan : ITestTheme
{
    public string SourceColor => "#00BCD1"; //Cyan
    public bool IsDark => true;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#CEDFE3";
    public string OnPrimary => "#18282B";
    public string PrimaryContainer => "#839497";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#D4DEE0";
    public string OnSecondary => "#1E2729";
    public string SecondaryContainer => "#899294";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#C7E1E6";
    public string OnTertiary => "#10292D";
    public string TertiaryContainer => "#7C959A";
    public string OnTertiaryContainer => "#000000";
    // Error
    public string Error => "#FFD2CC";
    public string OnError => "#540003";
    public string ErrorContainer => "#FF5449";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#121414";
    public string SurfaceVariant => "#464747";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#DDDCDC";
    public string SurfaceDim => "#121414";
    public string SurfaceBright => "#444445";
    public string SurfaceTint => "#B8CACD";
    // Background
    public string Background => "#121414";
    public string OnBackground => "#E3E2E2";
    // Outline
    public string Outline => "#B2B2B2";
    public string OutlineVariant => "#909090";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#E3E2E2";
    public string InverseOnSurface => "#292A2A";
    public string InversePrimary => "#3B4B4E";
    // Primary Fixed
    public string PrimaryFixed => "#D4E6E9";
    public string OnPrimaryFixed => "#041316";
    public string PrimaryFixedDim => "#B8CACD";
    public string OnPrimaryFixedVariant => "#29393C";
    // Secondary Fixed
    public string SecondaryFixed => "#DBE4E6";
    public string OnSecondaryFixed => "#0A1314";
    public string SecondaryFixedDim => "#BFC8CA";
    public string OnSecondaryFixedVariant => "#2F3839";
    // Tertiary Fixed
    public string TertiaryFixed => "#CDE7EC";
    public string OnTertiaryFixed => "#001417";
    public string TertiaryFixedDim => "#B1CBD0";
    public string OnTertiaryFixedVariant => "#223A3E";
    // Surface Container
    public string SurfaceContainerLowest => "#060808";
    public string SurfaceContainerLow => "#1D1E1E";
    public string SurfaceContainer => "#272828";
    public string SurfaceContainerHigh => "#323333";
    public string SurfaceContainerHighest => "#3D3E3E";
}
