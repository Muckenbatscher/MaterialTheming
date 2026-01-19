namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class DarkMode_NormalContrast_Spec2025_Red : ITestTheme
{
    public string SourceColor => "#D2463D"; //Red
    public bool IsDark => true;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#D8C2BF";
    public string OnPrimary => "#4C3D3B";
    public string PrimaryContainer => "#534341";
    public string OnPrimaryContainer => "#E2CBC8";
    // Secondary
    public string Secondary => "#A69B9A";
    public string OnSecondary => "#251F1E";
    public string SecondaryContainer => "#413A39";
    public string OnSecondaryContainer => "#C9BDBB";
    // Tertiary
    public string Tertiary => "#FFD8E6";
    public string OnTertiary => "#694856";
    public string TertiaryContainer => "#F5C8DA";
    public string OnTertiaryContainer => "#60404E";
    // Error
    public string Error => "#EC7C8A";
    public string OnError => "#490013";
    public string ErrorContainer => "#7F2737";
    public string OnErrorContainer => "#FF97A3";
    // Surface
    public string Surface => "#100E0D";
    public string SurfaceVariant => "#2A2524";
    public string OnSurface => "#EEE3E1";
    public string OnSurfaceVariant => "#B2A9A8";
    public string SurfaceDim => "#100E0D";
    public string SurfaceBright => "#312B2A";
    public string SurfaceTint => "#D8C2BF";
    // Background
    public string Background => "#100E0D";
    public string OnBackground => "#EEE3E1";
    // Outline
    public string Outline => "#7C7473";
    public string OutlineVariant => "#4D4646";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#FFF8F7";
    public string InverseOnSurface => "#585454";
    public string InversePrimary => "#6C5B59";
    // Primary Fixed
    public string PrimaryFixed => "#F5DDDA";
    public string OnPrimaryFixed => "#4B3C3A";
    public string PrimaryFixedDim => "#E6CFCC";
    public string OnPrimaryFixedVariant => "#685856";
    // Secondary Fixed
    public string SecondaryFixed => "#EDE0DE";
    public string OnSecondaryFixed => "#453D3D";
    public string SecondaryFixedDim => "#DED2D0";
    public string OnSecondaryFixedVariant => "#625958";
    // Tertiary Fixed
    public string TertiaryFixed => "#F5C8DA";
    public string OnTertiaryFixed => "#4B2D3B";
    public string TertiaryFixedDim => "#E7BBCC";
    public string OnTertiaryFixedVariant => "#6A4957";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#161312";
    public string SurfaceContainer => "#1C1918";
    public string SurfaceContainerHigh => "#231F1E";
    public string SurfaceContainerHighest => "#2A2524";
}
