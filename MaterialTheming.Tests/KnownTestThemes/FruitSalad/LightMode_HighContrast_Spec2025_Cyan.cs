namespace MaterialTheming.Tests.KnownTestThemes.FruitSalad;

internal class LightMode_HighContrast_Spec2025_Cyan : ITestTheme
{
    public string SourceColor => "#00BCD1"; //Cyan
    public bool IsDark => false;
    public Variant Variant => Variant.FruitSalad;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#00341D";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#005533";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#00341D";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#0B5434";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#003138";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#00515B";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#600004";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#98000A";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#EEFCFF";
    public string SurfaceVariant => "#CDE7EC";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#000000";
    public string SurfaceDim => "#AEBBBE";
    public string SurfaceBright => "#EEFCFF";
    public string SurfaceTint => "#006D43";
    // Background
    public string Background => "#EEFCFF";
    public string OnBackground => "#111D20";
    // Outline
    public string Outline => "#173034";
    public string OutlineVariant => "#354D51";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#263235";
    public string InverseOnSurface => "#FFFFFF";
    public string InversePrimary => "#76DAA2";
    // Primary Fixed
    public string PrimaryFixed => "#005533";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#003B22";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#0B5434";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#003B22";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#00515B";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#003940";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#E6F3F6";
    public string SurfaceContainer => "#D7E5E8";
    public string SurfaceContainerHigh => "#C9D7DA";
    public string SurfaceContainerHighest => "#BBC9CC";
}
