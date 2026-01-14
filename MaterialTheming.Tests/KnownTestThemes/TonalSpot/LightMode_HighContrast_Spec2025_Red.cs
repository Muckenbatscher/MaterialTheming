using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class LightMode_HighContrast_Spec2025_Red : ITestTheme
{
    public string SourceColor => "#D2463D"; //Red
    public bool IsDark => false;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#431411";
    public string OnPrimary => "#FFCFC9";
    public string PrimaryContainer => "#7D413B";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#361D1A";
    public string OnSecondary => "#FCD0CB";
    public string SecondaryContainer => "#6A4A47";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#351F00";
    public string OnTertiary => "#FFD39C";
    public string TertiaryContainer => "#6D4C1C";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#500016";
    public string OnError => "#FFCED2";
    public string ErrorContainer => "#97283E";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#FFF8F7";
    public string SurfaceVariant => "#F6DDDA";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#2E211F";
    public string SurfaceDim => "#EDD5D2";
    public string SurfaceBright => "#FFF8F7";
    public string SurfaceTint => "#431411";
    // Background
    public string Background => "#FFF8F7";
    public string OnBackground => "#000000";
    // Outline
    public string Outline => "#4F3F3D";
    public string OutlineVariant => "#5F4E4C";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#130C0C";
    public string InverseOnSurface => "#FFFFFF";
    public string InversePrimary => "#FFB1A8";
    // Primary Fixed
    public string PrimaryFixed => "#7D413B";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#6F3630";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#6A4A47";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#5D3F3B";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#6D4C1C";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#604011";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFF0EE";
    public string SurfaceContainer => "#FEE9E6";
    public string SurfaceContainerHigh => "#FAE3E0";
    public string SurfaceContainerHighest => "#F6DDDA";
}
