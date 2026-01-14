using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class DarkMode_MediumContrast_Spec2021_Yellow : ITestTheme
{
    public string SourceColor => "#B2B037"; //Yellow
    public bool IsDark => true;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#E6E300";
    public string OnPrimary => "#282700";
    public string PrimaryContainer => "#979500";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#D7E2AD";
    public string OnSecondary => "#212905";
    public string SecondaryContainer => "#8C9567";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#C6E6A8";
    public string OnTertiary => "#142B02";
    public string TertiaryContainer => "#7C9963";
    public string OnTertiaryContainer => "#000000";
    // Error
    public string Error => "#FFD2CC";
    public string OnError => "#540003";
    public string ErrorContainer => "#FF5449";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#141407";
    public string SurfaceVariant => "#494833";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#E0DDC2";
    public string SurfaceDim => "#141407";
    public string SurfaceBright => "#464535";
    public string SurfaceTint => "#CFCC00";
    // Background
    public string Background => "#141407";
    public string OnBackground => "#E6E3CD";
    // Outline
    public string Outline => "#B5B399";
    public string OutlineVariant => "#939179";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#E6E3CD";
    public string InverseOnSurface => "#2B2B1C";
    public string InversePrimary => "#4B4A00";
    // Primary Fixed
    public string PrimaryFixed => "#ECE900";
    public string OnPrimaryFixed => "#121200";
    public string PrimaryFixedDim => "#CFCC00";
    public string OnPrimaryFixedVariant => "#393800";
    // Secondary Fixed
    public string SecondaryFixed => "#DEE8B3";
    public string OnSecondaryFixed => "#0E1300";
    public string SecondaryFixedDim => "#C2CC99";
    public string OnSecondaryFixedVariant => "#323A14";
    // Tertiary Fixed
    public string TertiaryFixed => "#CCEDAE";
    public string OnTertiaryFixed => "#061500";
    public string TertiaryFixedDim => "#B1D094";
    public string OnTertiaryFixedVariant => "#243D10";
    // Surface Container
    public string SurfaceContainerLowest => "#080801";
    public string SurfaceContainerLow => "#1F1E10";
    public string SurfaceContainer => "#29291A";
    public string SurfaceContainerHigh => "#343324";
    public string SurfaceContainerHighest => "#3F3E2E";
}
