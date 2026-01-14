using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class DarkMode_MediumContrast_Spec2025_Blue : ITestTheme
{
    public string SourceColor => "#185FAA"; //Blue
    public bool IsDark => true;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#C0C7D5";
    public string OnPrimary => "#303642";
    public string PrimaryContainer => "#6E7582";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#B7B8BF";
    public string OnSecondary => "#2A2C31";
    public string SecondaryContainer => "#73747A";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#EBE9FF";
    public string OnTertiary => "#4A4B65";
    public string TertiaryContainer => "#DBDAFB";
    public string OnTertiaryContainer => "#41425C";
    // Error
    public string Error => "#FF9F99";
    public string OnError => "#5B0D10";
    public string ErrorContainer => "#BB5551";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#0E0E0F";
    public string SurfaceVariant => "#252628";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#B9B8BB";
    public string SurfaceDim => "#0E0E0F";
    public string SurfaceBright => "#2B2C2F";
    public string SurfaceTint => "#C0C7D5";
    // Background
    public string Background => "#0E0E0F";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#949396";
    public string OutlineVariant => "#757578";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#FCF8F9";
    public string InverseOnSurface => "#383839";
    public string InversePrimary => "#4F5562";
    // Primary Fixed
    public string PrimaryFixed => "#DCE2F2";
    public string OnPrimaryFixed => "#19202B";
    public string PrimaryFixedDim => "#CED4E3";
    public string OnPrimaryFixedVariant => "#39404B";
    // Secondary Fixed
    public string SecondaryFixed => "#E1E2E9";
    public string OnSecondaryFixed => "#1D1F24";
    public string SecondaryFixedDim => "#D3D4DA";
    public string OnSecondaryFixedVariant => "#3D3F45";
    // Tertiary Fixed
    public string TertiaryFixed => "#DBDAFB";
    public string OnTertiaryFixed => "#171830";
    public string TertiaryFixedDim => "#CDCCEC";
    public string OnTertiaryFixedVariant => "#393A53";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#131314";
    public string SurfaceContainer => "#19191B";
    public string SurfaceContainerHigh => "#1F1F21";
    public string SurfaceContainerHighest => "#252628";
}
