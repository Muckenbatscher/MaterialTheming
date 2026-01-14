using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class LightMode_HighContrast_Spec2025_Magenta : ITestTheme
{
    public string SourceColor => "#E85DAE"; //Magenta
    public bool IsDark => false;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#3F142D";
    public string OnPrimary => "#FFCCE3";
    public string PrimaryContainer => "#76415D";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#331D28";
    public string OnSecondary => "#F4D1DF";
    public string SecondaryContainer => "#654B57";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#311A3D";
    public string OnTertiary => "#F0CEFD";
    public string TertiaryContainer => "#63486F";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#500016";
    public string OnError => "#FFCED2";
    public string ErrorContainer => "#97283E";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#FFF8F8";
    public string SurfaceVariant => "#F1DDE4";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#2C2126";
    public string SurfaceDim => "#E9D5DC";
    public string SurfaceBright => "#FFF8F8";
    public string SurfaceTint => "#3F142D";
    // Background
    public string Background => "#FFF8F8";
    public string OnBackground => "#000000";
    // Outline
    public string Outline => "#4C3F45";
    public string OutlineVariant => "#5C4E54";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#120D0F";
    public string InverseOnSurface => "#FFFFFF";
    public string InversePrimary => "#FDB8D9";
    // Primary Fixed
    public string PrimaryFixed => "#76415D";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#683651";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#654B57";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#583F4B";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#63486F";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#563D62";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFF0F4";
    public string SurfaceContainer => "#FBEAEF";
    public string SurfaceContainerHigh => "#F6E4E9";
    public string SurfaceContainerHighest => "#F1DDE4";
}
