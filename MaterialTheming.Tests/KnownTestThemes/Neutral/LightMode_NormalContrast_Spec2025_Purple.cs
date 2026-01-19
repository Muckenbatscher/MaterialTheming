namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class LightMode_NormalContrast_Spec2025_Purple : ITestTheme
{
    public string SourceColor => "#945CCD"; //Purple
    public bool IsDark => false;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#625C65";
    public string OnPrimary => "#FEF5FF";
    public string PrimaryContainer => "#E9DFEB";
    public string OnPrimaryContainer => "#555059";
    // Secondary
    public string Secondary => "#625E62";
    public string OnSecondary => "#FEF7FC";
    public string SecondaryContainer => "#E7E1E5";
    public string OnSecondaryContainer => "#545155";
    // Tertiary
    public string Tertiary => "#615B77";
    public string OnTertiary => "#FCF7FF";
    public string TertiaryContainer => "#E1D8FA";
    public string OnTertiaryContainer => "#504B66";
    // Error
    public string Error => "#9E3F4E";
    public string OnError => "#FFF7F7";
    public string ErrorContainer => "#FF8B9A";
    public string OnErrorContainer => "#782232";
    // Surface
    public string Surface => "#FDF8F9";
    public string SurfaceVariant => "#E7E1E4";
    public string OnSurface => "#343234";
    public string OnSurfaceVariant => "#615E61";
    public string SurfaceDim => "#DED8DC";
    public string SurfaceBright => "#FDF8F9";
    public string SurfaceTint => "#625C65";
    // Background
    public string Background => "#FDF8F9";
    public string OnBackground => "#343234";
    // Outline
    public string Outline => "#7D797D";
    public string OutlineVariant => "#B5B0B4";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#0F0E0F";
    public string InverseOnSurface => "#9F9C9D";
    public string InversePrimary => "#FDF3FF";
    // Primary Fixed
    public string PrimaryFixed => "#E9DFEB";
    public string OnPrimaryFixed => "#433D46";
    public string PrimaryFixedDim => "#DBD1DC";
    public string OnPrimaryFixedVariant => "#5F5963";
    // Secondary Fixed
    public string SecondaryFixed => "#E7E1E5";
    public string OnSecondaryFixed => "#413E42";
    public string SecondaryFixedDim => "#D9D3D7";
    public string OnSecondaryFixedVariant => "#5E5A5E";
    // Tertiary Fixed
    public string TertiaryFixed => "#E1D8FA";
    public string OnTertiaryFixed => "#3D3852";
    public string TertiaryFixedDim => "#D3CAEB";
    public string OnTertiaryFixedVariant => "#5A5470";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F7F2F4";
    public string SurfaceContainer => "#F2ECEF";
    public string SurfaceContainerHigh => "#ECE7E9";
    public string SurfaceContainerHighest => "#E7E1E4";
}
