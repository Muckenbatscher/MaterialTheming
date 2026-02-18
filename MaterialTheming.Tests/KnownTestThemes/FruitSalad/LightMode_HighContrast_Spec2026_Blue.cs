namespace MaterialTheming.Tests.KnownTestThemes.FruitSalad;

internal class LightMode_HighContrast_Spec2026_Blue : ITestTheme
{
    public string SourceColor => "#185FAA"; //Blue
    public bool IsDark => false;
    public Variant Variant => Variant.FruitSalad;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#003138";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#00515B";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#003138";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#00515B";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#002C58";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#264A79";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#600004";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#98000A";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#F9F9FF";
    public string SurfaceVariant => "#D9E3F8";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#000000";
    public string SurfaceDim => "#B4B9C4";
    public string SurfaceBright => "#F9F9FF";
    public string SurfaceTint => "#006874";
    // Background
    public string Background => "#F9F9FF";
    public string OnBackground => "#171C24";
    // Outline
    public string Outline => "#222D3D";
    public string OutlineVariant => "#3F4A5B";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#2B313A";
    public string InverseOnSurface => "#FFFFFF";
    public string InversePrimary => "#4FD8EB";
    // Primary Fixed
    public string PrimaryFixed => "#00515B";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#003940";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#00515B";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#003940";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#264A79";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#053361";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#ECF1FD";
    public string SurfaceContainer => "#DEE2EF";
    public string SurfaceContainerHigh => "#D0D4E0";
    public string SurfaceContainerHighest => "#C2C6D2";
}
