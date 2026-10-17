namespace MaterialTheming.Tests.KnownTestThemes.Content;

internal class LightMode_HighContrast_Spec2026_Watch_Red : ITestTheme
{
    public string SourceColor => "#D2463D"; //Red
    public bool IsDark => false;
    public Variant Variant => Variant.Content;
    public Platform Platform => Platform.Watch;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#FFFFFF";
    public string OnPrimary => "#000000";
    public string PrimaryContainer => "#FF8074";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#FFFFFF";
    public string OnSecondary => "#000000";
    public string SecondaryContainer => "#E39087";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#FFFFFF";
    public string OnTertiary => "#000000";
    public string TertiaryContainer => "#FF76BB";
    public string OnTertiaryContainer => "#000000";
    // Error
    public string Error => "#FFBDC3";
    public string OnError => "#000000";
    public string ErrorContainer => "#FF7D8F";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#000000";
    public string SurfaceVariant => "#3C1D1A";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#FFFEFF";
    public string SurfaceDim => "#1F0605";
    public string SurfaceBright => "#432320";
    public string SurfaceTint => "#FFFFFF";
    // Background
    public string Background => "#000000";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#F6C2BB";
    public string OutlineVariant => "#CB9A94";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#FFF8F7";
    public string InverseOnSurface => "#000000";
    public string InversePrimary => "#000000";
    // Primary Fixed
    public string PrimaryFixed => "#FFBFB8";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#FF8074";
    public string OnPrimaryFixedVariant => "#000000";
    // Secondary Fixed
    public string SecondaryFixed => "#FFBFB8";
    public string OnSecondaryFixed => "#000000";
    public string SecondaryFixedDim => "#FFA89E";
    public string OnSecondaryFixedVariant => "#0E0000";
    // Tertiary Fixed
    public string TertiaryFixed => "#FFBCD8";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#FF77BC";
    public string OnTertiaryFixedVariant => "#000000";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#3C1D1A";
    public string SurfaceContainer => "#482724";
    public string SurfaceContainerHigh => "#55322E";
    public string SurfaceContainerHighest => "#3C1D1A";
}
