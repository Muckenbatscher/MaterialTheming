namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class DarkMode_HighContrast_Spec2021_Purple : ITestTheme
{
    public string SourceColor => "#945CCD"; //Purple
    public bool IsDark => true;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#F9EBFF";
    public string OnPrimary => "#000000";
    public string PrimaryContainer => "#DAB3FF";
    public string OnPrimaryContainer => "#15002C";
    // Secondary
    public string Secondary => "#FFEAFF";
    public string OnSecondary => "#000000";
    public string SecondaryContainer => "#D8B8DD";
    public string OnSecondaryContainer => "#16041D";
    // Tertiary
    public string Tertiary => "#FFEAF7";
    public string OnTertiary => "#000000";
    public string TertiaryContainer => "#E9B2DE";
    public string OnTertiaryContainer => "#1D001C";
    // Error
    public string Error => "#FFECE9";
    public string OnError => "#000000";
    public string ErrorContainer => "#FFAEA4";
    public string OnErrorContainer => "#220001";
    // Surface
    public string Surface => "#16111B";
    public string SurfaceVariant => "#4C4452";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#FFFFFF";
    public string SurfaceDim => "#16111B";
    public string SurfaceBright => "#554D59";
    public string SurfaceTint => "#DCB8FF";
    // Background
    public string Background => "#16111B";
    public string OnBackground => "#EADFED";
    // Outline
    public string Outline => "#F9ECFE";
    public string OutlineVariant => "#CABFD0";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#EADFED";
    public string InverseOnSurface => "#000000";
    public string InversePrimary => "#6900B7";
    // Primary Fixed
    public string PrimaryFixed => "#F0DBFF";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#DCB8FF";
    public string OnPrimaryFixedVariant => "#1D0039";
    // Secondary Fixed
    public string SecondaryFixed => "#F9D8FE";
    public string OnSecondaryFixed => "#000000";
    public string SecondaryFixedDim => "#DCBCE1";
    public string OnSecondaryFixedVariant => "#1D0824";
    // Tertiary Fixed
    public string TertiaryFixed => "#FFD7F5";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#EDB5E2";
    public string OnTertiaryFixedVariant => "#250224";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#231D28";
    public string SurfaceContainer => "#342E39";
    public string SurfaceContainerHigh => "#3F3944";
    public string SurfaceContainerHighest => "#4B4450";
}
