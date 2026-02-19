namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class LightMode_MediumContrast_Spec2026_Blue : ITestTheme
{
    public string SourceColor => "#185FAA"; //Blue
    public bool IsDark => false;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#004380";
    public string OnPrimary => "#C6DBFF";
    public string PrimaryContainer => "#3D76BE";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#254A37";
    public string OnSecondary => "#BAE3CA";
    public string SecondaryContainer => "#567D67";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#004E2C";
    public string OnTertiary => "#8CEEB1";
    public string TertiaryContainer => "#1A8552";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#84161B";
    public string OnError => "#FFCECA";
    public string ErrorContainer => "#C94947";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#F9F9FF";
    public string SurfaceVariant => "#D5E3FF";
    public string OnSurface => "#062446";
    public string OnSurfaceVariant => "#2B4466";
    public string SurfaceDim => "#C7DBFF";
    public string SurfaceBright => "#F9F9FF";
    public string SurfaceTint => "#004380";
    // Background
    public string Background => "#F9F9FF";
    public string OnBackground => "#062446";
    // Outline
    public string Outline => "#486085";
    public string OutlineVariant => "#647CA2";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#030E20";
    public string InverseOnSurface => "#B9C5DD";
    public string InversePrimary => "#7EB2FF";
    // Primary Fixed
    public string PrimaryFixed => "#3D76BE";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#2E69B1";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#567D67";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#4A705B";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#1A8552";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#007847";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F0F3FF";
    public string SurfaceContainer => "#E7EEFF";
    public string SurfaceContainerHigh => "#DEE9FF";
    public string SurfaceContainerHighest => "#D5E3FF";
}
