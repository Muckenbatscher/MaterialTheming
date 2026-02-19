namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class DarkMode_MediumContrast_Spec2026_Red : ITestTheme
{
    public string SourceColor => "#D2463D"; //Red
    public bool IsDark => true;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#D8C2BF";
    public string OnPrimary => "#413331";
    public string PrimaryContainer => "#83706E";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#C2B6B4";
    public string OnSecondary => "#322A2A";
    public string SecondaryContainer => "#7C7271";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#FFD8E6";
    public string OnTertiary => "#5F3F4C";
    public string TertiaryContainer => "#F5C8DA";
    public string OnTertiaryContainer => "#553644";
    // Error
    public string Error => "#FF9DA8";
    public string OnError => "#5B0A1E";
    public string ErrorContainer => "#B95463";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#100E0D";
    public string SurfaceVariant => "#2A2524";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#C0B7B5";
    public string SurfaceDim => "#100E0D";
    public string SurfaceBright => "#312B2A";
    public string SurfaceTint => "#D8C2BF";
    // Background
    public string Background => "#100E0D";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#9A9190";
    public string OutlineVariant => "#7C7473";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#FFF8F7";
    public string InverseOnSurface => "#3B3737";
    public string InversePrimary => "#62514F";
    // Primary Fixed
    public string PrimaryFixed => "#F5DDDA";
    public string OnPrimaryFixed => "#291C1B";
    public string PrimaryFixedDim => "#E6CFCC";
    public string OnPrimaryFixedVariant => "#4B3C3A";
    // Secondary Fixed
    public string SecondaryFixed => "#EDE0DE";
    public string OnSecondaryFixed => "#241E1D";
    public string SecondaryFixedDim => "#DED2D0";
    public string OnSecondaryFixedVariant => "#453D3D";
    // Tertiary Fixed
    public string TertiaryFixed => "#F5C8DA";
    public string OnTertiaryFixed => "#210915";
    public string TertiaryFixedDim => "#E7BBCC";
    public string OnTertiaryFixedVariant => "#4B2D3B";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#161312";
    public string SurfaceContainer => "#1C1918";
    public string SurfaceContainerHigh => "#231F1E";
    public string SurfaceContainerHighest => "#2A2524";
}
