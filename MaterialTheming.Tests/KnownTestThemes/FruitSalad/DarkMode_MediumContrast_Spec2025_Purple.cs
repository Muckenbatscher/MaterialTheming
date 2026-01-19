namespace MaterialTheming.Tests.KnownTestThemes.FruitSalad;

internal class DarkMode_MediumContrast_Spec2025_Purple : ITestTheme
{
    public string SourceColor => "#945CCD"; //Purple
    public bool IsDark => true;
    public Variant Variant => Variant.FruitSalad;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#CBDDFF";
    public string OnPrimary => "#00264D";
    public string PrimaryContainer => "#5D92DD";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#CBDDFF";
    public string OnSecondary => "#00264D";
    public string SecondaryContainer => "#7192C6";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#ECD3FF";
    public string OnTertiary => "#33184D";
    public string TertiaryContainer => "#A384C0";
    public string OnTertiaryContainer => "#000000";
    // Error
    public string Error => "#FFD2CC";
    public string OnError => "#540003";
    public string ErrorContainer => "#FF5449";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#16111B";
    public string SurfaceVariant => "#4D4357";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#E6D7F0";
    public string SurfaceDim => "#16111B";
    public string SurfaceBright => "#49424D";
    public string SurfaceTint => "#A6C8FF";
    // Background
    public string Background => "#16111B";
    public string OnBackground => "#EADFED";
    // Outline
    public string Outline => "#BBADC5";
    public string OutlineVariant => "#998BA2";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#EADFED";
    public string InverseOnSurface => "#2E2832";
    public string InversePrimary => "#004889";
    // Primary Fixed
    public string PrimaryFixed => "#D5E3FF";
    public string OnPrimaryFixed => "#001129";
    public string PrimaryFixedDim => "#A6C8FF";
    public string OnPrimaryFixedVariant => "#00366A";
    // Secondary Fixed
    public string SecondaryFixed => "#D5E3FF";
    public string OnSecondaryFixed => "#001129";
    public string SecondaryFixedDim => "#A6C8FF";
    public string OnSecondaryFixedVariant => "#0D3665";
    // Tertiary Fixed
    public string TertiaryFixed => "#F0DBFF";
    public string OnTertiaryFixed => "#1D0137";
    public string TertiaryFixedDim => "#DBB9F9";
    public string OnTertiaryFixedVariant => "#442A5F";
    // Surface Container
    public string SurfaceContainerLowest => "#0A060E";
    public string SurfaceContainerLow => "#211B26";
    public string SurfaceContainer => "#2B2630";
    public string SurfaceContainerHigh => "#36303B";
    public string SurfaceContainerHighest => "#423B46";
}
