namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class LightMode_NormalContrast_Spec2021_Green : ITestTheme
{
    public string SourceColor => "#338745"; //Green
    public bool IsDark => false;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#006E2B";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#69FF89";
    public string OnPrimaryContainer => "#00531F";
    // Secondary
    public string Secondary => "#406653";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#C2ECD3";
    public string OnSecondaryContainer => "#284E3C";
    // Tertiary
    public string Tertiary => "#22695B";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#ABF0DE";
    public string OnTertiaryContainer => "#005144";
    // Error
    public string Error => "#BA1A1A";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#FFDAD6";
    public string OnErrorContainer => "#93000A";
    // Surface
    public string Surface => "#F2FCEE";
    public string SurfaceVariant => "#D9E6D5";
    public string OnSurface => "#151E15";
    public string OnSurfaceVariant => "#3E4A3D";
    public string SurfaceDim => "#D3DDCF";
    public string SurfaceBright => "#F2FCEE";
    public string SurfaceTint => "#006E2B";
    // Background
    public string Background => "#F2FCEE";
    public string OnBackground => "#151E15";
    // Outline
    public string Outline => "#6E7A6C";
    public string OutlineVariant => "#BDCABA";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#2A3329";
    public string InverseOnSurface => "#E9F4E5";
    public string InversePrimary => "#00E563";
    // Primary Fixed
    public string PrimaryFixed => "#69FF89";
    public string OnPrimaryFixed => "#002108";
    public string PrimaryFixedDim => "#00E563";
    public string OnPrimaryFixedVariant => "#00531F";
    // Secondary Fixed
    public string SecondaryFixed => "#C2ECD3";
    public string OnSecondaryFixed => "#002114";
    public string SecondaryFixedDim => "#A6D0B8";
    public string OnSecondaryFixedVariant => "#284E3C";
    // Tertiary Fixed
    public string TertiaryFixed => "#ABF0DE";
    public string OnTertiaryFixed => "#00201A";
    public string TertiaryFixedDim => "#8FD4C2";
    public string OnTertiaryFixedVariant => "#005144";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#ECF7E8";
    public string SurfaceContainer => "#E7F1E2";
    public string SurfaceContainerHigh => "#E1EBDD";
    public string SurfaceContainerHighest => "#DBE5D7";
}
