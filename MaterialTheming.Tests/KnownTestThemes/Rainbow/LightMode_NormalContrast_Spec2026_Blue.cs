namespace MaterialTheming.Tests.KnownTestThemes.Rainbow;

internal class LightMode_NormalContrast_Spec2026_Blue : ITestTheme
{
    public string SourceColor => "#185FAA"; //Blue
    public bool IsDark => false;
    public Variant Variant => Variant.Rainbow;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#205FA6";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#D5E3FF";
    public string OnPrimaryContainer => "#004787";
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
    public string Surface => "#F9F9F9";
    public string SurfaceVariant => "#E2E2E2";
    public string OnSurface => "#1B1B1B";
    public string OnSurfaceVariant => "#474747";
    public string SurfaceDim => "#DADADA";
    public string SurfaceBright => "#F9F9F9";
    public string SurfaceTint => "#205FA6";
    // Background
    public string Background => "#F9F9F9";
    public string OnBackground => "#1B1B1B";
    // Outline
    public string Outline => "#777777";
    public string OutlineVariant => "#C6C6C6";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#303030";
    public string InverseOnSurface => "#F1F1F1";
    public string InversePrimary => "#A6C8FF";
    // Primary Fixed
    public string PrimaryFixed => "#D5E3FF";
    public string OnPrimaryFixed => "#001C3B";
    public string PrimaryFixedDim => "#A6C8FF";
    public string OnPrimaryFixedVariant => "#004787";
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
    public string SurfaceContainerLow => "#F3F3F3";
    public string SurfaceContainer => "#EEEEEE";
    public string SurfaceContainerHigh => "#E8E8E8";
    public string SurfaceContainerHighest => "#E2E2E2";
}
