namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class LightMode_MediumContrast_Spec2026_Watch_Red : ITestTheme
{
    public string SourceColor => "#D2463D"; //Red
    public bool IsDark => false;
    public Variant Variant => Variant.Vibrant;
    public Platform Platform => Platform.Watch;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#FFFEFF";
    public string OnPrimary => "#000000";
    public string PrimaryContainer => "#CE675D";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#FFFEFF";
    public string OnSecondary => "#0E0002";
    public string SecondaryContainer => "#BD6F7A";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#FFFEFF";
    public string OnTertiary => "#000000";
    public string TertiaryContainer => "#C897EF";
    public string OnTertiaryContainer => "#340258";
    // Error
    public string Error => "#FFBDC3";
    public string OnError => "#3D000F";
    public string ErrorContainer => "#CC6674";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#000000";
    public string SurfaceVariant => "#401920";
    public string OnSurface => "#FFFEFF";
    public string OnSurfaceVariant => "#F4C1C6";
    public string SurfaceDim => "#1F060A";
    public string SurfaceBright => "#491F25";
    public string SurfaceTint => "#FFFEFF";
    // Background
    public string Background => "#000000";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#C99A9F";
    public string OutlineVariant => "#A67A7F";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#FFF8F7";
    public string InverseOnSurface => "#502F33";
    public string InversePrimary => "#6A1C18";
    // Primary Fixed
    public string PrimaryFixed => "#FFBFB8";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#FF8E82";
    public string OnPrimaryFixedVariant => "#4C0606";
    // Secondary Fixed
    public string SecondaryFixed => "#FFBEC5";
    public string OnSecondaryFixed => "#0E0002";
    public string SecondaryFixedDim => "#FDA6B1";
    public string OnSecondaryFixedVariant => "#561D27";
    // Tertiary Fixed
    public string TertiaryFixed => "#E5C1FF";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#D6A5FD";
    public string OnTertiaryFixedVariant => "#411364";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#3B1D21";
    public string SurfaceContainer => "#47272B";
    public string SurfaceContainerHigh => "#543236";
    public string SurfaceContainerHighest => "#401920";
}
