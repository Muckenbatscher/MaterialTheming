namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class LightMode_HighContrast_Spec2025_Magenta : ITestTheme
{
    public string SourceColor => "#E85DAE"; //Magenta
    public bool IsDark => false;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#2C2126";
    public string OnPrimary => "#E8D5DC";
    public string PrimaryContainer => "#5C4F54";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#282224";
    public string OnSecondary => "#E2D7DA";
    public string SecondaryContainer => "#575053";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#2D1E35";
    public string OnTertiary => "#EAD2F1";
    public string TertiaryContainer => "#5E4C65";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#4F0116";
    public string OnError => "#FFCED2";
    public string ErrorContainer => "#8E3242";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#FEF8F8";
    public string SurfaceVariant => "#E9E0E2";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#272324";
    public string SurfaceDim => "#E1D8DA";
    public string SurfaceBright => "#FEF8F8";
    public string SurfaceTint => "#2C2126";
    // Background
    public string Background => "#FEF8F8";
    public string OnBackground => "#000000";
    // Outline
    public string Outline => "#474143";
    public string OutlineVariant => "#565152";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#0F0E0E";
    public string InverseOnSurface => "#FFFFFF";
    public string InversePrimary => "#F6E3EA";
    // Primary Fixed
    public string PrimaryFixed => "#5C4F54";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#504348";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#575053";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#4B4547";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#5E4C65";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#524059";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F9F2F2";
    public string SurfaceContainer => "#F4ECED";
    public string SurfaceContainerHigh => "#EFE6E7";
    public string SurfaceContainerHighest => "#E9E0E2";
}
