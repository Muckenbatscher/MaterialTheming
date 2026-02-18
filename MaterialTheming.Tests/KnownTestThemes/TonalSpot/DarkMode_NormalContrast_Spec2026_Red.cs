namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class DarkMode_NormalContrast_Spec2026_Red : ITestTheme
{
    public string SourceColor => "#D2463D"; //Red
    public bool IsDark => true;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#F9B6AE";
    public string OnPrimary => "#61332F";
    public string PrimaryContainer => "#764540";
    public string OnPrimaryContainer => "#FFDBD7";
    // Secondary
    public string Secondary => "#E7BDB8";
    public string OnSecondary => "#563935";
    public string SecondaryContainer => "#513431";
    public string OnSecondaryContainer => "#DFB6B1";
    // Tertiary
    public string Tertiary => "#FFE0BD";
    public string OnTertiary => "#6E4D1D";
    public string TertiaryContainer => "#FFCF93";
    public string OnTertiaryContainer => "#654415";
    // Error
    public string Error => "#F97386";
    public string OnError => "#490013";
    public string ErrorContainer => "#871C34";
    public string OnErrorContainer => "#FF97A3";
    // Surface
    public string Surface => "#130C0C";
    public string SurfaceVariant => "#302221";
    public string OnSurface => "#F9E0DD";
    public string OnSurfaceVariant => "#BCA6A3";
    public string SurfaceDim => "#130C0C";
    public string SurfaceBright => "#372927";
    public string SurfaceTint => "#F9B6AE";
    // Background
    public string Background => "#130C0C";
    public string OnBackground => "#F9E0DD";
    // Outline
    public string Outline => "#84716F";
    public string OutlineVariant => "#554442";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#FFF8F7";
    public string InverseOnSurface => "#5D5351";
    public string InversePrimary => "#85514C";
    // Primary Fixed
    public string PrimaryFixed => "#F9B6AE";
    public string OnPrimaryFixed => "#49201C";
    public string PrimaryFixedDim => "#EAA9A1";
    public string OnPrimaryFixedVariant => "#6C3C37";
    // Secondary Fixed
    public string SecondaryFixed => "#FFDAD6";
    public string OnSecondaryFixed => "#553835";
    public string SecondaryFixedDim => "#F6CAC5";
    public string OnSecondaryFixedVariant => "#745450";
    // Tertiary Fixed
    public string TertiaryFixed => "#FFCF93";
    public string OnTertiaryFixed => "#4F3203";
    public string TertiaryFixedDim => "#F0C187";
    public string OnTertiaryFixedVariant => "#6F4E1E";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#1A1110";
    public string SurfaceContainer => "#221716";
    public string SurfaceContainerHigh => "#291D1B";
    public string SurfaceContainerHighest => "#302221";
}
