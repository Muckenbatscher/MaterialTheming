using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class DarkMode_HighContrast_Spec2021_Yellow : ITestTheme
{
    public string SourceColor => "#B2B037"; //Yellow
    public bool IsDark => true;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#FAF700";
    public string OnPrimary => "#000000";
    public string PrimaryContainer => "#CBC800";
    public string OnPrimaryContainer => "#0C0C00";
    // Secondary
    public string Secondary => "#EBF5BF";
    public string OnSecondary => "#000000";
    public string SecondaryContainer => "#BEC895";
    public string OnSecondaryContainer => "#090D00";
    // Tertiary
    public string Tertiary => "#DAFABB";
    public string OnTertiary => "#000000";
    public string TertiaryContainer => "#ADCC91";
    public string OnTertiaryContainer => "#040E00";
    // Error
    public string Error => "#FFECE9";
    public string OnError => "#000000";
    public string ErrorContainer => "#FFAEA4";
    public string OnErrorContainer => "#220001";
    // Surface
    public string Surface => "#141407";
    public string SurfaceVariant => "#494833";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#FFFFFF";
    public string SurfaceDim => "#141407";
    public string SurfaceBright => "#525140";
    public string SurfaceTint => "#CFCC00";
    // Background
    public string Background => "#141407";
    public string OnBackground => "#E6E3CD";
    // Outline
    public string Outline => "#F4F1D5";
    public string OutlineVariant => "#C6C4A9";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#E6E3CD";
    public string InverseOnSurface => "#000000";
    public string InversePrimary => "#4B4A00";
    // Primary Fixed
    public string PrimaryFixed => "#ECE900";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#CFCC00";
    public string OnPrimaryFixedVariant => "#121200";
    // Secondary Fixed
    public string SecondaryFixed => "#DEE8B3";
    public string OnSecondaryFixed => "#000000";
    public string SecondaryFixedDim => "#C2CC99";
    public string OnSecondaryFixedVariant => "#0E1300";
    // Tertiary Fixed
    public string TertiaryFixed => "#CCEDAE";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#B1D094";
    public string OnTertiaryFixedVariant => "#061500";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#212012";
    public string SurfaceContainer => "#323122";
    public string SurfaceContainerHigh => "#3D3C2C";
    public string SurfaceContainerHighest => "#484737";
}
