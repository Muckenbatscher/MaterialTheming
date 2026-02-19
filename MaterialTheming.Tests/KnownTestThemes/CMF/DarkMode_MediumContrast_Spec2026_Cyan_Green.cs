namespace MaterialTheming.Tests.KnownTestThemes.CMF;

internal class DarkMode_MediumContrast_Spec2026_Cyan_Green : ITestThemeSecondSourceColor
{
    public string SourceColor => "#00BCD1"; //Cyan
    public string SecondSourceColor => "#338745"; //Green
    public bool IsDark => true;
    public Variant Variant => Variant.CMF;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#2DCADF";
    public string OnPrimary => "#003138";
    public string PrimaryContainer => "#00BCD1";
    public string OnPrimaryContainer => "#00242A";
    // Secondary
    public string Secondary => "#92C1C9";
    public string OnSecondary => "#003138";
    public string SecondaryContainer => "#4E7C84";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#77CB81";
    public string OnTertiary => "#003411";
    public string TertiaryContainer => "#308443";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#FF9F97";
    public string OnError => "#5A0D0E";
    public string ErrorContainer => "#BB554F";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#051012";
    public string SurfaceVariant => "#0E292E";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#A2BEC3";
    public string SurfaceDim => "#051012";
    public string SurfaceBright => "#153034";
    public string SurfaceTint => "#2DCADF";
    // Background
    public string Background => "#051012";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#7D989D";
    public string OutlineVariant => "#5F7A7F";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#EDFCFF";
    public string InverseOnSurface => "#2E3A3D";
    public string InversePrimary => "#005E69";
    // Primary Fixed
    public string PrimaryFixed => "#00BCD1";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#00ADC1";
    public string OnPrimaryFixedVariant => "#001316";
    // Secondary Fixed
    public string SecondaryFixed => "#BBEBF4";
    public string OnSecondaryFixed => "#002429";
    public string SecondaryFixedDim => "#ADDCE6";
    public string OnSecondaryFixedVariant => "#13464D";
    // Tertiary Fixed
    public string TertiaryFixed => "#308443";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#318543";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#051619";
    public string SurfaceContainer => "#081C20";
    public string SurfaceContainerHigh => "#0C2326";
    public string SurfaceContainerHighest => "#0E292E";
}
