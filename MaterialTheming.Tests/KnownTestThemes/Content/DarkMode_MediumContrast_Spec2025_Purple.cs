namespace MaterialTheming.Tests.KnownTestThemes.Content;

internal class DarkMode_MediumContrast_Spec2025_Purple : ITestTheme
{
    public string SourceColor => "#945CCD"; //Purple
    public bool IsDark => true;
    public Variant Variant => Variant.Content;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#ECD3FF";
    public string OnPrimary => "#3A0068";
    public string PrimaryContainer => "#AF76E9";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#ECD3FF";
    public string OnSecondary => "#301C45";
    public string SecondaryContainer => "#A087B7";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#FFD0E1";
    public string OnTertiary => "#4F0030";
    public string TertiaryContainer => "#E067A2";
    public string OnTertiaryContainer => "#000000";
    // Error
    public string Error => "#FFD2CC";
    public string OnError => "#540003";
    public string ErrorContainer => "#FF5449";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#161219";
    public string SurfaceVariant => "#4C4451";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#E4D8E9";
    public string SurfaceDim => "#161219";
    public string SurfaceBright => "#48434B";
    public string SurfaceTint => "#DCB8FF";
    // Background
    public string Background => "#161219";
    public string OnBackground => "#E9E0EA";
    // Outline
    public string Outline => "#B9AEBE";
    public string OutlineVariant => "#978D9C";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#E9E0EA";
    public string InverseOnSurface => "#2D2830";
    public string InversePrimary => "#622899";
    // Primary Fixed
    public string PrimaryFixed => "#F0DBFF";
    public string OnPrimaryFixed => "#1D0039";
    public string PrimaryFixedDim => "#DCB8FF";
    public string OnPrimaryFixedVariant => "#4F0E86";
    // Secondary Fixed
    public string SecondaryFixed => "#F0DBFF";
    public string OnSecondaryFixed => "#1B062F";
    public string SecondaryFixedDim => "#D7BCEF";
    public string OnSecondaryFixedVariant => "#422D57";
    // Tertiary Fixed
    public string TertiaryFixed => "#FFD8E6";
    public string OnTertiaryFixed => "#2A0017";
    public string TertiaryFixedDim => "#FFAFD1";
    public string OnTertiaryFixedVariant => "#6D0144";
    // Surface Container
    public string SurfaceContainerLowest => "#09060C";
    public string SurfaceContainerLow => "#201C23";
    public string SurfaceContainer => "#2B262E";
    public string SurfaceContainerHigh => "#363139";
    public string SurfaceContainerHighest => "#413C44";
}
