namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class LightMode_MediumContrast_Spec2025_Yellow : ITestTheme
{
    public string SourceColor => "#B2B037"; //Yellow
    public bool IsDark => false;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#4A483B";
    public string OnPrimary => "#E6E2D1";
    public string PrimaryContainer => "#777566";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#494842";
    public string OnSecondary => "#E5E2D9";
    public string SecondaryContainer => "#76746D";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#454B2A";
    public string OnTertiary => "#E0E6BA";
    public string TertiaryContainer => "#727853";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#802C18";
    public string OnError => "#FFDAD1";
    public string ErrorContainer => "#BA573F";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#FEFCFA";
    public string SurfaceVariant => "#EBE8E1";
    public string OnSurface => "#2B2A26";
    public string OnSurfaceVariant => "#494843";
    public string SurfaceDim => "#E6E2DA";
    public string SurfaceBright => "#FEFCFA";
    public string SurfaceTint => "#4A483B";
    // Background
    public string Background => "#FEFCFA";
    public string OnBackground => "#2B2A26";
    // Outline
    public string Outline => "#66645F";
    public string OutlineVariant => "#82807B";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#0F0E0D";
    public string InverseOnSurface => "#C7C4C1";
    public string InversePrimary => "#FDFAE7";
    // Primary Fixed
    public string PrimaryFixed => "#777566";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#6A695A";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#76746D";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#6A6861";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#727853";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#656B47";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FDF9F4";
    public string SurfaceContainer => "#F7F3EE";
    public string SurfaceContainerHigh => "#F1EDE7";
    public string SurfaceContainerHighest => "#EBE8E1";
}
