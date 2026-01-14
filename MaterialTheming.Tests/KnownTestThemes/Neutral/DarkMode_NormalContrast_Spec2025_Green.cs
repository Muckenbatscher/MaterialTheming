using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class DarkMode_NormalContrast_Spec2025_Green : ITestTheme
{
    public string SourceColor => "#338745"; //Green
    public bool IsDark => true;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#C1C9BE";
    public string OnPrimary => "#3B423A";
    public string PrimaryContainer => "#424940";
    public string OnPrimaryContainer => "#CBD2C7";
    // Secondary
    public string Secondary => "#9D9E99";
    public string OnSecondary => "#1E211D";
    public string SecondaryContainer => "#3A3C38";
    public string OnSecondaryContainer => "#BEC0BA";
    // Tertiary
    public string Tertiary => "#E9FFED";
    public string OnTertiary => "#496553";
    public string TertiaryContainer => "#D3F3DB";
    public string OnTertiaryContainer => "#415D4B";
    // Error
    public string Error => "#ED7F64";
    public string OnError => "#450900";
    public string ErrorContainer => "#7E2B17";
    public string OnErrorContainer => "#FF9B82";
    // Surface
    public string Surface => "#0E0E0D";
    public string SurfaceVariant => "#242624";
    public string OnSurface => "#E6E6E1";
    public string OnSurfaceVariant => "#ABABA7";
    public string SurfaceDim => "#0E0E0D";
    public string SurfaceBright => "#2B2D2A";
    public string SurfaceTint => "#C1C9BE";
    // Background
    public string Background => "#0E0E0D";
    public string OnBackground => "#E6E6E1";
    // Outline
    public string Outline => "#757672";
    public string OutlineVariant => "#474845";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#FBF9F6";
    public string InverseOnSurface => "#555553";
    public string InversePrimary => "#5A6158";
    // Primary Fixed
    public string PrimaryFixed => "#DDE5D9";
    public string OnPrimaryFixed => "#3A4139";
    public string PrimaryFixedDim => "#CFD7CB";
    public string OnPrimaryFixedVariant => "#565D55";
    // Secondary Fixed
    public string SecondaryFixed => "#E2E3DD";
    public string OnSecondaryFixed => "#3D403C";
    public string SecondaryFixedDim => "#D4D5CF";
    public string OnSecondaryFixedVariant => "#5A5C58";
    // Tertiary Fixed
    public string TertiaryFixed => "#DBFCE3";
    public string OnTertiaryFixed => "#34503E";
    public string TertiaryFixedDim => "#CDEDD5";
    public string OnTertiaryFixedVariant => "#506D5A";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#131412";
    public string SurfaceContainer => "#191A18";
    public string SurfaceContainerHigh => "#1F201E";
    public string SurfaceContainerHighest => "#242624";
}
