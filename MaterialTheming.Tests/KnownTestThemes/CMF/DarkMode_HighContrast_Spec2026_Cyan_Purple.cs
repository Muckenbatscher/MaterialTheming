namespace MaterialTheming.Tests.KnownTestThemes.CMF;

internal class DarkMode_HighContrast_Spec2026_Cyan_Purple : ITestThemeSecondSourceColor
{
    public string SourceColor => "#00BCD1"; //Cyan
    public string SecondSourceColor => "#945CCD"; //Purple
    public bool IsDark => true;
    public Variant Variant => Variant.CMF;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#A7F1FF";
    public string OnPrimary => "#003138";
    public string PrimaryContainer => "#00BCD1";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#BEEEF7";
    public string OnSecondary => "#003138";
    public string SecondaryContainer => "#7DABB4";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#F2DFFF";
    public string OnTertiary => "#430077";
    public string TertiaryContainer => "#C38AFE";
    public string OnTertiaryContainer => "#000000";
    // Error
    public string Error => "#FFDEDB";
    public string OnError => "#5A0D0E";
    public string ErrorContainer => "#F5827A";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#051012";
    public string SurfaceVariant => "#0E292E";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#CEEBF0";
    public string SurfaceDim => "#051012";
    public string SurfaceBright => "#153034";
    public string SurfaceTint => "#A7F1FF";
    // Background
    public string Background => "#051012";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#A2BEC3";
    public string OutlineVariant => "#8DA8AE";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#EDFCFF";
    public string InverseOnSurface => "#000000";
    public string InversePrimary => "#003F47";
    // Primary Fixed
    public string PrimaryFixed => "#00BCD1";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#00B4C8";
    public string OnPrimaryFixedVariant => "#000000";
    // Secondary Fixed
    public string SecondaryFixed => "#BBEBF4";
    public string OnSecondaryFixed => "#000000";
    public string SecondaryFixedDim => "#ADDCE6";
    public string OnSecondaryFixedVariant => "#002429";
    // Tertiary Fixed
    public string TertiaryFixed => "#C38AFE";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#C38AFE";
    public string OnTertiaryFixedVariant => "#000000";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#051619";
    public string SurfaceContainer => "#081C20";
    public string SurfaceContainerHigh => "#0C2326";
    public string SurfaceContainerHighest => "#0E292E";
}
