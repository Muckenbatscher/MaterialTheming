namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class LightMode_NormalContrast_Spec2025_Watch_Orange : ITestTheme
{
    public string SourceColor => "#D77837"; //Orange
    public bool IsDark => false;
    public Variant Variant => Variant.Vibrant;
    public Platform Platform => Platform.Watch;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#FFC29E";
    public string OnPrimary => "#451C00";
    public string PrimaryContainer => "#743400";
    public string OnPrimaryContainer => "#FFD8C3";
    // Secondary
    public string Secondary => "#FFC29E";
    public string OnSecondary => "#552400";
    public string SecondaryContainer => "#6F3811";
    public string OnSecondaryContainer => "#FFD8C3";
    // Tertiary
    public string Tertiary => "#FFF173";
    public string OnTertiary => "#4E4700";
    public string TertiaryContainer => "#E1D45B";
    public string OnTertiaryContainer => "#443E00";
    // Error
    public string Error => "#FFBFB0";
    public string OnError => "#3B0600";
    public string ErrorContainer => "#7D2C19";
    public string OnErrorContainer => "#FFD7CE";
    // Surface
    public string Surface => "#000000";
    public string SurfaceVariant => "#3E1D05";
    public string OnSurface => "#FFE2D4";
    public string OnSurfaceVariant => "#F4C4A9";
    public string SurfaceDim => "#1D0800";
    public string SurfaceBright => "#472208";
    public string SurfaceTint => "#FFC29E";
    // Background
    public string Background => "#000000";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#C99C83";
    public string OutlineVariant => "#A67D65";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#FFF8F5";
    public string InverseOnSurface => "#704D38";
    public string InversePrimary => "#8A4001";
    // Primary Fixed
    public string PrimaryFixed => "#FFC29E";
    public string OnPrimaryFixed => "#451C00";
    public string PrimaryFixedDim => "#FE9B5A";
    public string OnPrimaryFixedVariant => "#723300";
    // Secondary Fixed
    public string SecondaryFixed => "#FFC29E";
    public string OnSecondaryFixed => "#552400";
    public string SecondaryFixedDim => "#FFAF7E";
    public string OnSecondaryFixedVariant => "#6F3811";
    // Tertiary Fixed
    public string TertiaryFixed => "#FFF173";
    public string OnTertiaryFixed => "#4E4700";
    public string TertiaryFixedDim => "#F0E367";
    public string OnTertiaryFixedVariant => "#4E4800";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#3A1F0D";
    public string SurfaceContainer => "#462917";
    public string SurfaceContainerHigh => "#533421";
    public string SurfaceContainerHighest => "#3E1D05";
}
