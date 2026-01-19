namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class LightMode_NormalContrast_Spec2021_Blue : ITestTheme
{
    public string SourceColor => "#185FAA"; //Blue
    public bool IsDark => false;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#3D5F90";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#D5E3FF";
    public string OnPrimaryContainer => "#234776";
    // Secondary
    public string Secondary => "#555F71";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#D9E3F8";
    public string OnSecondaryContainer => "#3D4758";
    // Tertiary
    public string Tertiary => "#6E5676";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#F7D8FF";
    public string OnTertiaryContainer => "#553F5D";
    // Error
    public string Error => "#BA1A1A";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#FFDAD6";
    public string OnErrorContainer => "#93000A";
    // Surface
    public string Surface => "#F9F9FF";
    public string SurfaceVariant => "#E0E2EC";
    public string OnSurface => "#191C20";
    public string OnSurfaceVariant => "#43474E";
    public string SurfaceDim => "#D9DAE0";
    public string SurfaceBright => "#F9F9FF";
    public string SurfaceTint => "#3D5F90";
    // Background
    public string Background => "#F9F9FF";
    public string OnBackground => "#191C20";
    // Outline
    public string Outline => "#74777F";
    public string OutlineVariant => "#C4C6CF";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#2E3035";
    public string InverseOnSurface => "#F0F0F7";
    public string InversePrimary => "#A6C8FF";
    // Primary Fixed
    public string PrimaryFixed => "#D5E3FF";
    public string OnPrimaryFixed => "#001C3B";
    public string PrimaryFixedDim => "#A6C8FF";
    public string OnPrimaryFixedVariant => "#234776";
    // Secondary Fixed
    public string SecondaryFixed => "#D9E3F8";
    public string OnSecondaryFixed => "#121C2B";
    public string SecondaryFixedDim => "#BDC7DC";
    public string OnSecondaryFixedVariant => "#3D4758";
    // Tertiary Fixed
    public string TertiaryFixed => "#F7D8FF";
    public string OnTertiaryFixed => "#27142F";
    public string TertiaryFixedDim => "#DABDE2";
    public string OnTertiaryFixedVariant => "#553F5D";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F3F3FA";
    public string SurfaceContainer => "#EDEDF4";
    public string SurfaceContainerHigh => "#E7E8EE";
    public string SurfaceContainerHighest => "#E1E2E9";
}
