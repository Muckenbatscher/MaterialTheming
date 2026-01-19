namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class DarkMode_MediumContrast_Spec2021_Purple : ITestTheme
{
    public string SourceColor => "#945CCD"; //Purple
    public bool IsDark => true;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#E4D8EA";
    public string OnPrimary => "#2A2330";
    public string PrimaryContainer => "#978D9D";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#E3D9E4";
    public string OnSecondary => "#29242C";
    public string SecondaryContainer => "#968E98";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#E6D7F0";
    public string OnTertiary => "#2B2234";
    public string TertiaryContainer => "#998CA3";
    public string OnTertiaryContainer => "#000000";
    // Error
    public string Error => "#FFD2CC";
    public string OnError => "#540003";
    public string ErrorContainer => "#FF5449";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#141314";
    public string SurfaceVariant => "#484648";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#E0DBDD";
    public string SurfaceDim => "#141314";
    public string SurfaceBright => "#464445";
    public string SurfaceTint => "#CEC2D4";
    // Background
    public string Background => "#141314";
    public string OnBackground => "#E6E1E3";
    // Outline
    public string Outline => "#B5B1B2";
    public string OutlineVariant => "#938F91";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#E6E1E3";
    public string InverseOnSurface => "#2B292B";
    public string InversePrimary => "#4D4553";
    // Primary Fixed
    public string PrimaryFixed => "#EBDEF0";
    public string OnPrimaryFixed => "#150F1B";
    public string PrimaryFixedDim => "#CEC2D4";
    public string OnPrimaryFixedVariant => "#3B3341";
    // Secondary Fixed
    public string SecondaryFixed => "#E9DFEB";
    public string OnSecondaryFixed => "#141017";
    public string SecondaryFixedDim => "#CCC4CE";
    public string OnSecondaryFixedVariant => "#39343D";
    // Tertiary Fixed
    public string TertiaryFixed => "#EDDDF6";
    public string OnTertiaryFixed => "#160D1F";
    public string TertiaryFixedDim => "#D0C1DA";
    public string OnTertiaryFixedVariant => "#3C3245";
    // Surface Container
    public string SurfaceContainerLowest => "#080708";
    public string SurfaceContainerLow => "#1F1D1F";
    public string SurfaceContainer => "#292729";
    public string SurfaceContainerHigh => "#343234";
    public string SurfaceContainerHighest => "#3F3D3F";
}
