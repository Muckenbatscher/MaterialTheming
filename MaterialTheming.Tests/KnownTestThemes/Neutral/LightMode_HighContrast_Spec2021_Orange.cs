using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class LightMode_HighContrast_Spec2021_Orange : ITestTheme
{
    public string SourceColor => "#D77837"; //Orange
    public bool IsDark => false;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#3A281D";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#5A4539";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#362A23";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#55463E";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#3E2718";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#5E4333";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#600004";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#98000A";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#FFF8F5";
    public string SurfaceVariant => "#E9E1DE";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#000000";
    public string SurfaceDim => "#BEB7B5";
    public string SurfaceBright => "#FFF8F5";
    public string SurfaceTint => "#705A4D";
    // Background
    public string Background => "#FFF8F5";
    public string OnBackground => "#1E1B19";
    // Outline
    public string Outline => "#2F2B2A";
    public string OutlineVariant => "#4D4846";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#33302E";
    public string InverseOnSurface => "#FFFFFF";
    public string InversePrimary => "#DEC1B1";
    // Primary Fixed
    public string PrimaryFixed => "#5A4539";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#412F24";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#55463E";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#3D3029";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#5E4333";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#452D1E";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F7EFEC";
    public string SurfaceContainer => "#E9E1DE";
    public string SurfaceContainerHigh => "#DAD3D0";
    public string SurfaceContainerHighest => "#CCC5C2";
}
