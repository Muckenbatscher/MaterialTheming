using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class LightMode_MediumContrast_Spec2021_Yellow : ITestTheme
{
    public string SourceColor => "#B2B037"; //Yellow
    public bool IsDark => false;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#393800";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#717025";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#38371D";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#706E50";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#133D2F";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#4C7564";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#740006";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#CF2C27";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#FDF9EC";
    public string SurfaceVariant => "#E6E3D1";
    public string OnSurface => "#12110A";
    public string OnSurfaceVariant => "#37372A";
    public string SurfaceDim => "#CAC7BA";
    public string SurfaceBright => "#FDF9EC";
    public string SurfaceTint => "#626117";
    // Background
    public string Background => "#FDF9EC";
    public string OnBackground => "#1C1C14";
    // Outline
    public string Outline => "#545345";
    public string OutlineVariant => "#6F6E5F";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#313128";
    public string InverseOnSurface => "#F4F1E3";
    public string InversePrimary => "#CDCA75";
    // Primary Fixed
    public string PrimaryFixed => "#717025";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#58570D";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#706E50";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#57563A";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#4C7564";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#345D4D";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F7F4E6";
    public string SurfaceContainer => "#ECE8DB";
    public string SurfaceContainerHigh => "#E0DDD0";
    public string SurfaceContainerHighest => "#D5D2C5";
}
