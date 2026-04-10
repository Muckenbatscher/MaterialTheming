namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class LightMode_HighContrast_Spec2026_Yellow : ITestTheme
{
    public string SourceColor => "#B2B037"; //Yellow
    public bool IsDark => false;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#2B2B1F";
    public string OnPrimary => "#E6E3D1";
    public string PrimaryContainer => "#59584A";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#2B2A25";
    public string OnSecondary => "#E6E2D9";
    public string SecondaryContainer => "#595751";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#272C0F";
    public string OnTertiary => "#E0E6BA";
    public string TertiaryContainer => "#555A38";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#560E00";
    public string OnError => "#FFDAD2";
    public string ErrorContainer => "#943B25";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#FEFCFA";
    public string SurfaceVariant => "#EBE8E1";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#2B2A26";
    public string SurfaceDim => "#E6E2DA";
    public string SurfaceBright => "#FEFCFA";
    public string SurfaceTint => "#2B2B1F";
    // Background
    public string Background => "#FEFCFA";
    public string OnBackground => "#000000";
    // Outline
    public string Outline => "#494843";
    public string OutlineVariant => "#595752";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#0F0E0D";
    public string InverseOnSurface => "#FFFFFF";
    public string InversePrimary => "#FDFAE7";
    // Primary Fixed
    public string PrimaryFixed => "#59584A";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#4D4C3F";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#595751";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#4D4C45";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#555A38";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#494E2D";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FDF9F4";
    public string SurfaceContainer => "#F7F3EE";
    public string SurfaceContainerHigh => "#F1EDE7";
    public string SurfaceContainerHighest => "#EBE8E1";
}
