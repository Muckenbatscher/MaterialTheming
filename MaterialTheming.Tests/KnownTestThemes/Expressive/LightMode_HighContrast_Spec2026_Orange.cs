namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class LightMode_HighContrast_Spec2026_Orange : ITestTheme
{
    public string SourceColor => "#D77837"; //Orange
    public bool IsDark => false;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#3F1900";
    public string OnPrimary => "#FFD1B7";
    public string PrimaryContainer => "#863D00";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#08263D";
    public string OnSecondary => "#C3DDFB";
    public string SecondaryContainer => "#3B546E";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#00263E";
    public string OnTertiary => "#BBDEFF";
    public string TertiaryContainer => "#005784";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#4C0A00";
    public string OnError => "#FFCFC4";
    public string ErrorContainer => "#982B10";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#FFF8F5";
    public string SurfaceVariant => "#FFDCC1";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#3A1C00";
    public string SurfaceDim => "#FFD1AD";
    public string SurfaceBright => "#FFF8F5";
    public string SurfaceTint => "#3F1900";
    // Background
    public string Background => "#FFF8F5";
    public string OnBackground => "#000000";
    // Outline
    public string Outline => "#613A13";
    public string OutlineVariant => "#734821";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#1B0A00";
    public string InverseOnSurface => "#FFFFFF";
    public string InversePrimary => "#FFB486";
    // Primary Fixed
    public string PrimaryFixed => "#863D00";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#743400";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#3B546E";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#2F4961";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#005784";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#004B72";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFF1E8";
    public string SurfaceContainer => "#FFEADC";
    public string SurfaceContainerHigh => "#FFE3CF";
    public string SurfaceContainerHighest => "#FFDCC1";
}
