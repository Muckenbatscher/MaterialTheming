using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class LightMode_MediumContrast_Spec2025_Magenta : ITestTheme
{
    public string SourceColor => "#E85DAE"; //Magenta
    public bool IsDark => false;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#4C3F45";
    public string OnPrimary => "#E8D5DB";
    public string PrimaryContainer => "#7F7176";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#484143";
    public string OnSecondary => "#E2D7D9";
    public string SecondaryContainer => "#7A7275";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#4E3D55";
    public string OnTertiary => "#EAD2F1";
    public string TertiaryContainer => "#826E89";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#7A2333";
    public string OnError => "#FFCDD1";
    public string ErrorContainer => "#B95463";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#FEF8F8";
    public string SurfaceVariant => "#E9E0E2";
    public string OnSurface => "#272324";
    public string OnSurfaceVariant => "#474143";
    public string SurfaceDim => "#E1D8DA";
    public string SurfaceBright => "#FEF8F8";
    public string SurfaceTint => "#4C3F45";
    // Background
    public string Background => "#FEF8F8";
    public string OnBackground => "#272324";
    // Outline
    public string Outline => "#635D5F";
    public string OutlineVariant => "#80797B";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#0F0E0E";
    public string InverseOnSurface => "#C9C3C4";
    public string InversePrimary => "#F6E3EA";
    // Primary Fixed
    public string PrimaryFixed => "#7F7176";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#73646A";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#7A7275";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#6E6668";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#826E89";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#75617C";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F9F2F2";
    public string SurfaceContainer => "#F4ECED";
    public string SurfaceContainerHigh => "#EFE6E7";
    public string SurfaceContainerHighest => "#E9E0E2";
}
