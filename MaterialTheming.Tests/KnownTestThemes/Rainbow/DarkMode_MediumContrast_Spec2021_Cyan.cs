using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Rainbow;

internal class DarkMode_MediumContrast_Spec2021_Cyan : ITestTheme
{
    public string SourceColor => "#00BCD1"; //Cyan
    public bool IsDark => true;
    public Variant Variant => Variant.Rainbow;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#7CECFF";
    public string OnPrimary => "#002A30";
    public string PrimaryContainer => "#009FB1";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#C7E1E6";
    public string OnSecondary => "#10292D";
    public string SecondaryContainer => "#7C959A";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#D1DBFF";
    public string OnTertiary => "#192541";
    public string TertiaryContainer => "#8590B2";
    public string OnTertiaryContainer => "#000000";
    // Error
    public string Error => "#FFD2CC";
    public string OnError => "#540003";
    public string ErrorContainer => "#FF5449";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#131313";
    public string SurfaceVariant => "#474747";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#DCDCDC";
    public string SurfaceDim => "#131313";
    public string SurfaceBright => "#444444";
    public string SurfaceTint => "#50D8EC";
    // Background
    public string Background => "#131313";
    public string OnBackground => "#E2E2E2";
    // Outline
    public string Outline => "#B2B2B2";
    public string OutlineVariant => "#909090";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#E2E2E2";
    public string InverseOnSurface => "#2A2A2A";
    public string InversePrimary => "#00505A";
    // Primary Fixed
    public string PrimaryFixed => "#9AF0FF";
    public string OnPrimaryFixed => "#001417";
    public string PrimaryFixedDim => "#50D8EC";
    public string OnPrimaryFixedVariant => "#003C44";
    // Secondary Fixed
    public string SecondaryFixed => "#CDE7EC";
    public string OnSecondaryFixed => "#001417";
    public string SecondaryFixedDim => "#B1CBD0";
    public string OnSecondaryFixedVariant => "#223A3E";
    // Tertiary Fixed
    public string TertiaryFixed => "#DAE2FF";
    public string OnTertiaryFixed => "#04102C";
    public string TertiaryFixedDim => "#BBC6EA";
    public string OnTertiaryFixedVariant => "#2A3553";
    // Surface Container
    public string SurfaceContainerLowest => "#070707";
    public string SurfaceContainerLow => "#1D1D1D";
    public string SurfaceContainer => "#282828";
    public string SurfaceContainerHigh => "#323232";
    public string SurfaceContainerHighest => "#3E3E3E";
}
