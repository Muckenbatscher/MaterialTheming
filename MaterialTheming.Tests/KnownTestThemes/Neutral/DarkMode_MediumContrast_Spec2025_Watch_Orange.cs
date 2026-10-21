namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class DarkMode_MediumContrast_Spec2025_Watch_Orange : ITestTheme
{
    public string SourceColor => "#D77837"; //Orange
    public bool IsDark => true;
    public Variant Variant => Variant.Neutral;
    public Platform Platform => Platform.Watch;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#FFFEFF";
    public string OnPrimary => "#2C1C12";
    public string PrimaryContainer => "#9A8072";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#FFFEFF";
    public string OnSecondary => "#261E19";
    public string SecondaryContainer => "#91837C";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#FFFEFF";
    public string OnTertiary => "#0F0700";
    public string TertiaryContainer => "#DEAA5E";
    public string OnTertiaryContainer => "#392300";
    // Error
    public string Error => "#FFBFB0";
    public string OnError => "#390600";
    public string ErrorContainer => "#C46E5A";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#000000";
    public string SurfaceVariant => "#342116";
    public string OnSurface => "#FFFEFF";
    public string OnSurfaceVariant => "#DBCBC3";
    public string SurfaceDim => "#140D08";
    public string SurfaceBright => "#3D271A";
    public string SurfaceTint => "#FFFEFF";
    // Background
    public string Background => "#000000";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#B2A39B";
    public string OutlineVariant => "#91837C";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#FFF8F5";
    public string InverseOnSurface => "#403631";
    public string InversePrimary => "#473429";
    // Primary Fixed
    public string PrimaryFixed => "#FBDCCC";
    public string OnPrimaryFixed => "#2C1C12";
    public string PrimaryFixedDim => "#EDCEBE";
    public string OnPrimaryFixedVariant => "#4F3B2F";
    // Secondary Fixed
    public string SecondaryFixed => "#F0DFD7";
    public string OnSecondaryFixed => "#261E19";
    public string SecondaryFixedDim => "#E2D1C9";
    public string OnSecondaryFixedVariant => "#483D38";
    // Tertiary Fixed
    public string TertiaryFixed => "#FDC576";
    public string OnTertiaryFixed => "#0F0700";
    public string TertiaryFixedDim => "#EEB86A";
    public string OnTertiaryFixedVariant => "#472D00";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#2D241F";
    public string SurfaceContainer => "#382E29";
    public string SurfaceContainerHigh => "#443934";
    public string SurfaceContainerHighest => "#342116";
}
