namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class DarkMode_MediumContrast_Spec2021_Purple : ITestTheme
{
    public string SourceColor => "#945CCD"; //Purple
    public bool IsDark => true;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#ECD3FF";
    public string OnPrimary => "#3A0068";
    public string PrimaryContainer => "#B66DFF";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#F2D2F7";
    public string OnSecondary => "#331D39";
    public string SecondaryContainer => "#A487A9";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#FFCEF4";
    public string OnTertiary => "#3D173A";
    public string TertiaryContainer => "#B381AA";
    public string OnTertiaryContainer => "#000000";
    // Error
    public string Error => "#FFD2CC";
    public string OnError => "#540003";
    public string ErrorContainer => "#FF5449";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#16111B";
    public string SurfaceVariant => "#4C4452";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#E4D8EA";
    public string SurfaceDim => "#16111B";
    public string SurfaceBright => "#49424D";
    public string SurfaceTint => "#DCB8FF";
    // Background
    public string Background => "#16111B";
    public string OnBackground => "#EADFED";
    // Outline
    public string Outline => "#B9AEBF";
    public string OutlineVariant => "#978D9D";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#EADFED";
    public string InverseOnSurface => "#2E2832";
    public string InversePrimary => "#6900B7";
    // Primary Fixed
    public string PrimaryFixed => "#F0DBFF";
    public string OnPrimaryFixed => "#1D0039";
    public string PrimaryFixedDim => "#DCB8FF";
    public string OnPrimaryFixedVariant => "#51008E";
    // Secondary Fixed
    public string SecondaryFixed => "#F9D8FE";
    public string OnSecondaryFixed => "#1D0824";
    public string SecondaryFixedDim => "#DCBCE1";
    public string OnSecondaryFixedVariant => "#452E4B";
    // Tertiary Fixed
    public string TertiaryFixed => "#FFD7F5";
    public string OnTertiaryFixed => "#250224";
    public string TertiaryFixedDim => "#EDB5E2";
    public string OnTertiaryFixedVariant => "#50284B";
    // Surface Container
    public string SurfaceContainerLowest => "#0A060E";
    public string SurfaceContainerLow => "#211B26";
    public string SurfaceContainer => "#2B2630";
    public string SurfaceContainerHigh => "#36303B";
    public string SurfaceContainerHighest => "#423B46";
}
