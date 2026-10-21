namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class DarkMode_NormalContrast_Spec2026_Watch_Red : ITestTheme
{
    public string SourceColor => "#D2463D"; //Red
    public bool IsDark => true;
    public Variant Variant => Variant.Vibrant;
    public Platform Platform => Platform.Watch;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#FFBFB8";
    public string OnPrimary => "#4C0606";
    public string PrimaryContainer => "#7D2B25";
    public string OnPrimaryContainer => "#FFD7D2";
    // Secondary
    public string Secondary => "#FFBEC5";
    public string OnSecondary => "#561D27";
    public string SecondaryContainer => "#72333D";
    public string OnSecondaryContainer => "#FFD6DA";
    // Tertiary
    public string Tertiary => "#E5C1FF";
    public string OnTertiary => "#411364";
    public string TertiaryContainer => "#C897EF";
    public string OnTertiaryContainer => "#340258";
    // Error
    public string Error => "#FFBDC3";
    public string OnError => "#3F000F";
    public string ErrorContainer => "#7D2938";
    public string OnErrorContainer => "#FFD6D9";
    // Surface
    public string Surface => "#000000";
    public string SurfaceVariant => "#401920";
    public string OnSurface => "#FFE1E3";
    public string OnSurfaceVariant => "#F4C1C6";
    public string SurfaceDim => "#1F060A";
    public string SurfaceBright => "#491F25";
    public string SurfaceTint => "#FFBFB8";
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
    public string InverseOnSurface => "#714B4F";
    public string InversePrimary => "#903931";
    // Primary Fixed
    public string PrimaryFixed => "#FFBFB8";
    public string OnPrimaryFixed => "#4C0606";
    public string PrimaryFixedDim => "#FF8E82";
    public string OnPrimaryFixedVariant => "#762620";
    // Secondary Fixed
    public string SecondaryFixed => "#FFBEC5";
    public string OnSecondaryFixed => "#561D27";
    public string SecondaryFixedDim => "#FDA6B1";
    public string OnSecondaryFixedVariant => "#72333D";
    // Tertiary Fixed
    public string TertiaryFixed => "#E5C1FF";
    public string OnTertiaryFixed => "#411364";
    public string TertiaryFixedDim => "#D6A5FD";
    public string OnTertiaryFixedVariant => "#5D3281";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#3B1D21";
    public string SurfaceContainer => "#47272B";
    public string SurfaceContainerHigh => "#543236";
    public string SurfaceContainerHighest => "#401920";
}
