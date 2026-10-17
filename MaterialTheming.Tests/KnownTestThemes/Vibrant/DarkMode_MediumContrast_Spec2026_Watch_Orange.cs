namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class DarkMode_MediumContrast_Spec2026_Watch_Orange : ITestTheme
{
    public string SourceColor => "#D77837"; //Orange
    public bool IsDark => true;
    public Variant Variant => Variant.Vibrant;
    public Platform Platform => Platform.Watch;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#FFFEFF";
    public string OnPrimary => "#000000";
    public string PrimaryContainer => "#C76E32";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#FFFEFF";
    public string OnSecondary => "#140500";
    public string SecondaryContainer => "#BA7549";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#FFFEFF";
    public string OnTertiary => "#2D2900";
    public string TertiaryContainer => "#E1D45B";
    public string OnTertiaryContainer => "#443E00";
    // Error
    public string Error => "#FFBFB0";
    public string OnError => "#390600";
    public string ErrorContainer => "#CD6951";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#000000";
    public string SurfaceVariant => "#3E1D05";
    public string OnSurface => "#FFFEFF";
    public string OnSurfaceVariant => "#F4C4A9";
    public string SurfaceDim => "#1D0800";
    public string SurfaceBright => "#472208";
    public string SurfaceTint => "#FFFEFF";
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
    public string InverseOnSurface => "#4F311E";
    public string InversePrimary => "#5E2900";
    // Primary Fixed
    public string PrimaryFixed => "#FFC29E";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#FE9B5A";
    public string OnPrimaryFixedVariant => "#451C00";
    // Secondary Fixed
    public string SecondaryFixed => "#FFC29E";
    public string OnSecondaryFixed => "#140500";
    public string SecondaryFixedDim => "#FFAF7E";
    public string OnSecondaryFixedVariant => "#552400";
    // Tertiary Fixed
    public string TertiaryFixed => "#FFF173";
    public string OnTertiaryFixed => "#2D2900";
    public string TertiaryFixedDim => "#F0E367";
    public string OnTertiaryFixedVariant => "#4E4800";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#3A1F0D";
    public string SurfaceContainer => "#462917";
    public string SurfaceContainerHigh => "#533421";
    public string SurfaceContainerHighest => "#3E1D05";
}
