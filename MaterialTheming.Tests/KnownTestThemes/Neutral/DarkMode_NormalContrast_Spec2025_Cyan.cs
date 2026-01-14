using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class DarkMode_NormalContrast_Spec2025_Cyan : ITestTheme
{
    public string SourceColor => "#00BCD1"; //Cyan
    public bool IsDark => true;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#BFC8CA";
    public string OnPrimary => "#394244";
    public string PrimaryContainer => "#3F484A";
    public string OnPrimaryContainer => "#C8D2D4";
    // Secondary
    public string Secondary => "#9B9E9F";
    public string OnSecondary => "#1D2121";
    public string SecondaryContainer => "#393C3D";
    public string OnSecondaryContainer => "#BDC0C0";
    // Tertiary
    public string Tertiary => "#EFF8FF";
    public string OnTertiary => "#476170";
    public string TertiaryContainer => "#D0ECFF";
    public string OnTertiaryContainer => "#3E5868";
    // Error
    public string Error => "#EE7D77";
    public string OnError => "#490106";
    public string ErrorContainer => "#7F2927";
    public string OnErrorContainer => "#FF9993";
    // Surface
    public string Surface => "#0E0E0E";
    public string SurfaceVariant => "#242627";
    public string OnSurface => "#E5E5E6";
    public string OnSurfaceVariant => "#AAABAB";
    public string SurfaceDim => "#0E0E0E";
    public string SurfaceBright => "#2A2D2D";
    public string SurfaceTint => "#BFC8CA";
    // Background
    public string Background => "#0E0E0E";
    public string OnBackground => "#E5E5E6";
    // Outline
    public string Outline => "#747676";
    public string OutlineVariant => "#464849";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#FBF9F8";
    public string InverseOnSurface => "#555555";
    public string InversePrimary => "#576162";
    // Primary Fixed
    public string PrimaryFixed => "#DBE4E6";
    public string OnPrimaryFixed => "#384143";
    public string PrimaryFixedDim => "#CDD6D8";
    public string OnPrimaryFixedVariant => "#545D5F";
    // Secondary Fixed
    public string SecondaryFixed => "#E1E3E3";
    public string OnSecondaryFixed => "#3C4041";
    public string SecondaryFixedDim => "#D2D5D5";
    public string OnSecondaryFixedVariant => "#595C5D";
    // Tertiary Fixed
    public string TertiaryFixed => "#D0ECFF";
    public string OnTertiaryFixed => "#2C4655";
    public string TertiaryFixedDim => "#C2DEF0";
    public string OnTertiaryFixedVariant => "#486272";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#121414";
    public string SurfaceContainer => "#181A1A";
    public string SurfaceContainerHigh => "#1E2020";
    public string SurfaceContainerHighest => "#242627";
}
