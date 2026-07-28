namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class DarkMode_MediumContrast_Spec2025_Purple : ITestTheme
{
    public string SourceColor => "#945CCD"; //Purple
    public bool IsDark => true;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#DDBCFC";
    public string OnPrimary => "#462C61";
    public string PrimaryContainer => "#8568A2";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#BACCB3";
    public string OnSecondary => "#2B3A28";
    public string SecondaryContainer => "#697964";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#EDFFE0";
    public string OnTertiary => "#2B6119";
    public string TertiaryContainer => "#BDFCA2";
    public string OnTertiaryContainer => "#225811";
    // Error
    public string Error => "#FF9DA8";
    public string OnError => "#5F001C";
    public string ErrorContainer => "#C8475D";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#120B19";
    public string SurfaceVariant => "#2E203B";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#C5B1D5";
    public string SurfaceDim => "#120B19";
    public string SurfaceBright => "#352545";
    public string SurfaceTint => "#DDBCFC";
    // Background
    public string Background => "#120B19";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#9F8CAE";
    public string OutlineVariant => "#806F8F";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#FFF7FE";
    public string InverseOnSurface => "#3E3545";
    public string InversePrimary => "#654980";
    // Primary Fixed
    public string PrimaryFixed => "#DDBCFC";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#CFAEED";
    public string OnPrimaryFixedVariant => "#3C2256";
    // Secondary Fixed
    public string SecondaryFixed => "#E4F6DC";
    public string OnSecondaryFixed => "#1F2E1D";
    public string SecondaryFixedDim => "#D6E8CE";
    public string OnSecondaryFixedVariant => "#3D4C39";
    // Tertiary Fixed
    public string TertiaryFixed => "#BFFFA4";
    public string OnTertiaryFixed => "#072F00";
    public string TertiaryFixedDim => "#B2F097";
    public string OnTertiaryFixedVariant => "#1B510A";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#181021";
    public string SurfaceContainer => "#1F152A";
    public string SurfaceContainerHigh => "#261A32";
    public string SurfaceContainerHighest => "#2E203B";
}
