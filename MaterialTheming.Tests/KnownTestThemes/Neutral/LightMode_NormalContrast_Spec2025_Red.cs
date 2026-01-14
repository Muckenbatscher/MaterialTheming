using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class LightMode_NormalContrast_Spec2025_Red : ITestTheme
{
    public string SourceColor => "#D2463D"; //Red
    public bool IsDark => false;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#6B5A58";
    public string OnPrimary => "#FFF6F4";
    public string PrimaryContainer => "#F5DDDA";
    public string OnPrimaryContainer => "#5E4E4C";
    // Secondary
    public string Secondary => "#665D5C";
    public string OnSecondary => "#FFF7F6";
    public string SecondaryContainer => "#EDE0DE";
    public string OnSecondaryContainer => "#58504F";
    // Tertiary
    public string Tertiary => "#785564";
    public string OnTertiary => "#FFF7F8";
    public string TertiaryContainer => "#F5C8DA";
    public string OnTertiaryContainer => "#60404E";
    // Error
    public string Error => "#9E3F4E";
    public string OnError => "#FFF7F7";
    public string ErrorContainer => "#FF8B9A";
    public string OnErrorContainer => "#782232";
    // Surface
    public string Surface => "#FFF8F7";
    public string SurfaceVariant => "#EBE0DF";
    public string OnSurface => "#373130";
    public string OnSurfaceVariant => "#655D5C";
    public string SurfaceDim => "#E3D7D6";
    public string SurfaceBright => "#FFF8F7";
    public string SurfaceTint => "#6B5A58";
    // Background
    public string Background => "#FFF8F7";
    public string OnBackground => "#373130";
    // Outline
    public string Outline => "#817978";
    public string OutlineVariant => "#B9B0AE";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#100E0D";
    public string InverseOnSurface => "#A19C9B";
    public string InversePrimary => "#FBE3E0";
    // Primary Fixed
    public string PrimaryFixed => "#F5DDDA";
    public string OnPrimaryFixed => "#4B3C3A";
    public string PrimaryFixedDim => "#E6CFCC";
    public string OnPrimaryFixedVariant => "#685856";
    // Secondary Fixed
    public string SecondaryFixed => "#EDE0DE";
    public string OnSecondaryFixed => "#453D3D";
    public string SecondaryFixedDim => "#DED2D0";
    public string OnSecondaryFixedVariant => "#625958";
    // Tertiary Fixed
    public string TertiaryFixed => "#F5C8DA";
    public string OnTertiaryFixed => "#4B2D3B";
    public string TertiaryFixedDim => "#E7BBCC";
    public string OnTertiaryFixedVariant => "#6A4957";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FAF2F1";
    public string SurfaceContainer => "#F5ECEB";
    public string SurfaceContainerHigh => "#F0E6E5";
    public string SurfaceContainerHighest => "#EBE0DF";
}
