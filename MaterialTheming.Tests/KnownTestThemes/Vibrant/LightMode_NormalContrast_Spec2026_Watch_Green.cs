namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class LightMode_NormalContrast_Spec2026_Watch_Green : ITestTheme
{
    public string SourceColor => "#338745"; //Green
    public bool IsDark => false;
    public Variant Variant => Variant.Vibrant;
    public Platform Platform => Platform.Watch;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#ACFEB2";
    public string OnPrimary => "#00501E";
    public string PrimaryContainer => "#00531F";
    public string OnPrimaryContainer => "#A1F3A8";
    // Secondary
    public string Secondary => "#B8F1B9";
    public string OnSecondary => "#154921";
    public string SecondaryContainer => "#1D5128";
    public string OnSecondaryContainer => "#B5EEB7";
    // Tertiary
    public string Tertiary => "#6CF2FF";
    public string OnTertiary => "#00454A";
    public string TertiaryContainer => "#49D6E2";
    public string OnTertiaryContainer => "#003B3F";
    // Error
    public string Error => "#FFBFB0";
    public string OnError => "#3B0600";
    public string ErrorContainer => "#7D2C19";
    public string OnErrorContainer => "#FFD7CE";
    // Surface
    public string Surface => "#000000";
    public string SurfaceVariant => "#0C2C13";
    public string OnSurface => "#D4EFD1";
    public string OnSurfaceVariant => "#BBD5B8";
    public string SurfaceDim => "#001203";
    public string SurfaceBright => "#113317";
    public string SurfaceTint => "#ACFEB2";
    // Background
    public string Background => "#000000";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#93AC91";
    public string OutlineVariant => "#738C72";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#EBFFE7";
    public string InverseOnSurface => "#435B44";
    public string InversePrimary => "#0B6328";
    // Primary Fixed
    public string PrimaryFixed => "#ACFEB2";
    public string OnPrimaryFixed => "#00501E";
    public string PrimaryFixedDim => "#9EF0A5";
    public string OnPrimaryFixedVariant => "#00531F";
    // Secondary Fixed
    public string SecondaryFixed => "#B8F1B9";
    public string OnSecondaryFixed => "#154921";
    public string SecondaryFixedDim => "#AAE2AC";
    public string OnSecondaryFixedVariant => "#1D5128";
    // Tertiary Fixed
    public string TertiaryFixed => "#6CF2FF";
    public string OnTertiaryFixed => "#00454A";
    public string TertiaryFixedDim => "#5BE4F0";
    public string OnTertiaryFixedVariant => "#004F55";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#152A17";
    public string SurfaceContainer => "#1F3521";
    public string SurfaceContainerHigh => "#2A412C";
    public string SurfaceContainerHighest => "#0C2C13";
}
