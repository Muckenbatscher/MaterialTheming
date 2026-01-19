namespace MaterialTheming.Tests.KnownTestThemes.Content;

internal class LightMode_HighContrast_Spec2021_Purple : ITestTheme
{
    public string SourceColor => "#945CCD"; //Purple
    public bool IsDark => false;
    public Variant Variant => Variant.Content;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#430077";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#632A9B";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#37234C";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#55406B";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#5B0038";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#861D58";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#600004";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#98000A";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#FFF7FE";
    public string SurfaceVariant => "#EBDEF0";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#000000";
    public string SurfaceDim => "#BEB6C0";
    public string SurfaceBright => "#FFF7FE";
    public string SurfaceTint => "#7A42B2";
    // Background
    public string Background => "#FFF7FE";
    public string OnBackground => "#1E1A21";
    // Outline
    public string Outline => "#302936";
    public string OutlineVariant => "#4E4654";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#332F36";
    public string InverseOnSurface => "#FFFFFF";
    public string InversePrimary => "#DCB8FF";
    // Primary Fixed
    public string PrimaryFixed => "#632A9B";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#4B0683";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#55406B";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#3E2953";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#861D58";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#670040";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F7EEF8";
    public string SurfaceContainer => "#E9E0EA";
    public string SurfaceContainerHigh => "#DAD2DC";
    public string SurfaceContainerHighest => "#CCC4CE";
}
