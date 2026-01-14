using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class DarkMode_HighContrast_Spec2021_Purple : ITestTheme
{
    public string SourceColor => "#945CCD"; //Purple
    public bool IsDark => true;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#ACFFF7";
    public string OnPrimary => "#000000";
    public string PrimaryContainer => "#6FD3CA";
    public string OnPrimaryContainer => "#000E0D";
    // Secondary
    public string Secondary => "#FFEBF0";
    public string OnSecondary => "#000000";
    public string SecondaryContainer => "#E9B4C7";
    public string OnSecondaryContainer => "#1C020E";
    // Tertiary
    public string Tertiary => "#FFEAFA";
    public string OnTertiary => "#000000";
    public string TertiaryContainer => "#E5B3E2";
    public string OnTertiaryContainer => "#1B001F";
    // Error
    public string Error => "#FFECE9";
    public string OnError => "#000000";
    public string ErrorContainer => "#FFAEA4";
    public string OnErrorContainer => "#220001";
    // Surface
    public string Surface => "#181118";
    public string SurfaceVariant => "#4F4350";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#FFFFFF";
    public string SurfaceDim => "#181118";
    public string SurfaceBright => "#564D56";
    public string SurfaceTint => "#73D7CE";
    // Background
    public string Background => "#181118";
    public string OnBackground => "#ECDFE9";
    // Outline
    public string Outline => "#FDEAFB";
    public string OutlineVariant => "#CFBDCD";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#ECDFE9";
    public string InverseOnSurface => "#000000";
    public string InversePrimary => "#00514D";
    // Primary Fixed
    public string PrimaryFixed => "#90F3EA";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#73D7CE";
    public string OnPrimaryFixedVariant => "#001413";
    // Secondary Fixed
    public string SecondaryFixed => "#FFD9E5";
    public string OnSecondaryFixed => "#000000";
    public string SecondaryFixedDim => "#EEB8CB";
    public string OnSecondaryFixedVariant => "#240615";
    // Tertiary Fixed
    public string TertiaryFixed => "#FFD6FA";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#E9B6E6";
    public string OnTertiaryFixedVariant => "#230227";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#241D24";
    public string SurfaceContainer => "#362E36";
    public string SurfaceContainerHigh => "#413941";
    public string SurfaceContainerHighest => "#4D444C";
}
