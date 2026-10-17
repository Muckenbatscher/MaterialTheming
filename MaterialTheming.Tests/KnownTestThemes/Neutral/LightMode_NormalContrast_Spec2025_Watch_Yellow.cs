namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class LightMode_NormalContrast_Spec2025_Watch_Yellow : ITestTheme
{
    public string SourceColor => "#B2B037"; //Yellow
    public bool IsDark => false;
    public Variant Variant => Variant.Neutral;
    public Platform Platform => Platform.Watch;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#E7E3C8";
    public string OnPrimary => "#41402D";
    public string PrimaryContainer => "#494833";
    public string OnPrimaryContainer => "#E4E1C6";
    // Secondary
    public string Secondary => "#E6E2D5";
    public string OnSecondary => "#414036";
    public string SecondaryContainer => "#48473D";
    public string OnSecondaryContainer => "#E4E0D3";
    // Tertiary
    public string Tertiary => "#D7FCB4";
    public string OnTertiary => "#32501A";
    public string TertiaryContainer => "#BBE09A";
    public string OnTertiaryContainer => "#2A4712";
    // Error
    public string Error => "#FFBFB0";
    public string OnError => "#3B0700";
    public string ErrorContainer => "#763221";
    public string OnErrorContainer => "#FFD7CE";
    // Surface
    public string Surface => "#000000";
    public string SurfaceVariant => "#272713";
    public string OnSurface => "#ECE8DB";
    public string OnSurfaceVariant => "#D1CEC1";
    public string SurfaceDim => "#0F0E07";
    public string SurfaceBright => "#2E2D16";
    public string SurfaceTint => "#E7E3C8";
    // Background
    public string Background => "#000000";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#A8A69A";
    public string OutlineVariant => "#88867A";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#FDF9EC";
    public string InverseOnSurface => "#57554B";
    public string InversePrimary => "#575641";
    // Primary Fixed
    public string PrimaryFixed => "#E7E3C8";
    public string OnPrimaryFixed => "#41402D";
    public string PrimaryFixedDim => "#D8D5BA";
    public string OnPrimaryFixedVariant => "#494833";
    // Secondary Fixed
    public string SecondaryFixed => "#E6E2D5";
    public string OnSecondaryFixed => "#414036";
    public string SecondaryFixedDim => "#D8D4C7";
    public string OnSecondaryFixedVariant => "#48473D";
    // Tertiary Fixed
    public string TertiaryFixed => "#D7FCB4";
    public string OnTertiaryFixed => "#32501A";
    public string TertiaryFixedDim => "#C9EEA7";
    public string OnTertiaryFixedVariant => "#314E19";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#27261E";
    public string SurfaceContainer => "#313128";
    public string SurfaceContainerHigh => "#3D3C32";
    public string SurfaceContainerHighest => "#272713";
}
