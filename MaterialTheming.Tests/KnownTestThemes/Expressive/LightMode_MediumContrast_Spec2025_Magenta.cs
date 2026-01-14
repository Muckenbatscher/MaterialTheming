using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class LightMode_MediumContrast_Spec2025_Magenta : ITestTheme
{
    public string SourceColor => "#E85DAE"; //Magenta
    public bool IsDark => false;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#722553";
    public string OnPrimary => "#FFCCE2";
    public string PrimaryContainer => "#AE5787";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#1A4A46";
    public string OnSecondary => "#B3E3DD";
    public string SecondaryContainer => "#4F7D78";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#004C44";
    public string OnTertiary => "#6AEFDC";
    public string TertiaryContainer => "#008376";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#85112F";
    public string OnError => "#FFCDD1";
    public string ErrorContainer => "#C8475D";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#FFF8F8";
    public string SurfaceVariant => "#FFD8E8";
    public string OnSurface => "#3D162C";
    public string OnSurfaceVariant => "#61354C";
    public string SurfaceDim => "#FFCCE3";
    public string SurfaceBright => "#FFF8F8";
    public string SurfaceTint => "#722553";
    // Background
    public string Background => "#FFF8F8";
    public string OnBackground => "#3D162C";
    // Outline
    public string Outline => "#815069";
    public string OutlineVariant => "#A06B85";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#1C0712";
    public string InverseOnSurface => "#E1BACB";
    public string InversePrimary => "#FD99CD";
    // Primary Fixed
    public string PrimaryFixed => "#AE5787";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#A04B7A";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#4F7D78";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#43706C";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#008376";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#00756A";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFF0F4";
    public string SurfaceContainer => "#FFE8F0";
    public string SurfaceContainerHigh => "#FFE0EC";
    public string SurfaceContainerHighest => "#FFD8E8";
}
