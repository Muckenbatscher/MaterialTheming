using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class LightMode_HighContrast_Spec2021_Purple : ITestTheme
{
    public string SourceColor => "#945CCD"; //Purple
    public bool IsDark => false;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#3A1F54";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#583D73";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#32283B";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#504559";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#462127";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#683D43";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#600004";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#98000A";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#FFF7FE";
    public string SurfaceVariant => "#E9DFEB";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#000000";
    public string SurfaceDim => "#BEB7BE";
    public string SurfaceBright => "#FFF7FE";
    public string SurfaceTint => "#6E528A";
    // Background
    public string Background => "#FFF7FE";
    public string OnBackground => "#1E1A20";
    // Outline
    public string Outline => "#2F2A33";
    public string OutlineVariant => "#4D4750";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#332F35";
    public string InverseOnSurface => "#FFFFFF";
    public string InversePrimary => "#DBB9F9";
    // Primary Fixed
    public string PrimaryFixed => "#583D73";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#40265B";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#504559";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#392F42";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#683D43";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#4E272D";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F6EEF6";
    public string SurfaceContainer => "#E8E0E8";
    public string SurfaceContainerHigh => "#DAD2DA";
    public string SurfaceContainerHighest => "#CBC4CC";
}
