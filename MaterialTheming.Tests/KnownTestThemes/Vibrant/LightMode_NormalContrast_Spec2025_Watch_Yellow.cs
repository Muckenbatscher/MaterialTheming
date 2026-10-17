namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class LightMode_NormalContrast_Spec2025_Watch_Yellow : ITestTheme
{
    public string SourceColor => "#B2B037"; //Yellow
    public bool IsDark => false;
    public Variant Variant => Variant.Vibrant;
    public Platform Platform => Platform.Watch;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#FFFC80";
    public string OnPrimary => "#4F4E00";
    public string PrimaryContainer => "#4A4900";
    public string OnPrimaryContainer => "#E8E56C";
    // Secondary
    public string Secondary => "#EDE68C";
    public string OnSecondary => "#454100";
    public string SecondaryContainer => "#4D4800";
    public string OnSecondaryContainer => "#EBE38A";
    // Tertiary
    public string Tertiary => "#98FDC1";
    public string OnTertiary => "#004D2E";
    public string TertiaryContainer => "#7CE0A6";
    public string OnTertiaryContainer => "#004327";
    // Error
    public string Error => "#FFBFB0";
    public string OnError => "#3B0600";
    public string ErrorContainer => "#7D2C19";
    public string OnErrorContainer => "#FFD7CE";
    // Surface
    public string Surface => "#000000";
    public string SurfaceVariant => "#292700";
    public string OnSurface => "#EFEABA";
    public string OnSurfaceVariant => "#D5D0A1";
    public string SurfaceDim => "#100F00";
    public string SurfaceBright => "#302D00";
    public string SurfaceTint => "#FFFC80";
    // Background
    public string Background => "#000000";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#ACA77C";
    public string OutlineVariant => "#8B875E";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#FFFADF";
    public string InverseOnSurface => "#595631";
    public string InversePrimary => "#595800";
    // Primary Fixed
    public string PrimaryFixed => "#FFFC80";
    public string OnPrimaryFixed => "#4F4E00";
    public string PrimaryFixedDim => "#F0EE73";
    public string OnPrimaryFixedVariant => "#4A4900";
    // Secondary Fixed
    public string SecondaryFixed => "#EDE68C";
    public string OnSecondaryFixed => "#454100";
    public string SecondaryFixedDim => "#DFD780";
    public string OnSecondaryFixedVariant => "#4D4800";
    // Tertiary Fixed
    public string TertiaryFixed => "#98FDC1";
    public string OnTertiaryFixed => "#004D2E";
    public string TertiaryFixedDim => "#8AEEB4";
    public string OnTertiaryFixedVariant => "#005231";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#292707";
    public string SurfaceContainer => "#343110";
    public string SurfaceContainerHigh => "#3F3C1A";
    public string SurfaceContainerHighest => "#292700";
}
