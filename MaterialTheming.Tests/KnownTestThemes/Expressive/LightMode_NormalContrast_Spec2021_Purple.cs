namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class LightMode_NormalContrast_Spec2021_Purple : ITestTheme
{
    public string SourceColor => "#945CCD"; //Purple
    public bool IsDark => false;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#006A64";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#90F3EA";
    public string OnPrimaryContainer => "#00504B";
    // Secondary
    public string Secondary => "#7C5263";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#FFD9E5";
    public string OnSecondaryContainer => "#623B4B";
    // Tertiary
    public string Tertiary => "#7A5079";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#FFD6FA";
    public string OnTertiaryContainer => "#603960";
    // Error
    public string Error => "#BA1A1A";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#FFDAD6";
    public string OnErrorContainer => "#93000A";
    // Surface
    public string Surface => "#FFF7FA";
    public string SurfaceVariant => "#EFDDED";
    public string OnSurface => "#201920";
    public string OnSurfaceVariant => "#4F4350";
    public string SurfaceDim => "#E3D6E0";
    public string SurfaceBright => "#FFF7FA";
    public string SurfaceTint => "#006A64";
    // Background
    public string Background => "#FFF7FA";
    public string OnBackground => "#201920";
    // Outline
    public string Outline => "#817381";
    public string OutlineVariant => "#D3C1D1";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#362E36";
    public string InverseOnSurface => "#FAEDF7";
    public string InversePrimary => "#73D7CE";
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
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FDF0FA";
    public string SurfaceContainer => "#F8EAF4";
    public string SurfaceContainerHigh => "#F2E4EE";
    public string SurfaceContainerHighest => "#ECDFE9";
}
