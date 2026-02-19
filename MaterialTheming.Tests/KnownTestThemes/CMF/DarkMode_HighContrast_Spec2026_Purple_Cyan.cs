namespace MaterialTheming.Tests.KnownTestThemes.CMF;

internal class DarkMode_HighContrast_Spec2026_Purple_Cyan : ITestThemeSecondSourceColor
{
    public string SourceColor => "#945CCD"; //Purple
    public string SecondSourceColor => "#00BCD1"; //Cyan
    public bool IsDark => true;
    public Variant Variant => Variant.CMF;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#F2DFFF";
    public string OnPrimary => "#430077";
    public string PrimaryContainer => "#C38AFE";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#F2DFFF";
    public string OnSecondary => "#37234C";
    public string SecondaryContainer => "#B39ACB";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#A7F1FF";
    public string OnTertiary => "#003138";
    public string TertiaryContainer => "#00BCD1";
    public string OnTertiaryContainer => "#000000";
    // Error
    public string Error => "#FFDEDB";
    public string OnError => "#600008";
    public string ErrorContainer => "#FF7C74";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#120C18";
    public string SurfaceVariant => "#2D2039";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#F2DFFF";
    public string SurfaceDim => "#120C18";
    public string SurfaceBright => "#332740";
    public string SurfaceTint => "#F2DFFF";
    // Background
    public string Background => "#120C18";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#C4B2D2";
    public string OutlineVariant => "#AF9DBC";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#FFF7FE";
    public string InverseOnSurface => "#000000";
    public string InversePrimary => "#511289";
    // Primary Fixed
    public string PrimaryFixed => "#C38AFE";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#C38AFE";
    public string OnPrimaryFixedVariant => "#000000";
    // Secondary Fixed
    public string SecondaryFixed => "#E3C7FB";
    public string OnSecondaryFixed => "#000000";
    public string SecondaryFixedDim => "#D4B9EC";
    public string OnSecondaryFixedVariant => "#16032B";
    // Tertiary Fixed
    public string TertiaryFixed => "#00BCD1";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#00B4C8";
    public string OnTertiaryFixedVariant => "#000000";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#181020";
    public string SurfaceContainer => "#1F1628";
    public string SurfaceContainerHigh => "#261B30";
    public string SurfaceContainerHighest => "#2D2039";
}
