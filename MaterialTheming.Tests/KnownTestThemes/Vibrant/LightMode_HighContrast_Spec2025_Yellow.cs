using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class LightMode_HighContrast_Spec2025_Yellow : ITestTheme
{
    public string SourceColor => "#B2B037"; //Yellow
    public bool IsDark => false;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#212100";
    public string OnPrimary => "#DEDB00";
    public string PrimaryContainer => "#525100";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#271F00";
    public string OnSecondary => "#F7D239";
    public string SecondaryContainer => "#5E4D00";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#2A1D00";
    public string OnTertiary => "#FFCE5E";
    public string TertiaryContainer => "#654A00";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#440800";
    public string OnError => "#FFC8BB";
    public string ErrorContainer => "#991F00";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#FFF6E1";
    public string SurfaceVariant => "#F5DC81";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#271F00";
    public string SurfaceDim => "#EDD374";
    public string SurfaceBright => "#FFF6E1";
    public string SurfaceTint => "#212100";
    // Background
    public string Background => "#FFF6E1";
    public string OnBackground => "#000000";
    // Outline
    public string Outline => "#4B3E08";
    public string OutlineVariant => "#5B4E17";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#130E00";
    public string InverseOnSurface => "#FFFFFF";
    public string InversePrimary => "#FEFB07";
    // Primary Fixed
    public string PrimaryFixed => "#525100";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#464500";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#5E4D00";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#504200";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#654A00";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#573F00";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFF0C4";
    public string SurfaceContainer => "#FFE796";
    public string SurfaceContainerHigh => "#FAE18C";
    public string SurfaceContainerHighest => "#F5DC81";
}
