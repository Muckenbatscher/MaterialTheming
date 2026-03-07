namespace MaterialTheming.Tests.KnownTestThemes.CMF;

internal class DarkMode_HighContrast_Spec2026_Red_Orange : ITestThemeSecondSourceColor
{
    public string SourceColor => "#D2463D"; //Red
    public string SecondSourceColor => "#D77837"; //Orange
    public bool IsDark => true;
    public Variant Variant => Variant.CMF;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#FFDEDA";
    public string OnPrimary => "#600004";
    public string PrimaryContainer => "#FF7C70";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#FFDEDA";
    public string OnSecondary => "#501A16";
    public string SecondaryContainer => "#E08E85";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#FFDFCE";
    public string OnTertiary => "#4B1F00";
    public string TertiaryContainer => "#EE8A48";
    public string OnTertiaryContainer => "#000000";
    // Error
    public string Error => "#FFDEDE";
    public string OnError => "#5F0015";
    public string ErrorContainer => "#FF7A83";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#1B0907";
    public string SurfaceVariant => "#3F1B17";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#FFDEDA";
    public string SurfaceDim => "#1B0907";
    public string SurfaceBright => "#47211D";
    public string SurfaceTint => "#FFDEDA";
    // Background
    public string Background => "#1B0907";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#E6AAA3";
    public string OutlineVariant => "#CF958F";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#FFF8F7";
    public string InverseOnSurface => "#000000";
    public string InversePrimary => "#770007";
    // Primary Fixed
    public string PrimaryFixed => "#FF7C70";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#FF7C70";
    public string OnPrimaryFixedVariant => "#000000";
    // Secondary Fixed
    public string SecondaryFixed => "#FCA59B";
    public string OnSecondaryFixed => "#000000";
    public string SecondaryFixedDim => "#EC988E";
    public string OnSecondaryFixedVariant => "#000000";
    // Tertiary Fixed
    public string TertiaryFixed => "#EE8A48";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#EE8A48";
    public string OnTertiaryFixedVariant => "#000000";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#240C0A";
    public string SurfaceContainer => "#2D110F";
    public string SurfaceContainerHigh => "#351613";
    public string SurfaceContainerHighest => "#3F1B17";
}
