namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class DarkMode_NormalContrast_Spec2025_Purple : ITestTheme
{
    public string SourceColor => "#945CCD"; //Purple
    public bool IsDark => true;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#E8CDFF";
    public string OnPrimary => "#5A3F75";
    public string PrimaryContainer => "#DDBCFC";
    public string OnPrimaryContainer => "#51366C";
    // Secondary
    public string Secondary => "#BACCB3";
    public string OnSecondary => "#354432";
    public string SecondaryContainer => "#1B2919";
    public string OnSecondaryContainer => "#97A991";
    // Tertiary
    public string Tertiary => "#EDFFE0";
    public string OnTertiary => "#356B23";
    public string TertiaryContainer => "#BDFCA2";
    public string OnTertiaryContainer => "#2C621B";
    // Error
    public string Error => "#FD6F85";
    public string OnError => "#490013";
    public string ErrorContainer => "#8A1632";
    public string OnErrorContainer => "#FF97A3";
    // Surface
    public string Surface => "#120B19";
    public string SurfaceVariant => "#2E203B";
    public string OnSurface => "#F2DFFF";
    public string OnSurfaceVariant => "#B7A4C7";
    public string SurfaceDim => "#120B19";
    public string SurfaceBright => "#352545";
    public string SurfaceTint => "#E8CDFF";
    // Background
    public string Background => "#120B19";
    public string OnBackground => "#F2DFFF";
    // Outline
    public string Outline => "#806F8F";
    public string OutlineVariant => "#514260";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#FFF7FE";
    public string InverseOnSurface => "#5B5163";
    public string InversePrimary => "#6F538B";
    // Primary Fixed
    public string PrimaryFixed => "#DDBCFC";
    public string OnPrimaryFixed => "#3C2256";
    public string PrimaryFixedDim => "#CFAEED";
    public string OnPrimaryFixedVariant => "#5A3F75";
    // Secondary Fixed
    public string SecondaryFixed => "#E4F6DC";
    public string OnSecondaryFixed => "#3D4C39";
    public string SecondaryFixedDim => "#D6E8CE";
    public string OnSecondaryFixedVariant => "#596954";
    // Tertiary Fixed
    public string TertiaryFixed => "#BFFFA4";
    public string OnTertiaryFixed => "#1B510A";
    public string TertiaryFixedDim => "#B2F097";
    public string OnTertiaryFixedVariant => "#386F26";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#181021";
    public string SurfaceContainer => "#1F152A";
    public string SurfaceContainerHigh => "#261A32";
    public string SurfaceContainerHighest => "#2E203B";
}
