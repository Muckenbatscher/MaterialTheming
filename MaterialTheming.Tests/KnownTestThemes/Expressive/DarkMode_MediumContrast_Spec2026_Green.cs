namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class DarkMode_MediumContrast_Spec2026_Green : ITestTheme
{
    public string SourceColor => "#338745"; //Green
    public bool IsDark => true;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#B8F1B9";
    public string OnPrimary => "#1F5229";
    public string PrimaryContainer => "#4C8052";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#E5BFAA";
    public string OnSecondary => "#493122";
    public string SecondaryContainer => "#8E6E5C";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#FFB692";
    public string OnTertiary => "#5F2400";
    public string TertiaryContainer => "#FFA273";
    public string OnTertiaryContainer => "#4F1D00";
    // Error
    public string Error => "#FFA089";
    public string OnError => "#5A0E00";
    public string ErrorContainer => "#C74C2F";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#031108";
    public string SurfaceVariant => "#0B2C1A";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#9EC1A8";
    public string SurfaceDim => "#031108";
    public string SurfaceBright => "#0D331F";
    public string SurfaceTint => "#B8F1B9";
    // Background
    public string Background => "#031108";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#799B84";
    public string OutlineVariant => "#5C7D67";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#EBFEEE";
    public string InverseOnSurface => "#2B3C31";
    public string InversePrimary => "#2D5F35";
    // Primary Fixed
    public string PrimaryFixed => "#B8F1B9";
    public string OnPrimaryFixed => "#00260A";
    public string PrimaryFixedDim => "#AAE2AC";
    public string OnPrimaryFixedVariant => "#154921";
    // Secondary Fixed
    public string SecondaryFixed => "#FFDBC8";
    public string OnSecondaryFixed => "#301A0D";
    public string SecondaryFixedDim => "#F4CCB7";
    public string OnSecondaryFixedVariant => "#53392A";
    // Tertiary Fixed
    public string TertiaryFixed => "#FFA273";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#F7915B";
    public string OnTertiaryFixedVariant => "#3C1400";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#04170C";
    public string SurfaceContainer => "#061E11";
    public string SurfaceContainerHigh => "#082516";
    public string SurfaceContainerHighest => "#0B2C1A";
}
