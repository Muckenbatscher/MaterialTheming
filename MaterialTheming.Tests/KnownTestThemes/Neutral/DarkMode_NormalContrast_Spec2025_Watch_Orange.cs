namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class DarkMode_NormalContrast_Spec2025_Watch_Orange : ITestTheme
{
    public string SourceColor => "#D77837"; //Orange
    public bool IsDark => true;
    public Variant Variant => Variant.Neutral;
    public Platform Platform => Platform.Watch;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#FBDCCC";
    public string OnPrimary => "#4F3B2F";
    public string PrimaryContainer => "#574236";
    public string OnPrimaryContainer => "#F9DACA";
    // Secondary
    public string Secondary => "#F0DFD7";
    public string OnSecondary => "#483D38";
    public string SecondaryContainer => "#4F453F";
    public string OnSecondaryContainer => "#EEDDD5";
    // Tertiary
    public string Tertiary => "#FDC576";
    public string OnTertiary => "#472D00";
    public string TertiaryContainer => "#DEAA5E";
    public string OnTertiaryContainer => "#392300";
    // Error
    public string Error => "#FFBFB0";
    public string OnError => "#3B0700";
    public string ErrorContainer => "#763221";
    public string OnErrorContainer => "#FFD7CE";
    // Surface
    public string Surface => "#000000";
    public string SurfaceVariant => "#342116";
    public string OnSurface => "#F6E5DD";
    public string OnSurfaceVariant => "#DBCBC3";
    public string SurfaceDim => "#140D08";
    public string SurfaceBright => "#3D271A";
    public string SurfaceTint => "#FBDCCC";
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
    public string InverseOnSurface => "#5E534D";
    public string InversePrimary => "#665044";
    // Primary Fixed
    public string PrimaryFixed => "#FBDCCC";
    public string OnPrimaryFixed => "#4F3B2F";
    public string PrimaryFixedDim => "#EDCEBE";
    public string OnPrimaryFixedVariant => "#574236";
    // Secondary Fixed
    public string SecondaryFixed => "#F0DFD7";
    public string OnSecondaryFixed => "#483D38";
    public string SecondaryFixedDim => "#E2D1C9";
    public string OnSecondaryFixedVariant => "#4F453F";
    // Tertiary Fixed
    public string TertiaryFixed => "#FDC576";
    public string OnTertiaryFixed => "#472D00";
    public string TertiaryFixedDim => "#EEB86A";
    public string OnTertiaryFixedVariant => "#624000";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#2D241F";
    public string SurfaceContainer => "#382E29";
    public string SurfaceContainerHigh => "#443934";
    public string SurfaceContainerHighest => "#342116";
}
