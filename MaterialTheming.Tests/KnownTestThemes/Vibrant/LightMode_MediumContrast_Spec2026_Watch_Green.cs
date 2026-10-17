namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class LightMode_MediumContrast_Spec2026_Watch_Green : ITestTheme
{
    public string SourceColor => "#338745"; //Green
    public bool IsDark => false;
    public Variant Variant => Variant.Vibrant;
    public Platform Platform => Platform.Watch;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#FFFFFA";
    public string OnPrimary => "#002D0D";
    public string PrimaryContainer => "#479555";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#FFFFFA";
    public string OnSecondary => "#00260A";
    public string SecondaryContainer => "#5D9262";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#FDFFFF";
    public string OnTertiary => "#002124";
    public string TertiaryContainer => "#49D6E2";
    public string OnTertiaryContainer => "#003B3F";
    // Error
    public string Error => "#FFBFB0";
    public string OnError => "#390600";
    public string ErrorContainer => "#CD6951";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#000000";
    public string SurfaceVariant => "#0C2C13";
    public string OnSurface => "#FFFFFA";
    public string OnSurfaceVariant => "#BBD5B8";
    public string SurfaceDim => "#001203";
    public string SurfaceBright => "#113317";
    public string SurfaceTint => "#FFFFFA";
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
    public string InverseOnSurface => "#273D29";
    public string InversePrimary => "#004217";
    // Primary Fixed
    public string PrimaryFixed => "#ACFEB2";
    public string OnPrimaryFixed => "#002D0D";
    public string PrimaryFixedDim => "#9EF0A5";
    public string OnPrimaryFixedVariant => "#00501E";
    // Secondary Fixed
    public string SecondaryFixed => "#B8F1B9";
    public string OnSecondaryFixed => "#00260A";
    public string SecondaryFixedDim => "#AAE2AC";
    public string OnSecondaryFixedVariant => "#154921";
    // Tertiary Fixed
    public string TertiaryFixed => "#6CF2FF";
    public string OnTertiaryFixed => "#002124";
    public string TertiaryFixedDim => "#5BE4F0";
    public string OnTertiaryFixedVariant => "#00454A";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#152A17";
    public string SurfaceContainer => "#1F3521";
    public string SurfaceContainerHigh => "#2A412C";
    public string SurfaceContainerHighest => "#0C2C13";
}
