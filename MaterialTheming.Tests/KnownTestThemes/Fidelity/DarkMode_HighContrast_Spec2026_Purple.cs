namespace MaterialTheming.Tests.KnownTestThemes.Fidelity;

internal class DarkMode_HighContrast_Spec2026_Purple : ITestTheme
{
    public string SourceColor => "#945CCD"; //Purple
    public bool IsDark => true;
    public Variant Variant => Variant.Fidelity;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#F9EBFF";
    public string OnPrimary => "#000000";
    public string PrimaryContainer => "#DAB3FF";
    public string OnPrimaryContainer => "#0B001B";
    // Secondary
    public string Secondary => "#F9EBFF";
    public string OnSecondary => "#000000";
    public string SecondaryContainer => "#D3B8EB";
    public string OnSecondaryContainer => "#140129";
    // Tertiary
    public string Tertiary => "#FFF0BE";
    public string OnTertiary => "#000000";
    public string TertiaryContainer => "#DDC152";
    public string OnTertiaryContainer => "#0F0B00";
    // Error
    public string Error => "#FFECE9";
    public string OnError => "#000000";
    public string ErrorContainer => "#FFAEA4";
    public string OnErrorContainer => "#220001";
    // Surface
    public string Surface => "#161219";
    public string SurfaceVariant => "#4C4451";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#FFFFFF";
    public string SurfaceDim => "#161219";
    public string SurfaceBright => "#544E56";
    public string SurfaceTint => "#DCB8FF";
    // Background
    public string Background => "#161219";
    public string OnBackground => "#E9E0EA";
    // Outline
    public string Outline => "#F8ECFD";
    public string OutlineVariant => "#CABFCF";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#E9E0EA";
    public string InverseOnSurface => "#000000";
    public string InversePrimary => "#622899";
    // Primary Fixed
    public string PrimaryFixed => "#F0DBFF";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#DCB8FF";
    public string OnPrimaryFixedVariant => "#1D0039";
    // Secondary Fixed
    public string SecondaryFixed => "#F0DBFF";
    public string OnSecondaryFixed => "#000000";
    public string SecondaryFixedDim => "#D7BCEF";
    public string OnSecondaryFixedVariant => "#1B062F";
    // Tertiary Fixed
    public string TertiaryFixed => "#FFE16E";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#E1C555";
    public string OnTertiaryFixedVariant => "#161100";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#221E25";
    public string SurfaceContainer => "#332F36";
    public string SurfaceContainerHigh => "#3F3A42";
    public string SurfaceContainerHighest => "#4A454D";
}
