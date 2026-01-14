using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class DarkMode_MediumContrast_Spec2021_Magenta : ITestTheme
{
    public string SourceColor => "#E85DAE"; //Magenta
    public bool IsDark => true;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#FFCFE4";
    public string OnPrimary => "#4E0035";
    public string PrimaryContainer => "#FF3DB9";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#FFD0DB";
    public string OnSecondary => "#3E1A25";
    public string SecondaryContainer => "#B68390";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#FFD1D3";
    public string OnTertiary => "#45151A";
    public string TertiaryContainer => "#C57D81";
    public string OnTertiaryContainer => "#000000";
    // Error
    public string Error => "#FFD2CC";
    public string OnError => "#540003";
    public string ErrorContainer => "#FF5449";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#1C1016";
    public string SurfaceVariant => "#54424A";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#F0D5E0";
    public string SurfaceDim => "#1C1016";
    public string SurfaceBright => "#504047";
    public string SurfaceTint => "#FFAFD6";
    // Background
    public string Background => "#1C1016";
    public string OnBackground => "#F4DDE5";
    // Outline
    public string Outline => "#C4ABB5";
    public string OutlineVariant => "#A18A94";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#F4DDE5";
    public string InverseOnSurface => "#34262C";
    public string InversePrimary => "#8C0062";
    // Primary Fixed
    public string PrimaryFixed => "#FFD8E8";
    public string OnPrimaryFixed => "#2A001A";
    public string PrimaryFixedDim => "#FFAFD6";
    public string OnPrimaryFixedVariant => "#6C004A";
    // Secondary Fixed
    public string SecondaryFixed => "#FFD9E1";
    public string OnSecondaryFixed => "#250611";
    public string SecondaryFixedDim => "#F0B7C5";
    public string OnSecondaryFixedVariant => "#512A36";
    // Tertiary Fixed
    public string TertiaryFixed => "#FFDADA";
    public string OnTertiaryFixed => "#2A0208";
    public string TertiaryFixedDim => "#FFB3B6";
    public string OnTertiaryFixedVariant => "#5A252A";
    // Surface Container
    public string SurfaceContainerLowest => "#0E0509";
    public string SurfaceContainerLow => "#271A20";
    public string SurfaceContainer => "#32242A";
    public string SurfaceContainerHigh => "#3D2F35";
    public string SurfaceContainerHighest => "#493A40";
}
