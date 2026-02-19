namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class DarkMode_HighContrast_Spec2026_Yellow : ITestTheme
{
    public string SourceColor => "#B2B037"; //Yellow
    public bool IsDark => true;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#E9E6D4";
    public string OnPrimary => "#2D2C21";
    public string PrimaryContainer => "#A7A494";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#E9E5DC";
    public string OnSecondary => "#2D2C26";
    public string SecondaryContainer => "#A6A39C";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#F7FDD0";
    public string OnTertiary => "#353B1C";
    public string TertiaryContainer => "#E9EFC2";
    public string OnTertiaryContainer => "#2D3214";
    // Error
    public string Error => "#FFDED7";
    public string OnError => "#591001";
    public string ErrorContainer => "#F48469";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#0F0E0D";
    public string SurfaceVariant => "#272622";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#E9E5DE";
    public string SurfaceDim => "#0F0E0D";
    public string SurfaceBright => "#2D2C27";
    public string SurfaceTint => "#E9E6D4";
    // Background
    public string Background => "#0F0E0D";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#BBB8B2";
    public string OutlineVariant => "#A6A39D";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#FDF9F5";
    public string InverseOnSurface => "#000000";
    public string InversePrimary => "#3A392C";
    // Primary Fixed
    public string PrimaryFixed => "#E6E3D1";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#D8D5C3";
    public string OnPrimaryFixedVariant => "#202015";
    // Secondary Fixed
    public string SecondaryFixed => "#E6E2D9";
    public string OnSecondaryFixed => "#000000";
    public string SecondaryFixedDim => "#D8D4CC";
    public string OnSecondaryFixedVariant => "#20201A";
    // Tertiary Fixed
    public string TertiaryFixed => "#F2F8CA";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#E3E9BD";
    public string OnTertiaryFixedVariant => "#292E10";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#141311";
    public string SurfaceContainer => "#1A1A17";
    public string SurfaceContainerHigh => "#20201C";
    public string SurfaceContainerHighest => "#272622";
}
