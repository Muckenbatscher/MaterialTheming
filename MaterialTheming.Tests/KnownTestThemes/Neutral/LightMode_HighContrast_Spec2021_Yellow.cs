namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class LightMode_HighContrast_Spec2021_Yellow : ITestTheme
{
    public string SourceColor => "#B2B037"; //Yellow
    public bool IsDark => false;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#2E2D1B";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#4B4A36";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#2D2D21";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#4B4A3C";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#2E2D14";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#4B4A2F";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#600004";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#98000A";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#FDF9F4";
    public string SurfaceVariant => "#E6E2DD";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#000000";
    public string SurfaceDim => "#BBB8B4";
    public string SurfaceBright => "#FDF9F4";
    public string SurfaceTint => "#615F4A";
    // Background
    public string Background => "#FDF9F4";
    public string OnBackground => "#1C1C19";
    // Outline
    public string Outline => "#2D2C29";
    public string OutlineVariant => "#4A4946";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#31302D";
    public string InverseOnSurface => "#FFFFFF";
    public string InversePrimary => "#CAC7AD";
    // Primary Fixed
    public string PrimaryFixed => "#4B4A36";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#343421";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#4B4A3C";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#343327";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#4B4A2F";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#34341A";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F4F0EB";
    public string SurfaceContainer => "#E6E2DD";
    public string SurfaceContainerHigh => "#D7D4CF";
    public string SurfaceContainerHighest => "#C9C6C2";
}
