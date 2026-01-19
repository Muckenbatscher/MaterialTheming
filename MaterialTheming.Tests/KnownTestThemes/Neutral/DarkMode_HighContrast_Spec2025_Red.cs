namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class DarkMode_HighContrast_Spec2025_Red : ITestTheme
{
    public string SourceColor => "#D2463D"; //Red
    public bool IsDark => true;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#F8E0DD";
    public string OnPrimary => "#362927";
    public string PrimaryContainer => "#B49F9C";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#F0E3E1";
    public string OnSecondary => "#312A29";
    public string SecondaryContainer => "#ACA1A0";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#FFDCE9";
    public string OnTertiary => "#402330";
    public string TertiaryContainer => "#F5C8DA";
    public string OnTertiaryContainer => "#311723";
    // Error
    public string Error => "#FFDDDF";
    public string OnError => "#5B0A1E";
    public string ErrorContainer => "#F38190";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#100E0D";
    public string SurfaceVariant => "#2A2524";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#EEE3E1";
    public string SurfaceDim => "#100E0D";
    public string SurfaceBright => "#312B2A";
    public string SurfaceTint => "#F8E0DD";
    // Background
    public string Background => "#100E0D";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#C0B7B5";
    public string OutlineVariant => "#ABA2A0";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#FFF8F7";
    public string InverseOnSurface => "#000000";
    public string InversePrimary => "#433533";
    // Primary Fixed
    public string PrimaryFixed => "#F5DDDA";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#E6CFCC";
    public string OnPrimaryFixedVariant => "#291C1B";
    // Secondary Fixed
    public string SecondaryFixed => "#EDE0DE";
    public string OnSecondaryFixed => "#000000";
    public string SecondaryFixedDim => "#DED2D0";
    public string OnSecondaryFixedVariant => "#241E1D";
    // Tertiary Fixed
    public string TertiaryFixed => "#F5C8DA";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#E7BBCC";
    public string OnTertiaryFixedVariant => "#210915";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#161312";
    public string SurfaceContainer => "#1C1918";
    public string SurfaceContainerHigh => "#231F1E";
    public string SurfaceContainerHighest => "#2A2524";
}
