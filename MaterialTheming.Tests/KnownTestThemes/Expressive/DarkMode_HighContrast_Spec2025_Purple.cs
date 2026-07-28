namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class DarkMode_HighContrast_Spec2025_Purple : ITestTheme
{
    public string SourceColor => "#945CCD"; //Purple
    public bool IsDark => true;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#F2DFFF";
    public string OnPrimary => "#391F54";
    public string PrimaryContainer => "#B697D4";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#D9EBD1";
    public string OnSecondary => "#21301F";
    public string SecondaryContainer => "#97A991";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#EDFFE0";
    public string OnTertiary => "#0D4200";
    public string TertiaryContainer => "#BDFCA2";
    public string OnTertiaryContainer => "#0A3800";
    // Error
    public string Error => "#FFDDDF";
    public string OnError => "#5F001C";
    public string ErrorContainer => "#FF798C";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#120B19";
    public string SurfaceVariant => "#2E203B";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#F2DFFF";
    public string SurfaceDim => "#120B19";
    public string SurfaceBright => "#352545";
    public string SurfaceTint => "#F2DFFF";
    // Background
    public string Background => "#120B19";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#C5B1D5";
    public string OutlineVariant => "#B09CBF";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#FFF7FE";
    public string InverseOnSurface => "#000000";
    public string InversePrimary => "#462C61";
    // Primary Fixed
    public string PrimaryFixed => "#DDBCFC";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#CFAEED";
    public string OnPrimaryFixedVariant => "#000000";
    // Secondary Fixed
    public string SecondaryFixed => "#E4F6DC";
    public string OnSecondaryFixed => "#000000";
    public string SecondaryFixedDim => "#D6E8CE";
    public string OnSecondaryFixedVariant => "#1F2E1D";
    // Tertiary Fixed
    public string TertiaryFixed => "#BFFFA4";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#B2F097";
    public string OnTertiaryFixedVariant => "#072F00";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#181021";
    public string SurfaceContainer => "#1F152A";
    public string SurfaceContainerHigh => "#261A32";
    public string SurfaceContainerHighest => "#2E203B";
}
