namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class DarkMode_HighContrast_Spec2025_Orange : ITestTheme
{
    public string SourceColor => "#D77837"; //Orange
    public bool IsDark => true;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#FFDFCE";
    public string OnPrimary => "#4B1F00";
    public string PrimaryContainer => "#FF801D";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#FFE0C8";
    public string OnSecondary => "#462300";
    public string SecondaryContainer => "#ED8C24";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#FFE2AC";
    public string OnTertiary => "#3A2900";
    public string TertiaryContainer => "#FFC32D";
    public string OnTertiaryContainer => "#211600";
    // Error
    public string Error => "#FFDED7";
    public string OnError => "#5A0E00";
    public string ErrorContainer => "#FF7E5E";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#1B0A00";
    public string SurfaceVariant => "#3D1E00";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#FFE0C8";
    public string SurfaceDim => "#1B0A00";
    public string SurfaceBright => "#462300";
    public string SurfaceTint => "#FFDFCE";
    // Background
    public string Background => "#1B0A00";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#E5AD7E";
    public string OutlineVariant => "#CE996B";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#FFF8F5";
    public string InverseOnSurface => "#000000";
    public string InversePrimary => "#5E2900";
    // Primary Fixed
    public string PrimaryFixed => "#FF801D";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#EF7300";
    public string OnPrimaryFixedVariant => "#000000";
    // Secondary Fixed
    public string SecondaryFixed => "#FFC697";
    public string OnSecondaryFixed => "#000000";
    public string SecondaryFixedDim => "#FFB471";
    public string OnSecondaryFixedVariant => "#190900";
    // Tertiary Fixed
    public string TertiaryFixed => "#FFC32D";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#F0B51C";
    public string OnTertiaryFixedVariant => "#050300";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#220E00";
    public string SurfaceContainer => "#2B1400";
    public string SurfaceContainerHigh => "#341900";
    public string SurfaceContainerHighest => "#3D1E00";
}
