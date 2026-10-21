namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class LightMode_MediumContrast_Spec2026_Watch_Green : ITestTheme
{
    public string SourceColor => "#338745"; //Green
    public bool IsDark => false;
    public Variant Variant => Variant.Expressive;
    public Platform Platform => Platform.Watch;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#FFFFFA";
    public string OnPrimary => "#00300E";
    public string PrimaryContainer => "#57935D";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#FFFEFF";
    public string OnSecondary => "#1E1534";
    public string SecondaryContainer => "#8B80A5";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#FFFEFF";
    public string OnTertiary => "#090011";
    public string TertiaryContainer => "#D59AEF";
    public string OnTertiaryContainer => "#3E0758";
    // Error
    public string Error => "#FFBFB0";
    public string OnError => "#390600";
    public string ErrorContainer => "#CD6951";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#000000";
    public string SurfaceVariant => "#162A18";
    public string OnSurface => "#FFFFFA";
    public string OnSurfaceVariant => "#C4D2C1";
    public string SurfaceDim => "#061107";
    public string SurfaceBright => "#1A311C";
    public string SurfaceTint => "#FFFFFA";
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
    public string InverseOnSurface => "#2F3B2F";
    public string InversePrimary => "#004217";
    // Primary Fixed
    public string PrimaryFixed => "#BCFEBF";
    public string OnPrimaryFixed => "#00300E";
    public string PrimaryFixedDim => "#AFEFB1";
    public string OnPrimaryFixedVariant => "#145224";
    // Secondary Fixed
    public string SecondaryFixed => "#E4D6FF";
    public string OnSecondaryFixed => "#1E1534";
    public string SecondaryFixedDim => "#D6C8F1";
    public string OnSecondaryFixedVariant => "#403657";
    // Tertiary Fixed
    public string TertiaryFixed => "#EDBEFF";
    public string OnTertiaryFixed => "#090011";
    public string TertiaryFixedDim => "#E4A8FD";
    public string OnTertiaryFixedVariant => "#4A1763";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#1D291D";
    public string SurfaceContainer => "#283328";
    public string SurfaceContainerHigh => "#333E32";
    public string SurfaceContainerHighest => "#162A18";
}
