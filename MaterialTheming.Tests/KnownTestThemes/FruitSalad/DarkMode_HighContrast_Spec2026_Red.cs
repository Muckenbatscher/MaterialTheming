namespace MaterialTheming.Tests.KnownTestThemes.FruitSalad;

internal class DarkMode_HighContrast_Spec2026_Red : ITestTheme
{
    public string SourceColor => "#D2463D"; //Red
    public bool IsDark => true;
    public Variant Variant => Variant.FruitSalad;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#FFEAF7";
    public string OnPrimary => "#000000";
    public string PrimaryContainer => "#FBA7EF";
    public string OnPrimaryContainer => "#1D001C";
    // Secondary
    public string Secondary => "#FFEAF7";
    public string OnSecondary => "#000000";
    public string SecondaryContainer => "#EDAFE2";
    public string OnSecondaryContainer => "#1D001C";
    // Tertiary
    public string Tertiary => "#FFECE9";
    public string OnTertiary => "#000000";
    public string TertiaryContainer => "#FFAEA5";
    public string OnTertiaryContainer => "#220001";
    // Error
    public string Error => "#FFECE9";
    public string OnError => "#000000";
    public string ErrorContainer => "#FFAEA4";
    public string OnErrorContainer => "#220001";
    // Surface
    public string Surface => "#1E100E";
    public string SurfaceVariant => "#5D3F3C";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#FFFFFF";
    public string SurfaceDim => "#1E100E";
    public string SurfaceBright => "#5F4B49";
    public string SurfaceTint => "#FFABF3";
    // Background
    public string Background => "#1E100E";
    public string OnBackground => "#F9DCD9";
    // Outline
    public string Outline => "#FFECE9";
    public string OutlineVariant => "#E3B9B4";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#F9DCD9";
    public string InverseOnSurface => "#000000";
    public string InversePrimary => "#702D6C";
    // Primary Fixed
    public string PrimaryFixed => "#FFD7F5";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#FFABF3";
    public string OnPrimaryFixedVariant => "#260026";
    // Secondary Fixed
    public string SecondaryFixed => "#FFD7F5";
    public string OnSecondaryFixed => "#000000";
    public string SecondaryFixedDim => "#F1B3E6";
    public string OnSecondaryFixedVariant => "#260026";
    // Tertiary Fixed
    public string TertiaryFixed => "#FFDAD6";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#FFB4AB";
    public string OnTertiaryFixedVariant => "#2C0102";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#2B1C1A";
    public string SurfaceContainer => "#3D2C2A";
    public string SurfaceContainerHigh => "#493735";
    public string SurfaceContainerHighest => "#554240";
}
