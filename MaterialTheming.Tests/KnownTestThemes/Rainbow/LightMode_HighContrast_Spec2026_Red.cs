namespace MaterialTheming.Tests.KnownTestThemes.Rainbow;

internal class LightMode_HighContrast_Spec2026_Red : ITestTheme
{
    public string SourceColor => "#D2463D"; //Red
    public bool IsDark => false;
    public Variant Variant => Variant.Rainbow;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#59100D";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#812D27";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#3F2522";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#60423E";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#3A2902";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#5A461B";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#600004";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#98000A";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#F9F9F9";
    public string SurfaceVariant => "#E2E2E2";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#000000";
    public string SurfaceDim => "#B9B9B9";
    public string SurfaceBright => "#F9F9F9";
    public string SurfaceTint => "#9C423A";
    // Background
    public string Background => "#F9F9F9";
    public string OnBackground => "#1B1B1B";
    // Outline
    public string Outline => "#2C2C2C";
    public string OutlineVariant => "#494949";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#303030";
    public string InverseOnSurface => "#FFFFFF";
    public string InversePrimary => "#FFB4AB";
    // Primary Fixed
    public string PrimaryFixed => "#812D27";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#621713";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#60423E";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#472C29";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#5A461B";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#423006";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F1F1F1";
    public string SurfaceContainer => "#E2E2E2";
    public string SurfaceContainerHigh => "#D4D4D4";
    public string SurfaceContainerHighest => "#C6C6C6";
}
