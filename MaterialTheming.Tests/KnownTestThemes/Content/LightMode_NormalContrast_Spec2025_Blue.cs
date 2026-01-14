using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Content;

internal class LightMode_NormalContrast_Spec2025_Blue : ITestTheme
{
    public string SourceColor => "#185FAA"; //Blue
    public bool IsDark => false;
    public Variant Variant => Variant.Content;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#004787";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#185FAA";
    public string OnPrimaryContainer => "#C5DAFF";
    // Secondary
    public string Secondary => "#4C5F7E";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#C7DBFF";
    public string OnSecondaryContainer => "#4C607F";
    // Tertiary
    public string Tertiary => "#672D7B";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#814695";
    public string OnTertiaryContainer => "#F6CAFF";
    // Error
    public string Error => "#BA1A1A";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#FFDAD6";
    public string OnErrorContainer => "#93000A";
    // Surface
    public string Surface => "#F9F9FF";
    public string SurfaceVariant => "#DEE2EF";
    public string OnSurface => "#191C21";
    public string OnSurfaceVariant => "#424751";
    public string SurfaceDim => "#D9DAE0";
    public string SurfaceBright => "#F9F9FF";
    public string SurfaceTint => "#185FAA";
    // Background
    public string Background => "#F9F9FF";
    public string OnBackground => "#191C21";
    // Outline
    public string Outline => "#727782";
    public string OutlineVariant => "#C2C6D3";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#2E3036";
    public string InverseOnSurface => "#EFF0F7";
    public string InversePrimary => "#A6C8FF";
    // Primary Fixed
    public string PrimaryFixed => "#D5E3FF";
    public string OnPrimaryFixed => "#001C3B";
    public string PrimaryFixedDim => "#A6C8FF";
    public string OnPrimaryFixedVariant => "#004787";
    // Secondary Fixed
    public string SecondaryFixed => "#D5E3FF";
    public string OnSecondaryFixed => "#051C37";
    public string SecondaryFixedDim => "#B3C7EB";
    public string OnSecondaryFixedVariant => "#344765";
    // Tertiary Fixed
    public string TertiaryFixed => "#FAD7FF";
    public string OnTertiaryFixed => "#330045";
    public string TertiaryFixedDim => "#EEB0FF";
    public string OnTertiaryFixedVariant => "#672D7B";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F2F3FA";
    public string SurfaceContainer => "#EDEDF4";
    public string SurfaceContainerHigh => "#E7E8EF";
    public string SurfaceContainerHighest => "#E1E2E9";
}
