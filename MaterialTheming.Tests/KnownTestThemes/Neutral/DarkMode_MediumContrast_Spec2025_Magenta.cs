using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class DarkMode_MediumContrast_Spec2025_Magenta : ITestTheme
{
    public string SourceColor => "#E85DAE"; //Magenta
    public bool IsDark => true;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#D4C2C8";
    public string OnPrimary => "#3F3338";
    public string PrimaryContainer => "#7F7176";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#C0B6B9";
    public string OnSecondary => "#302B2D";
    public string SecondaryContainer => "#7A7275";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#FEEFFF";
    public string OnTertiary => "#5D4B65";
    public string TertiaryContainer => "#F6DDFD";
    public string OnTertiaryContainer => "#55435C";
    // Error
    public string Error => "#FF9DA8";
    public string OnError => "#5B0A1E";
    public string ErrorContainer => "#B95463";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#0F0E0E";
    public string SurfaceVariant => "#292526";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#BFB7B8";
    public string SurfaceDim => "#0F0E0E";
    public string SurfaceBright => "#302B2D";
    public string SurfaceTint => "#D4C2C8";
    // Background
    public string Background => "#0F0E0E";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#999293";
    public string OutlineVariant => "#7A7475";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#FEF8F8";
    public string InverseOnSurface => "#3A3738";
    public string InversePrimary => "#5F5157";
    // Primary Fixed
    public string PrimaryFixed => "#F1DEE4";
    public string OnPrimaryFixed => "#271D21";
    public string PrimaryFixedDim => "#E2D0D6";
    public string OnPrimaryFixedVariant => "#483C41";
    // Secondary Fixed
    public string SecondaryFixed => "#EBE0E2";
    public string OnSecondaryFixed => "#231E20";
    public string SecondaryFixedDim => "#DCD2D4";
    public string OnSecondaryFixedVariant => "#443E40";
    // Tertiary Fixed
    public string TertiaryFixed => "#F6DDFD";
    public string OnTertiaryFixed => "#2B1C33";
    public string TertiaryFixedDim => "#E7CFEE";
    public string OnTertiaryFixedVariant => "#4C3B53";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#151313";
    public string SurfaceContainer => "#1C191A";
    public string SurfaceContainerHigh => "#221F20";
    public string SurfaceContainerHighest => "#292526";
}
