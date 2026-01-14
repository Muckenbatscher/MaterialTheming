using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class LightMode_NormalContrast_Spec2021_Green : ITestTheme
{
    public string SourceColor => "#338745"; //Green
    public bool IsDark => false;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#944839";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#FFDAD3";
    public string OnPrimaryContainer => "#763224";
    // Secondary
    public string Secondary => "#3E6656";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#C0ECD7";
    public string OnSecondaryContainer => "#264E3F";
    // Tertiary
    public string Tertiary => "#1A6967";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#A8EFED";
    public string OnTertiaryContainer => "#00504E";
    // Error
    public string Error => "#BA1A1A";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#FFDAD6";
    public string OnErrorContainer => "#93000A";
    // Surface
    public string Surface => "#F3FCF3";
    public string SurfaceVariant => "#D6E7DB";
    public string OnSurface => "#151D19";
    public string OnSurfaceVariant => "#3B4A41";
    public string SurfaceDim => "#D3DCD4";
    public string SurfaceBright => "#F3FCF3";
    public string SurfaceTint => "#944839";
    // Background
    public string Background => "#F3FCF3";
    public string OnBackground => "#151D19";
    // Outline
    public string Outline => "#6B7B71";
    public string OutlineVariant => "#BACBBF";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#2A322D";
    public string InverseOnSurface => "#EAF3EB";
    public string InversePrimary => "#FFB4A5";
    // Primary Fixed
    public string PrimaryFixed => "#FFDAD3";
    public string OnPrimaryFixed => "#3C0701";
    public string PrimaryFixedDim => "#FFB4A5";
    public string OnPrimaryFixedVariant => "#763224";
    // Secondary Fixed
    public string SecondaryFixed => "#C0ECD7";
    public string OnSecondaryFixed => "#002116";
    public string SecondaryFixedDim => "#A4D0BC";
    public string OnSecondaryFixedVariant => "#264E3F";
    // Tertiary Fixed
    public string TertiaryFixed => "#A8EFED";
    public string OnTertiaryFixed => "#00201F";
    public string TertiaryFixedDim => "#8CD3D1";
    public string OnTertiaryFixedVariant => "#00504E";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#EDF6EE";
    public string SurfaceContainer => "#E7F0E8";
    public string SurfaceContainerHigh => "#E1EBE2";
    public string SurfaceContainerHighest => "#DCE5DD";
}
