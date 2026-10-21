namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class LightMode_HighContrast_Spec2025_Watch_Green : ITestTheme
{
    public string SourceColor => "#338745"; //Green
    public bool IsDark => false;
    public Variant Variant => Variant.Neutral;
    public Platform Platform => Platform.Watch;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#FFFFFF";
    public string OnPrimary => "#000000";
    public string PrimaryContainer => "#9CA99A";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#FFFFFF";
    public string OnSecondary => "#000000";
    public string SecondaryContainer => "#A3A79F";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#FFFFFF";
    public string OnTertiary => "#000000";
    public string TertiaryContainer => "#E0DE87";
    public string OnTertiaryContainer => "#252500";
    // Error
    public string Error => "#FFBFB0";
    public string OnError => "#000000";
    public string ErrorContainer => "#EA8D77";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#000000";
    public string SurfaceVariant => "#1C291C";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#FFFFFA";
    public string SurfaceDim => "#0B0F0B";
    public string SurfaceBright => "#213021";
    public string SurfaceTint => "#FFFFFF";
    // Background
    public string Background => "#000000";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#CBCFC7";
    public string OutlineVariant => "#A3A79F";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#F7FBF2";
    public string InverseOnSurface => "#000000";
    public string InversePrimary => "#000000";
    // Primary Fixed
    public string PrimaryFixed => "#D9E6D5";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#CBD8C7";
    public string OnPrimaryFixedVariant => "#172217";
    // Secondary Fixed
    public string SecondaryFixed => "#E0E4DB";
    public string OnSecondaryFixed => "#000000";
    public string SecondaryFixedDim => "#D2D6CD";
    public string OnSecondaryFixedVariant => "#1C211B";
    // Tertiary Fixed
    public string TertiaryFixed => "#FDFBA1";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#EEED94";
    public string OnTertiaryFixedVariant => "#303000";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#222722";
    public string SurfaceContainer => "#2D322C";
    public string SurfaceContainerHigh => "#383D37";
    public string SurfaceContainerHighest => "#1C291C";
}
