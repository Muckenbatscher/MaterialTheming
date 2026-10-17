namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class LightMode_NormalContrast_Spec2025_Watch_Green : ITestTheme
{
    public string SourceColor => "#338745"; //Green
    public bool IsDark => false;
    public Variant Variant => Variant.Neutral;
    public Platform Platform => Platform.Watch;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#D9E6D5";
    public string OnPrimary => "#374236";
    public string PrimaryContainer => "#3E4A3D";
    public string OnPrimaryContainer => "#D6E4D3";
    // Secondary
    public string Secondary => "#E0E4DB";
    public string OnSecondary => "#3C413B";
    public string SecondaryContainer => "#434842";
    public string OnSecondaryContainer => "#DDE1D9";
    // Tertiary
    public string Tertiary => "#FDFBA1";
    public string OnTertiary => "#4E4E03";
    public string TertiaryContainer => "#E0DE87";
    public string OnTertiaryContainer => "#454500";
    // Error
    public string Error => "#FFBFB0";
    public string OnError => "#3B0700";
    public string ErrorContainer => "#763221";
    public string OnErrorContainer => "#FFD7CE";
    // Surface
    public string Surface => "#000000";
    public string SurfaceVariant => "#1C291C";
    public string OnSurface => "#E5E9E1";
    public string OnSurfaceVariant => "#CBCFC7";
    public string SurfaceDim => "#0B0F0B";
    public string SurfaceBright => "#213021";
    public string SurfaceTint => "#D9E6D5";
    // Background
    public string Background => "#000000";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#A3A79F";
    public string OutlineVariant => "#828780";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#F7FBF2";
    public string InverseOnSurface => "#525650";
    public string InversePrimary => "#4C584B";
    // Primary Fixed
    public string PrimaryFixed => "#D9E6D5";
    public string OnPrimaryFixed => "#374236";
    public string PrimaryFixedDim => "#CBD8C7";
    public string OnPrimaryFixedVariant => "#3E4A3D";
    // Secondary Fixed
    public string SecondaryFixed => "#E0E4DB";
    public string OnSecondaryFixed => "#3C413B";
    public string SecondaryFixedDim => "#D2D6CD";
    public string OnSecondaryFixedVariant => "#434842";
    // Tertiary Fixed
    public string TertiaryFixed => "#FDFBA1";
    public string OnTertiaryFixed => "#4E4E03";
    public string TertiaryFixedDim => "#EEED94";
    public string OnTertiaryFixedVariant => "#494900";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#222722";
    public string SurfaceContainer => "#2D322C";
    public string SurfaceContainerHigh => "#383D37";
    public string SurfaceContainerHighest => "#1C291C";
}
