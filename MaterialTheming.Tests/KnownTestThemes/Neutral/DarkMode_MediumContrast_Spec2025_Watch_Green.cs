namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class DarkMode_MediumContrast_Spec2025_Watch_Green : ITestTheme
{
    public string SourceColor => "#338745"; //Green
    public bool IsDark => true;
    public Variant Variant => Variant.Neutral;
    public Platform Platform => Platform.Watch;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#FFFFFA";
    public string OnPrimary => "#172217";
    public string PrimaryContainer => "#7C897A";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#FFFFFA";
    public string OnSecondary => "#1C211B";
    public string SecondaryContainer => "#828780";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#FFFEFF";
    public string OnTertiary => "#303000";
    public string TertiaryContainer => "#E0DE87";
    public string OnTertiaryContainer => "#454500";
    // Error
    public string Error => "#FFBFB0";
    public string OnError => "#390600";
    public string ErrorContainer => "#C46E5A";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#000000";
    public string SurfaceVariant => "#1C291C";
    public string OnSurface => "#FFFFFA";
    public string OnSurfaceVariant => "#CBCFC7";
    public string SurfaceDim => "#0B0F0B";
    public string SurfaceBright => "#213021";
    public string SurfaceTint => "#FFFFFA";
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
    public string InverseOnSurface => "#353934";
    public string InversePrimary => "#2F3B2F";
    // Primary Fixed
    public string PrimaryFixed => "#D9E6D5";
    public string OnPrimaryFixed => "#172217";
    public string PrimaryFixedDim => "#CBD8C7";
    public string OnPrimaryFixedVariant => "#374236";
    // Secondary Fixed
    public string SecondaryFixed => "#E0E4DB";
    public string OnSecondaryFixed => "#1C211B";
    public string SecondaryFixedDim => "#D2D6CD";
    public string OnSecondaryFixedVariant => "#3C413B";
    // Tertiary Fixed
    public string TertiaryFixed => "#FDFBA1";
    public string OnTertiaryFixed => "#303000";
    public string TertiaryFixedDim => "#EEED94";
    public string OnTertiaryFixedVariant => "#494900";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#222722";
    public string SurfaceContainer => "#2D322C";
    public string SurfaceContainerHigh => "#383D37";
    public string SurfaceContainerHighest => "#1C291C";
}
