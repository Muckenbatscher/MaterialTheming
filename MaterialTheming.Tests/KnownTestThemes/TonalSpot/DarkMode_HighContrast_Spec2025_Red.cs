namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class DarkMode_HighContrast_Spec2025_Red : ITestTheme
{
    public string SourceColor => "#D2463D"; //Red
    public bool IsDark => true;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#FFDEDA";
    public string OnPrimary => "#49201C";
    public string PrimaryContainer => "#D2948D";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#FFDEDA";
    public string OnSecondary => "#3F2522";
    public string SecondaryContainer => "#C29A96";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#FFE0BD";
    public string OnTertiary => "#402700";
    public string TertiaryContainer => "#FFCF93";
    public string OnTertiaryContainer => "#321D00";
    // Error
    public string Error => "#FFDDDF";
    public string OnError => "#5F001C";
    public string ErrorContainer => "#FF798C";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#130C0C";
    public string SurfaceVariant => "#302221";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#F9E0DD";
    public string SurfaceDim => "#130C0C";
    public string SurfaceBright => "#372927";
    public string SurfaceTint => "#FFDEDA";
    // Background
    public string Background => "#130C0C";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#CAB4B1";
    public string OutlineVariant => "#B59F9C";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#FFF8F7";
    public string InverseOnSurface => "#000000";
    public string InversePrimary => "#572C27";
    // Primary Fixed
    public string PrimaryFixed => "#F9B6AE";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#EAA9A1";
    public string OnPrimaryFixedVariant => "#000000";
    // Secondary Fixed
    public string SecondaryFixed => "#FFDAD6";
    public string OnSecondaryFixed => "#000000";
    public string SecondaryFixedDim => "#F6CAC5";
    public string OnSecondaryFixedVariant => "#311916";
    // Tertiary Fixed
    public string TertiaryFixed => "#FFCF93";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#F0C187";
    public string OnTertiaryFixedVariant => "#201100";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#1A1110";
    public string SurfaceContainer => "#221716";
    public string SurfaceContainerHigh => "#291D1B";
    public string SurfaceContainerHighest => "#302221";
}
