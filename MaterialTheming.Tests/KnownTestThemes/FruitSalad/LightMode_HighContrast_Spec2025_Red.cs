namespace MaterialTheming.Tests.KnownTestThemes.FruitSalad;

internal class LightMode_HighContrast_Spec2025_Red : ITestTheme
{
    public string SourceColor => "#D2463D"; //Red
    public bool IsDark => false;
    public Variant Variant => Variant.FruitSalad;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#4F0D4E";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#722E6E";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#471B44";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#683863";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#511A15";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#763630";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#600004";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#98000A";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#FFF8F7";
    public string SurfaceVariant => "#FFDAD6";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#000000";
    public string SurfaceDim => "#CDB3B0";
    public string SurfaceBright => "#FFF8F7";
    public string SurfaceTint => "#8A4484";
    // Background
    public string Background => "#FFF8F7";
    public string OnBackground => "#271816";
    // Outline
    public string Outline => "#3F2522";
    public string OutlineVariant => "#60423E";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#3D2C2A";
    public string InverseOnSurface => "#FFFFFF";
    public string InversePrimary => "#FFABF3";
    // Primary Fixed
    public string PrimaryFixed => "#722E6E";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#571655";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#683863";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#4F214B";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#763630";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#59201B";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFEDEA";
    public string SurfaceContainer => "#F9DCD9";
    public string SurfaceContainerHigh => "#EACECB";
    public string SurfaceContainerHighest => "#DCC0BD";
}
