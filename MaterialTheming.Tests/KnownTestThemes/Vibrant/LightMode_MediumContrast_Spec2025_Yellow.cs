using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class LightMode_MediumContrast_Spec2025_Yellow : ITestTheme
{
    public string SourceColor => "#B2B037"; //Yellow
    public bool IsDark => false;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#424100";
    public string OnPrimary => "#DDDA00";
    public string PrimaryContainer => "#7A7800";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#4C3E00";
    public string OnSecondary => "#F6D239";
    public string SecondaryContainer => "#8A7300";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#523C00";
    public string OnTertiary => "#FFCD5B";
    public string TertiaryContainer => "#946F00";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#7D1800";
    public string OnError => "#FFC7BA";
    public string ErrorContainer => "#D53D18";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#FFF6E1";
    public string SurfaceVariant => "#F5DC81";
    public string OnSurface => "#271F00";
    public string OnSurfaceVariant => "#4B3E08";
    public string SurfaceDim => "#EDD374";
    public string SurfaceBright => "#FFF6E1";
    public string SurfaceTint => "#424100";
    // Background
    public string Background => "#FFF6E1";
    public string OnBackground => "#271F00";
    // Outline
    public string Outline => "#695B23";
    public string OutlineVariant => "#86763B";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#130E00";
    public string InverseOnSurface => "#D7C481";
    public string InversePrimary => "#FEFB07";
    // Primary Fixed
    public string PrimaryFixed => "#7A7800";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#6D6B00";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#8A7300";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#7C6600";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#946F00";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#856300";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFF0C4";
    public string SurfaceContainer => "#FFE796";
    public string SurfaceContainerHigh => "#FAE18C";
    public string SurfaceContainerHighest => "#F5DC81";
}
