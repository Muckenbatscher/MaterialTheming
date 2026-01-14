using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class DarkMode_NormalContrast_Spec2021_Blue : ITestTheme
{
    public string SourceColor => "#185FAA"; //Blue
    public bool IsDark => true;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#A3D48D";
    public string OnPrimary => "#103903";
    public string PrimaryContainer => "#275018";
    public string OnPrimaryContainer => "#BFF0A6";
    // Secondary
    public string Secondary => "#EBB8CF";
    public string OnSecondary => "#482537";
    public string SecondaryContainer => "#613B4E";
    public string OnSecondaryContainer => "#FFD8E8";
    // Tertiary
    public string Tertiary => "#B8C4FA";
    public string OnTertiary => "#212E5A";
    public string TertiaryContainer => "#384472";
    public string OnTertiaryContainer => "#DCE1FF";
    // Error
    public string Error => "#FFB4AB";
    public string OnError => "#690005";
    public string ErrorContainer => "#93000A";
    public string OnErrorContainer => "#FFDAD6";
    // Surface
    public string Surface => "#11131A";
    public string SurfaceVariant => "#444654";
    public string OnSurface => "#E2E1EC";
    public string OnSurfaceVariant => "#C4C5D6";
    public string SurfaceDim => "#11131A";
    public string SurfaceBright => "#373941";
    public string SurfaceTint => "#A3D48D";
    // Background
    public string Background => "#11131A";
    public string OnBackground => "#E2E1EC";
    // Outline
    public string Outline => "#8E909F";
    public string OutlineVariant => "#444654";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#E2E1EC";
    public string InverseOnSurface => "#2F3038";
    public string InversePrimary => "#3E692E";
    // Primary Fixed
    public string PrimaryFixed => "#BFF0A6";
    public string OnPrimaryFixed => "#042100";
    public string PrimaryFixedDim => "#A3D48D";
    public string OnPrimaryFixedVariant => "#275018";
    // Secondary Fixed
    public string SecondaryFixed => "#FFD8E8";
    public string OnSecondaryFixed => "#2F1122";
    public string SecondaryFixedDim => "#EBB8CF";
    public string OnSecondaryFixedVariant => "#613B4E";
    // Tertiary Fixed
    public string TertiaryFixed => "#DCE1FF";
    public string OnTertiaryFixed => "#0A1844";
    public string TertiaryFixedDim => "#B8C4FA";
    public string OnTertiaryFixedVariant => "#384472";
    // Surface Container
    public string SurfaceContainerLowest => "#0C0E15";
    public string SurfaceContainerLow => "#1A1B23";
    public string SurfaceContainer => "#1E1F27";
    public string SurfaceContainerHigh => "#282A31";
    public string SurfaceContainerHighest => "#33343C";
}
