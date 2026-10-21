namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class LightMode_MediumContrast_Spec2025_Watch_Yellow : ITestTheme
{
    public string SourceColor => "#B2B037"; //Yellow
    public bool IsDark => false;
    public Variant Variant => Variant.Neutral;
    public Platform Platform => Platform.Watch;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#FFFEFF";
    public string OnPrimary => "#21200F";
    public string PrimaryContainer => "#88876F";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#FFFEFF";
    public string OnSecondary => "#202018";
    public string SecondaryContainer => "#88867A";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#FFFEFF";
    public string OnTertiary => "#153000";
    public string TertiaryContainer => "#BBE09A";
    public string OnTertiaryContainer => "#2A4712";
    // Error
    public string Error => "#FFBFB0";
    public string OnError => "#390600";
    public string ErrorContainer => "#C46E5A";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#000000";
    public string SurfaceVariant => "#272713";
    public string OnSurface => "#FFFEFF";
    public string OnSurfaceVariant => "#D1CEC1";
    public string SurfaceDim => "#0F0E07";
    public string SurfaceBright => "#2E2D16";
    public string SurfaceTint => "#FFFEFF";
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
    public string InverseOnSurface => "#39382F";
    public string InversePrimary => "#3A3926";
    // Primary Fixed
    public string PrimaryFixed => "#E7E3C8";
    public string OnPrimaryFixed => "#21200F";
    public string PrimaryFixedDim => "#D8D5BA";
    public string OnPrimaryFixedVariant => "#41402D";
    // Secondary Fixed
    public string SecondaryFixed => "#E6E2D5";
    public string OnSecondaryFixed => "#202018";
    public string SecondaryFixedDim => "#D8D4C7";
    public string OnSecondaryFixedVariant => "#414036";
    // Tertiary Fixed
    public string TertiaryFixed => "#D7FCB4";
    public string OnTertiaryFixed => "#153000";
    public string TertiaryFixedDim => "#C9EEA7";
    public string OnTertiaryFixedVariant => "#314E19";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#27261E";
    public string SurfaceContainer => "#313128";
    public string SurfaceContainerHigh => "#3D3C32";
    public string SurfaceContainerHighest => "#272713";
}
