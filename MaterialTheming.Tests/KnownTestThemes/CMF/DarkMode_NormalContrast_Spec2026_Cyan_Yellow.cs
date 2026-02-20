namespace MaterialTheming.Tests.KnownTestThemes.CMF;

internal class DarkMode_NormalContrast_Spec2026_Cyan_Yellow : ITestThemeSecondSourceColor
{
    public string SourceColor => "#00BCD1"; //Cyan
    public string SecondSourceColor => "#B2B037"; //Yellow
    public bool IsDark => true;
    public Variant Variant => Variant.CMF;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#00BCD1";
    public string OnPrimary => "#003138";
    public string PrimaryContainer => "#00AEC1";
    public string OnPrimaryContainer => "#00242A";
    // Secondary
    public string Secondary => "#77A5AE";
    public string OnSecondary => "#00242A";
    public string SecondaryContainer => "#013B42";
    public string OnSecondaryContainer => "#8FBEC7";
    // Tertiary
    public string Tertiary => "#B2B037";
    public string OnTertiary => "#2F2E00";
    public string TertiaryContainer => "#A4A22A";
    public string OnTertiaryContainer => "#222100";
    // Error
    public string Error => "#FB877F";
    public string OnError => "#570B0D";
    public string ErrorContainer => "#480005";
    public string OnErrorContainer => "#EE7D75";
    // Surface
    public string Surface => "#051012";
    public string SurfaceVariant => "#0E292E";
    public string OnSurface => "#CEEBF0";
    public string OnSurfaceVariant => "#94B0B5";
    public string SurfaceDim => "#051012";
    public string SurfaceBright => "#153034";
    public string SurfaceTint => "#00BCD1";
    // Background
    public string Background => "#051012";
    public string OnBackground => "#CEEBF0";
    // Outline
    public string Outline => "#5F7A7F";
    public string OutlineVariant => "#324C51";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#EDFCFF";
    public string InverseOnSurface => "#4B575A";
    public string InversePrimary => "#006975";
    // Primary Fixed
    public string PrimaryFixed => "#00BCD1";
    public string OnPrimaryFixed => "#001316";
    public string PrimaryFixedDim => "#00ADC1";
    public string OnPrimaryFixedVariant => "#003B43";
    // Secondary Fixed
    public string SecondaryFixed => "#BBEBF4";
    public string OnSecondaryFixed => "#13464D";
    public string SecondaryFixedDim => "#ADDCE6";
    public string OnSecondaryFixedVariant => "#34626A";
    // Tertiary Fixed
    public string TertiaryFixed => "#B2B037";
    public string OnTertiaryFixed => "#121100";
    public string TertiaryFixedDim => "#A4A22A";
    public string OnTertiaryFixedVariant => "#383700";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#051619";
    public string SurfaceContainer => "#081C20";
    public string SurfaceContainerHigh => "#0C2326";
    public string SurfaceContainerHighest => "#0E292E";
}
