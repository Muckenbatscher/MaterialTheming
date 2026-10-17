namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class LightMode_NormalContrast_Spec2026_Watch_Green : ITestTheme
{
    public string SourceColor => "#338745"; //Green
    public bool IsDark => false;
    public Variant Variant => Variant.Expressive;
    public Platform Platform => Platform.Watch;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#BCFEBF";
    public string OnPrimary => "#135123";
    public string PrimaryContainer => "#145224";
    public string OnPrimaryContainer => "#AFF0B2";
    // Secondary
    public string Secondary => "#E4D6FF";
    public string OnSecondary => "#403657";
    public string SecondaryContainer => "#4B4163";
    public string OnSecondaryContainer => "#E7DAFF";
    // Tertiary
    public string Tertiary => "#EDBEFF";
    public string OnTertiary => "#4A1763";
    public string TertiaryContainer => "#D59AEF";
    public string OnTertiaryContainer => "#3E0758";
    // Error
    public string Error => "#FFBFB0";
    public string OnError => "#3B0600";
    public string ErrorContainer => "#7D2C19";
    public string OnErrorContainer => "#FFD7CE";
    // Surface
    public string Surface => "#000000";
    public string SurfaceVariant => "#162A18";
    public string OnSurface => "#DEECDA";
    public string OnSurfaceVariant => "#C4D2C1";
    public string SurfaceDim => "#061107";
    public string SurfaceBright => "#1A311C";
    public string SurfaceTint => "#BCFEBF";
    // Background
    public string Background => "#000000";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#9CA99A";
    public string OutlineVariant => "#7C897A";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#F0FDEB";
    public string InverseOnSurface => "#4C584B";
    public string InversePrimary => "#256031";
    // Primary Fixed
    public string PrimaryFixed => "#BCFEBF";
    public string OnPrimaryFixed => "#135123";
    public string PrimaryFixedDim => "#AFEFB1";
    public string OnPrimaryFixedVariant => "#145224";
    // Secondary Fixed
    public string SecondaryFixed => "#E4D6FF";
    public string OnSecondaryFixed => "#403657";
    public string SecondaryFixedDim => "#D6C8F1";
    public string OnSecondaryFixedVariant => "#4B4163";
    // Tertiary Fixed
    public string TertiaryFixed => "#EDBEFF";
    public string OnTertiaryFixed => "#4A1763";
    public string TertiaryFixedDim => "#E4A8FD";
    public string OnTertiaryFixedVariant => "#63307C";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#1D291D";
    public string SurfaceContainer => "#283328";
    public string SurfaceContainerHigh => "#333E32";
    public string SurfaceContainerHighest => "#162A18";
}
