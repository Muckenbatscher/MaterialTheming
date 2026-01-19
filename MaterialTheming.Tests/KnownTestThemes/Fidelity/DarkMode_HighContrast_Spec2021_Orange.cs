namespace MaterialTheming.Tests.KnownTestThemes.Fidelity;

internal class DarkMode_HighContrast_Spec2021_Orange : ITestTheme
{
    public string SourceColor => "#D77837"; //Orange
    public bool IsDark => true;
    public Variant Variant => Variant.Fidelity;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#FFECE3";
    public string OnPrimary => "#000000";
    public string PrimaryContainer => "#FFB181";
    public string OnPrimaryContainer => "#190600";
    // Secondary
    public string Secondary => "#FFECE3";
    public string OnSecondary => "#000000";
    public string SecondaryContainer => "#F0B695";
    public string OnSecondaryContainer => "#190600";
    // Tertiary
    public string Tertiary => "#DAF4FF";
    public string OnTertiary => "#000000";
    public string TertiaryContainer => "#5CD1F3";
    public string OnTertiaryContainer => "#000D12";
    // Error
    public string Error => "#FFECE9";
    public string OnError => "#000000";
    public string ErrorContainer => "#FFAEA4";
    public string OnErrorContainer => "#220001";
    // Surface
    public string Surface => "#1A120D";
    public string SurfaceVariant => "#554339";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#FFFFFF";
    public string SurfaceDim => "#1A120D";
    public string SurfaceBright => "#594E47";
    public string SurfaceTint => "#FFB68B";
    // Background
    public string Background => "#1A120D";
    public string OnBackground => "#F1DFD7";
    // Outline
    public string Outline => "#FFECE3";
    public string OutlineVariant => "#D7BEB0";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#F1DFD7";
    public string InverseOnSurface => "#000000";
    public string InversePrimary => "#763500";
    // Primary Fixed
    public string PrimaryFixed => "#FFDBC8";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#FFB68B";
    public string OnPrimaryFixedVariant => "#220A00";
    // Secondary Fixed
    public string SecondaryFixed => "#FFDBC8";
    public string OnSecondaryFixed => "#000000";
    public string SecondaryFixedDim => "#F4BA98";
    public string OnSecondaryFixedVariant => "#220A00";
    // Tertiary Fixed
    public string TertiaryFixed => "#B4EBFF";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#61D5F7";
    public string OnTertiaryFixedVariant => "#00141A";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#271E19";
    public string SurfaceContainer => "#382E29";
    public string SurfaceContainerHigh => "#443933";
    public string SurfaceContainerHighest => "#50443E";
}
