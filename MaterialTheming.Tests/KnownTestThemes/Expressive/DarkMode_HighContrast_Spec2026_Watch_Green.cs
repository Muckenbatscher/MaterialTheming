namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class DarkMode_HighContrast_Spec2026_Watch_Green : ITestTheme
{
    public string SourceColor => "#338745"; //Green
    public bool IsDark => true;
    public Variant Variant => Variant.Expressive;
    public Platform Platform => Platform.Watch;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#FFFFFF";
    public string OnPrimary => "#000000";
    public string PrimaryContainer => "#76B47B";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#FFFFFF";
    public string OnSecondary => "#000000";
    public string SecondaryContainer => "#ACA0C6";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#FFFFFF";
    public string OnTertiary => "#000000";
    public string TertiaryContainer => "#D59AEF";
    public string OnTertiaryContainer => "#000000";
    // Error
    public string Error => "#FFBFB0";
    public string OnError => "#000000";
    public string ErrorContainer => "#F4886D";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#000000";
    public string SurfaceVariant => "#162A18";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#FFFFFA";
    public string SurfaceDim => "#061107";
    public string SurfaceBright => "#1A311C";
    public string SurfaceTint => "#FFFFFF";
    // Background
    public string Background => "#000000";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#C4D2C1";
    public string OutlineVariant => "#9CA99A";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#F0FDEB";
    public string InverseOnSurface => "#000000";
    public string InversePrimary => "#000000";
    // Primary Fixed
    public string PrimaryFixed => "#BCFEBF";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#AFEFB1";
    public string OnPrimaryFixedVariant => "#00300E";
    // Secondary Fixed
    public string SecondaryFixed => "#E4D6FF";
    public string OnSecondaryFixed => "#000000";
    public string SecondaryFixedDim => "#D6C8F1";
    public string OnSecondaryFixedVariant => "#1E1534";
    // Tertiary Fixed
    public string TertiaryFixed => "#EDBEFF";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#E4A8FD";
    public string OnTertiaryFixedVariant => "#090011";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#1D291D";
    public string SurfaceContainer => "#283328";
    public string SurfaceContainerHigh => "#333E32";
    public string SurfaceContainerHighest => "#162A18";
}
