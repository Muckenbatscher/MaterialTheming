namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class LightMode_MediumContrast_Spec2026_Purple : ITestTheme
{
    public string SourceColor => "#945CCD"; //Purple
    public bool IsDark => false;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#572F7F";
    public string OnPrimary => "#EAD0FF";
    public string PrimaryContainer => "#8B62B5";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#30492C";
    public string OnSecondary => "#C4E2BB";
    public string SecondaryContainer => "#607C5B";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#174D06";
    public string OnTertiary => "#ACEA92";
    public string TertiaryContainer => "#4A8237";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#85112F";
    public string OnError => "#FFCDD1";
    public string ErrorContainer => "#C8475D";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#FFF7FE";
    public string SurfaceVariant => "#F0DBFF";
    public string OnSurface => "#2E1B41";
    public string OnSurfaceVariant => "#4E3A62";
    public string SurfaceDim => "#EAD0FF";
    public string SurfaceBright => "#FFF7FE";
    public string SurfaceTint => "#572F7F";
    // Background
    public string Background => "#FFF7FE";
    public string OnBackground => "#2E1B41";
    // Outline
    public string Outline => "#6C5681";
    public string OutlineVariant => "#88729E";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#130A1E";
    public string InverseOnSurface => "#CFBFDB";
    public string InversePrimary => "#CDA0F9";
    // Primary Fixed
    public string PrimaryFixed => "#8B62B5";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#7E55A8";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#607C5B";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#546F4F";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#4A8237";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#3E752B";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FBF0FF";
    public string SurfaceContainer => "#F7E9FF";
    public string SurfaceContainerHigh => "#F4E2FF";
    public string SurfaceContainerHighest => "#F0DBFF";
}
