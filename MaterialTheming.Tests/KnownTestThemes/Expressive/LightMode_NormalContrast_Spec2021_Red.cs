using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class LightMode_NormalContrast_Spec2021_Red : ITestTheme
{
    public string SourceColor => "#D2463D"; //Red
    public bool IsDark => false;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#3D5E98";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#D7E2FF";
    public string OnPrimaryContainer => "#22467F";
    // Secondary
    public string Secondary => "#5B6237";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#E0E7B1";
    public string OnSecondaryContainer => "#444A22";
    // Tertiary
    public string Tertiary => "#42673D";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#C3EEB8";
    public string OnTertiaryContainer => "#2A4F27";
    // Error
    public string Error => "#BA1A1A";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#FFDAD6";
    public string OnErrorContainer => "#93000A";
    // Surface
    public string Surface => "#FFF8F6";
    public string SurfaceVariant => "#FDDCD0";
    public string OnSurface => "#251914";
    public string OnSurfaceVariant => "#58423A";
    public string SurfaceDim => "#ECD5CE";
    public string SurfaceBright => "#FFF8F6";
    public string SurfaceTint => "#3D5E98";
    // Background
    public string Background => "#FFF8F6";
    public string OnBackground => "#251914";
    // Outline
    public string Outline => "#8C7168";
    public string OutlineVariant => "#DFC0B5";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#3B2D28";
    public string InverseOnSurface => "#FFEDE7";
    public string InversePrimary => "#ACC7FF";
    // Primary Fixed
    public string PrimaryFixed => "#D7E2FF";
    public string OnPrimaryFixed => "#001A40";
    public string PrimaryFixedDim => "#ACC7FF";
    public string OnPrimaryFixedVariant => "#22467F";
    // Secondary Fixed
    public string SecondaryFixed => "#E0E7B1";
    public string OnSecondaryFixed => "#191E00";
    public string SecondaryFixedDim => "#C4CB97";
    public string OnSecondaryFixedVariant => "#444A22";
    // Tertiary Fixed
    public string TertiaryFixed => "#C3EEB8";
    public string OnTertiaryFixed => "#002203";
    public string TertiaryFixedDim => "#A7D29E";
    public string OnTertiaryFixedVariant => "#2A4F27";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFF1EC";
    public string SurfaceContainer => "#FFE9E2";
    public string SurfaceContainerHigh => "#FBE3DC";
    public string SurfaceContainerHighest => "#F5DED6";
}
