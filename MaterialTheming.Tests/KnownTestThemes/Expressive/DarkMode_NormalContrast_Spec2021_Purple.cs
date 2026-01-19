namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class DarkMode_NormalContrast_Spec2021_Purple : ITestTheme
{
    public string SourceColor => "#945CCD"; //Purple
    public bool IsDark => true;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#73D7CE";
    public string OnPrimary => "#003734";
    public string PrimaryContainer => "#00504B";
    public string OnPrimaryContainer => "#90F3EA";
    // Secondary
    public string Secondary => "#EEB8CB";
    public string OnSecondary => "#492534";
    public string SecondaryContainer => "#623B4B";
    public string OnSecondaryContainer => "#FFD9E5";
    // Tertiary
    public string Tertiary => "#E9B6E6";
    public string OnTertiary => "#472348";
    public string TertiaryContainer => "#603960";
    public string OnTertiaryContainer => "#FFD6FA";
    // Error
    public string Error => "#FFB4AB";
    public string OnError => "#690005";
    public string ErrorContainer => "#93000A";
    public string OnErrorContainer => "#FFDAD6";
    // Surface
    public string Surface => "#181118";
    public string SurfaceVariant => "#4F4350";
    public string OnSurface => "#ECDFE9";
    public string OnSurfaceVariant => "#D3C1D1";
    public string SurfaceDim => "#181118";
    public string SurfaceBright => "#3F373E";
    public string SurfaceTint => "#73D7CE";
    // Background
    public string Background => "#181118";
    public string OnBackground => "#ECDFE9";
    // Outline
    public string Outline => "#9C8C9B";
    public string OutlineVariant => "#4F4350";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#ECDFE9";
    public string InverseOnSurface => "#362E36";
    public string InversePrimary => "#006A64";
    // Primary Fixed
    public string PrimaryFixed => "#90F3EA";
    public string OnPrimaryFixed => "#00201E";
    public string PrimaryFixedDim => "#73D7CE";
    public string OnPrimaryFixedVariant => "#00504B";
    // Secondary Fixed
    public string SecondaryFixed => "#FFD9E5";
    public string OnSecondaryFixed => "#30111F";
    public string SecondaryFixedDim => "#EEB8CB";
    public string OnSecondaryFixedVariant => "#623B4B";
    // Tertiary Fixed
    public string TertiaryFixed => "#FFD6FA";
    public string OnTertiaryFixed => "#2F0D32";
    public string TertiaryFixedDim => "#E9B6E6";
    public string OnTertiaryFixedVariant => "#603960";
    // Surface Container
    public string SurfaceContainerLowest => "#120C13";
    public string SurfaceContainerLow => "#201920";
    public string SurfaceContainer => "#241D24";
    public string SurfaceContainerHigh => "#2F282F";
    public string SurfaceContainerHighest => "#3A323A";
}
