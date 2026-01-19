namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class LightMode_HighContrast_Spec2021_Magenta : ITestTheme
{
    public string SourceColor => "#E85DAE"; //Magenta
    public bool IsDark => false;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#38272F";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#57444C";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#34292E";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#52464B";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#3C2630";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#5B424E";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#600004";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#98000A";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#FFF8F8";
    public string SurfaceVariant => "#E8E1E1";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#000000";
    public string SurfaceDim => "#BDB7B8";
    public string SurfaceBright => "#FFF8F8";
    public string SurfaceTint => "#6D5962";
    // Background
    public string Background => "#FFF8F8";
    public string OnBackground => "#1E1B1C";
    // Outline
    public string Outline => "#2E2B2C";
    public string OutlineVariant => "#4C4849";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#333030";
    public string InverseOnSurface => "#FFFFFF";
    public string InversePrimary => "#DAC0CA";
    // Primary Fixed
    public string PrimaryFixed => "#57444C";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#3F2E36";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#52464B";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#3B3034";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#5B424E";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#432C37";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F6EFF0";
    public string SurfaceContainer => "#E8E1E1";
    public string SurfaceContainerHigh => "#DAD3D3";
    public string SurfaceContainerHighest => "#CBC5C6";
}
