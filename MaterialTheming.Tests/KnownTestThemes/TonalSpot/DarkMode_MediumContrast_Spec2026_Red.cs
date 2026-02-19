namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class DarkMode_MediumContrast_Spec2026_Red : ITestTheme
{
    public string SourceColor => "#D2463D"; //Red
    public bool IsDark => true;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#F9B6AE";
    public string OnPrimary => "#552A25";
    public string PrimaryContainer => "#9E6660";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#E7BDB8";
    public string OnSecondary => "#4B2F2C";
    public string SecondaryContainer => "#8F6C68";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#FFE0BD";
    public string OnTertiary => "#634314";
    public string TertiaryContainer => "#FFCF93";
    public string OnTertiaryContainer => "#593B0C";
    // Error
    public string Error => "#FF9DA8";
    public string OnError => "#5F001C";
    public string ErrorContainer => "#C44B5F";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#130C0C";
    public string SurfaceVariant => "#302221";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#CAB4B1";
    public string SurfaceDim => "#130C0C";
    public string SurfaceBright => "#372927";
    public string SurfaceTint => "#F9B6AE";
    // Background
    public string Background => "#130C0C";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#A48F8C";
    public string OutlineVariant => "#84716F";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#FFF8F7";
    public string InverseOnSurface => "#3F3635";
    public string InversePrimary => "#794842";
    // Primary Fixed
    public string PrimaryFixed => "#F9B6AE";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#EAA9A1";
    public string OnPrimaryFixedVariant => "#49201C";
    // Secondary Fixed
    public string SecondaryFixed => "#FFDAD6";
    public string OnSecondaryFixed => "#311916";
    public string SecondaryFixedDim => "#F6CAC5";
    public string OnSecondaryFixedVariant => "#553835";
    // Tertiary Fixed
    public string TertiaryFixed => "#FFCF93";
    public string OnTertiaryFixed => "#201100";
    public string TertiaryFixedDim => "#F0C187";
    public string OnTertiaryFixedVariant => "#4F3203";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#1A1110";
    public string SurfaceContainer => "#221716";
    public string SurfaceContainerHigh => "#291D1B";
    public string SurfaceContainerHighest => "#302221";
}
