namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class LightMode_NormalContrast_Spec2021_Yellow : ITestTheme
{
    public string SourceColor => "#B2B037"; //Yellow
    public bool IsDark => false;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#8C486C";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#FFD8E8";
    public string OnPrimaryContainer => "#703054";
    // Secondary
    public string Secondary => "#45664C";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#C6ECCC";
    public string OnSecondaryContainer => "#2D4E36";
    // Tertiary
    public string Tertiary => "#506530";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#D2ECA9";
    public string OnTertiaryContainer => "#394D1B";
    // Error
    public string Error => "#BA1A1A";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#FFDAD6";
    public string OnErrorContainer => "#93000A";
    // Surface
    public string Surface => "#FAFBEA";
    public string SurfaceVariant => "#E1E5CC";
    public string OnSurface => "#1A1D13";
    public string OnSurfaceVariant => "#444937";
    public string SurfaceDim => "#DADBCB";
    public string SurfaceBright => "#FAFBEA";
    public string SurfaceTint => "#8C486C";
    // Background
    public string Background => "#FAFBEA";
    public string OnBackground => "#1A1D13";
    // Outline
    public string Outline => "#757965";
    public string OutlineVariant => "#C4C9B1";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#2F3227";
    public string InverseOnSurface => "#F1F2E2";
    public string InversePrimary => "#FFAFD6";
    // Primary Fixed
    public string PrimaryFixed => "#FFD8E8";
    public string OnPrimaryFixed => "#3B0327";
    public string PrimaryFixedDim => "#FFAFD6";
    public string OnPrimaryFixedVariant => "#703054";
    // Secondary Fixed
    public string SecondaryFixed => "#C6ECCC";
    public string OnSecondaryFixed => "#01210D";
    public string SecondaryFixedDim => "#ABD0B1";
    public string OnSecondaryFixedVariant => "#2D4E36";
    // Tertiary Fixed
    public string TertiaryFixed => "#D2ECA9";
    public string OnTertiaryFixed => "#111F00";
    public string TertiaryFixedDim => "#B6CF8F";
    public string OnTertiaryFixedVariant => "#394D1B";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F4F5E4";
    public string SurfaceContainer => "#EEEFDF";
    public string SurfaceContainerHigh => "#E8E9D9";
    public string SurfaceContainerHighest => "#E2E4D4";
}
