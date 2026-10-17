namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class DarkMode_HighContrast_Spec2025_Watch_Orange : ITestTheme
{
    public string SourceColor => "#D77837"; //Orange
    public bool IsDark => true;
    public Variant Variant => Variant.Neutral;
    public Platform Platform => Platform.Watch;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#FFFFFF";
    public string OnPrimary => "#000000";
    public string PrimaryContainer => "#BCA091";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#FFFFFF";
    public string OnSecondary => "#000000";
    public string SecondaryContainer => "#B2A39B";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#FFFFFF";
    public string OnTertiary => "#000000";
    public string TertiaryContainer => "#DEAA5E";
    public string OnTertiaryContainer => "#000000";
    // Error
    public string Error => "#FFBFB0";
    public string OnError => "#000000";
    public string ErrorContainer => "#EA8D77";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#000000";
    public string SurfaceVariant => "#342116";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#FFFEFF";
    public string SurfaceDim => "#140D08";
    public string SurfaceBright => "#3D271A";
    public string SurfaceTint => "#FFFFFF";
    // Background
    public string Background => "#000000";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#DBCBC3";
    public string OutlineVariant => "#B2A39B";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#FFF8F5";
    public string InverseOnSurface => "#000000";
    public string InversePrimary => "#000000";
    // Primary Fixed
    public string PrimaryFixed => "#FBDCCC";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#EDCEBE";
    public string OnPrimaryFixedVariant => "#2C1C12";
    // Secondary Fixed
    public string SecondaryFixed => "#F0DFD7";
    public string OnSecondaryFixed => "#000000";
    public string SecondaryFixedDim => "#E2D1C9";
    public string OnSecondaryFixedVariant => "#261E19";
    // Tertiary Fixed
    public string TertiaryFixed => "#FDC576";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#EEB86A";
    public string OnTertiaryFixedVariant => "#0F0700";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#2D241F";
    public string SurfaceContainer => "#382E29";
    public string SurfaceContainerHigh => "#443934";
    public string SurfaceContainerHighest => "#342116";
}
