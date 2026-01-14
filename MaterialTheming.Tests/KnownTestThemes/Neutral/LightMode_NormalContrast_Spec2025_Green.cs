using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class LightMode_NormalContrast_Spec2025_Green : ITestTheme
{
    public string SourceColor => "#338745"; //Green
    public bool IsDark => false;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#596057";
    public string OnPrimary => "#F3FAEE";
    public string PrimaryContainer => "#DDE5D9";
    public string OnPrimaryContainer => "#4D544B";
    // Secondary
    public string Secondary => "#5D605B";
    public string OnSecondary => "#F8F9F4";
    public string SecondaryContainer => "#E2E3DD";
    public string OnSecondaryContainer => "#50524E";
    // Tertiary
    public string Tertiary => "#496553";
    public string OnTertiary => "#E7FFEC";
    public string TertiaryContainer => "#DBFCE3";
    public string OnTertiaryContainer => "#466250";
    // Error
    public string Error => "#9E422C";
    public string OnError => "#FFF7F6";
    public string ErrorContainer => "#FE8B70";
    public string OnErrorContainer => "#742410";
    // Surface
    public string Surface => "#FBF9F6";
    public string SurfaceVariant => "#E3E3DE";
    public string OnSurface => "#313330";
    public string OnSurfaceVariant => "#5E5F5C";
    public string SurfaceDim => "#DADAD5";
    public string SurfaceBright => "#FBF9F6";
    public string SurfaceTint => "#596057";
    // Background
    public string Background => "#FBF9F6";
    public string OnBackground => "#313330";
    // Outline
    public string Outline => "#7A7B77";
    public string OutlineVariant => "#B2B2AE";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#0E0E0D";
    public string InverseOnSurface => "#9E9D9B";
    public string InversePrimary => "#F4FCF0";
    // Primary Fixed
    public string PrimaryFixed => "#DDE5D9";
    public string OnPrimaryFixed => "#3A4139";
    public string PrimaryFixedDim => "#CFD7CB";
    public string OnPrimaryFixedVariant => "#565D55";
    // Secondary Fixed
    public string SecondaryFixed => "#E2E3DD";
    public string OnSecondaryFixed => "#3D403C";
    public string SecondaryFixedDim => "#D4D5CF";
    public string OnSecondaryFixedVariant => "#5A5C58";
    // Tertiary Fixed
    public string TertiaryFixed => "#DBFCE3";
    public string OnTertiaryFixed => "#34503E";
    public string TertiaryFixedDim => "#CDEDD5";
    public string OnTertiaryFixedVariant => "#506D5A";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F5F3F0";
    public string SurfaceContainer => "#EFEEEA";
    public string SurfaceContainerHigh => "#E9E8E4";
    public string SurfaceContainerHighest => "#E3E3DE";
}
