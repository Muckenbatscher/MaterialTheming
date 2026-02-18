namespace MaterialTheming.Tests.KnownTestThemes.FruitSalad;

internal class LightMode_MediumContrast_Spec2026_Cyan : ITestTheme
{
    public string SourceColor => "#00BCD1"; //Cyan
    public bool IsDark => false;
    public Variant Variant => Variant.FruitSalad;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#003F25";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#007D4E";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#003F25";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#387956";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#003C44";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#197885";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#740006";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#CF2C27";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#EEFCFF";
    public string SurfaceVariant => "#CDE7EC";
    public string OnSurface => "#071315";
    public string OnSurfaceVariant => "#223A3E";
    public string SurfaceDim => "#BBC9CC";
    public string SurfaceBright => "#EEFCFF";
    public string SurfaceTint => "#006D43";
    // Background
    public string Background => "#EEFCFF";
    public string OnBackground => "#111D20";
    // Outline
    public string Outline => "#3E565B";
    public string OutlineVariant => "#597176";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#263235";
    public string InverseOnSurface => "#E6F3F6";
    public string InversePrimary => "#76DAA2";
    // Primary Fixed
    public string PrimaryFixed => "#007D4E";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#00623C";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#387956";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#1D603F";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#197885";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#005E69";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#E9F6F9";
    public string SurfaceContainer => "#DDEBED";
    public string SurfaceContainerHigh => "#D2DFE2";
    public string SurfaceContainerHighest => "#C7D4D7";
}
