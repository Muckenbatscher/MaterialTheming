namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class LightMode_MediumContrast_Spec2025_Blue : ITestTheme
{
    public string SourceColor => "#185FAA"; //Blue
    public bool IsDark => false;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#26446C";
    public string OnPrimary => "#C6DBFF";
    public string PrimaryContainer => "#5A76A1";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#394354";
    public string OnSecondary => "#D0DAEF";
    public string SecondaryContainer => "#6B7588";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#483C64";
    public string OnTertiary => "#E1D3FF";
    public string TertiaryContainer => "#7B6E99";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#811B1D";
    public string OnError => "#FFCECA";
    public string ErrorContainer => "#C54D4A";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#F9F9FE";
    public string SurfaceVariant => "#DFE2EC";
    public string OnSurface => "#20242B";
    public string OnSurfaceVariant => "#3F434B";
    public string SurfaceDim => "#D7DAE4";
    public string SurfaceBright => "#F9F9FE";
    public string SurfaceTint => "#26446C";
    // Background
    public string Background => "#F9F9FE";
    public string OnBackground => "#20242B";
    // Outline
    public string Outline => "#5B5F68";
    public string OutlineVariant => "#777B84";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#0C0E12";
    public string InverseOnSurface => "#C4C4C9";
    public string InversePrimary => "#A6C2F2";
    // Primary Fixed
    public string PrimaryFixed => "#5A76A1";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#4D6993";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#6B7588";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#5E697B";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#7B6E99";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#6E618C";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F2F3FA";
    public string SurfaceContainer => "#ECEDF6";
    public string SurfaceContainerHigh => "#E6E8F1";
    public string SurfaceContainerHighest => "#DFE2EC";
}
