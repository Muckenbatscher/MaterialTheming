namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class LightMode_HighContrast_Spec2021_Green : ITestTheme
{
    public string SourceColor => "#338745"; //Green
    public bool IsDark => false;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#242F23";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#404C3F";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#272E26";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#444B43";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#203020";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#3C4D3C";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#600004";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#98000A";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#FBF9F6";
    public string SurfaceVariant => "#E4E2DF";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#000000";
    public string SurfaceDim => "#BAB9B6";
    public string SurfaceBright => "#FBF9F6";
    public string SurfaceTint => "#556254";
    // Background
    public string Background => "#FBF9F6";
    public string OnBackground => "#1B1C1A";
    // Outline
    public string Outline => "#2C2C2B";
    public string OutlineVariant => "#494947";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#30312F";
    public string InverseOnSurface => "#FFFFFF";
    public string InversePrimary => "#BDCABA";
    // Primary Fixed
    public string PrimaryFixed => "#404C3F";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#2A362A";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#444B43";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#2E342D";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#3C4D3C";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#263727";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F2F0ED";
    public string SurfaceContainer => "#E4E2DF";
    public string SurfaceContainerHigh => "#D6D4D1";
    public string SurfaceContainerHighest => "#C7C6C3";
}
