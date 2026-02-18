namespace MaterialTheming.Tests.KnownTestThemes.FruitSalad;

internal class DarkMode_MediumContrast_Spec2026_Cyan : ITestTheme
{
    public string SourceColor => "#00BCD1"; //Cyan
    public bool IsDark => true;
    public Variant Variant => Variant.FruitSalad;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#8CF1B6";
    public string OnPrimary => "#002C18";
    public string PrimaryContainer => "#3CA36F";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#A7EBC0";
    public string OnSecondary => "#002C18";
    public string SecondaryContainer => "#5D9E78";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#98E9F8";
    public string OnTertiary => "#002A30";
    public string TertiaryContainer => "#499CAA";
    public string OnTertiaryContainer => "#000000";
    // Error
    public string Error => "#FFD2CC";
    public string OnError => "#540003";
    public string ErrorContainer => "#FF5449";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#091517";
    public string SurfaceVariant => "#334B4F";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#C7E1E6";
    public string SurfaceDim => "#091517";
    public string SurfaceBright => "#3A4749";
    public string SurfaceTint => "#76DAA2";
    // Background
    public string Background => "#091517";
    public string OnBackground => "#D7E5E8";
    // Outline
    public string Outline => "#9DB6BB";
    public string OutlineVariant => "#7C959A";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#D7E5E8";
    public string InverseOnSurface => "#202C2E";
    public string InversePrimary => "#005332";
    // Primary Fixed
    public string PrimaryFixed => "#92F7BC";
    public string OnPrimaryFixed => "#001509";
    public string PrimaryFixedDim => "#76DAA2";
    public string OnPrimaryFixedVariant => "#003F25";
    // Secondary Fixed
    public string SecondaryFixed => "#ADF2C6";
    public string OnSecondaryFixed => "#001509";
    public string SecondaryFixedDim => "#92D5AB";
    public string OnSecondaryFixedVariant => "#003F25";
    // Tertiary Fixed
    public string TertiaryFixed => "#9EEFFE";
    public string OnTertiaryFixed => "#001417";
    public string TertiaryFixedDim => "#82D3E1";
    public string OnTertiaryFixedVariant => "#003C44";
    // Surface Container
    public string SurfaceContainerLowest => "#01090B";
    public string SurfaceContainerLow => "#131F22";
    public string SurfaceContainer => "#1E2A2C";
    public string SurfaceContainerHigh => "#283537";
    public string SurfaceContainerHighest => "#334042";
}
