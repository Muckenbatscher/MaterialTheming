namespace MaterialTheming.Tests.KnownTestThemes.Content;

internal class LightMode_HighContrast_Spec2025_Blue : ITestTheme
{
    public string SourceColor => "#185FAA"; //Blue
    public bool IsDark => false;
    public Variant Variant => Variant.Content;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#002C58";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#00498B";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#182D49";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#364A67";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#490D5E";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#6A307E";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#600004";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#98000A";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#F9F9FF";
    public string SurfaceVariant => "#DEE2EF";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#000000";
    public string SurfaceDim => "#B7B8BF";
    public string SurfaceBright => "#F9F9FF";
    public string SurfaceTint => "#185FAA";
    // Background
    public string Background => "#F9F9FF";
    public string OnBackground => "#191C21";
    // Outline
    public string Outline => "#272C36";
    public string OutlineVariant => "#444953";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#2E3036";
    public string InverseOnSurface => "#FFFFFF";
    public string InversePrimary => "#A6C8FF";
    // Primary Fixed
    public string PrimaryFixed => "#00498B";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#003363";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#364A67";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#1F3350";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#6A307E";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#501665";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#EFF0F7";
    public string SurfaceContainer => "#E1E2E9";
    public string SurfaceContainerHigh => "#D3D4DB";
    public string SurfaceContainerHighest => "#C5C6CD";
}
