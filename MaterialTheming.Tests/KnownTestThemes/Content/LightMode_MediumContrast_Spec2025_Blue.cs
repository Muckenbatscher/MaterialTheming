namespace MaterialTheming.Tests.KnownTestThemes.Content;

internal class LightMode_MediumContrast_Spec2025_Blue : ITestTheme
{
    public string SourceColor => "#185FAA"; //Blue
    public bool IsDark => false;
    public Variant Variant => Variant.Content;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#003669";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#185FAA";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#233753";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#5A6E8D";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#541B69";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#814695";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#740006";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#CF2C27";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#F9F9FF";
    public string SurfaceVariant => "#DEE2EF";
    public string OnSurface => "#0F1116";
    public string OnSurfaceVariant => "#313640";
    public string SurfaceDim => "#C5C6CD";
    public string SurfaceBright => "#F9F9FF";
    public string SurfaceTint => "#185FAA";
    // Background
    public string Background => "#F9F9FF";
    public string OnBackground => "#191C21";
    // Outline
    public string Outline => "#4D535D";
    public string OutlineVariant => "#686D78";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#2E3036";
    public string InverseOnSurface => "#EFF0F7";
    public string InversePrimary => "#A6C8FF";
    // Primary Fixed
    public string PrimaryFixed => "#2F6EBA";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#00559F";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#5A6E8D";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#425674";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#9155A5";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#773C8B";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F2F3FA";
    public string SurfaceContainer => "#E7E8EF";
    public string SurfaceContainerHigh => "#DBDCE3";
    public string SurfaceContainerHighest => "#D0D1D8";
}
