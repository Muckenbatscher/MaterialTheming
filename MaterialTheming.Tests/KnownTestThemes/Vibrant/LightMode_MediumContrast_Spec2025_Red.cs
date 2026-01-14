using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class LightMode_MediumContrast_Spec2025_Red : ITestTheme
{
    public string SourceColor => "#D2463D"; //Red
    public bool IsDark => false;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#850009";
    public string OnPrimary => "#FFC7C0";
    public string PrimaryContainer => "#D24038";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#7A1930";
    public string OnSecondary => "#FFC6CB";
    public string SecondaryContainer => "#C04F63";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#5A2286";
    public string OnTertiary => "#E9C8FF";
    public string TertiaryContainer => "#935CC1";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#83002A";
    public string OnError => "#FFC6CA";
    public string ErrorContainer => "#D73357";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#FFF4F4";
    public string SurfaceVariant => "#FFD2D6";
    public string OnSurface => "#3A1219";
    public string OnSurfaceVariant => "#613138";
    public string SurfaceDim => "#FFC6CC";
    public string SurfaceBright => "#FFF4F4";
    public string SurfaceTint => "#850009";
    // Background
    public string Background => "#FFF4F4";
    public string OnBackground => "#3A1219";
    // Outline
    public string Outline => "#824C53";
    public string OutlineVariant => "#A1676E";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#240209";
    public string InverseOnSurface => "#F8B3BA";
    public string InversePrimary => "#FF6F63";
    // Primary Fixed
    public string PrimaryFixed => "#D24038";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#C0332D";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#C04F63";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#B04257";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#935CC1";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#864FB3";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFECED";
    public string SurfaceContainer => "#FFE1E3";
    public string SurfaceContainerHigh => "#FFD9DC";
    public string SurfaceContainerHighest => "#FFD2D6";
}
