using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class DarkMode_HighContrast_Spec2025_Green : ITestTheme
{
    public string SourceColor => "#338745"; //Green
    public bool IsDark => true;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#E0E8DC";
    public string OnPrimary => "#272E26";
    public string PrimaryContainer => "#9EA69B";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#E5E6E0";
    public string OnSecondary => "#2A2D29";
    public string SecondaryContainer => "#A2A49F";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#E9FFED";
    public string OnTertiary => "#233E2D";
    public string TertiaryContainer => "#D3F3DB";
    public string OnTertiaryContainer => "#1A3525";
    // Error
    public string Error => "#FFDED7";
    public string OnError => "#591001";
    public string ErrorContainer => "#F48469";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#0E0E0D";
    public string SurfaceVariant => "#242624";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#E6E6E1";
    public string SurfaceDim => "#0E0E0D";
    public string SurfaceBright => "#2B2D2A";
    public string SurfaceTint => "#E0E8DC";
    // Background
    public string Background => "#0E0E0D";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#B9B9B5";
    public string OutlineVariant => "#A3A4A0";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#FBF9F6";
    public string InverseOnSurface => "#000000";
    public string InversePrimary => "#333A32";
    // Primary Fixed
    public string PrimaryFixed => "#DDE5D9";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#CFD7CB";
    public string OnPrimaryFixedVariant => "#1A211A";
    // Secondary Fixed
    public string SecondaryFixed => "#E2E3DD";
    public string OnSecondaryFixed => "#000000";
    public string SecondaryFixedDim => "#D4D5CF";
    public string OnSecondaryFixedVariant => "#1E201D";
    // Tertiary Fixed
    public string TertiaryFixed => "#DBFCE3";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#CDEDD5";
    public string OnTertiaryFixedVariant => "#163122";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#131412";
    public string SurfaceContainer => "#191A18";
    public string SurfaceContainerHigh => "#1F201E";
    public string SurfaceContainerHighest => "#242624";
}
