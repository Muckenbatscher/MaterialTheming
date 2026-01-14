using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class LightMode_HighContrast_Spec2025_Orange : ITestTheme
{
    public string SourceColor => "#D77837"; //Orange
    public bool IsDark => false;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#3F1900";
    public string OnPrimary => "#FFD1B7";
    public string PrimaryContainer => "#794522";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#351F11";
    public string OnSecondary => "#FAD2BC";
    public string SecondaryContainer => "#684C3B";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#2B2300";
    public string OnTertiary => "#ECDA95";
    public string TertiaryContainer => "#5E521B";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#4C0A00";
    public string OnError => "#FFCFC4";
    public string ErrorContainer => "#952E15";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#FFF8F5";
    public string SurfaceVariant => "#F5DED2";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#2E211A";
    public string SurfaceDim => "#ECD6CA";
    public string SurfaceBright => "#FFF8F5";
    public string SurfaceTint => "#3F1900";
    // Background
    public string Background => "#FFF8F5";
    public string OnBackground => "#000000";
    // Outline
    public string Outline => "#4F4038";
    public string OutlineVariant => "#5F4F46";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#130D09";
    public string InverseOnSurface => "#FFFFFF";
    public string InversePrimary => "#FFB68B";
    // Primary Fixed
    public string PrimaryFixed => "#794522";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#6B3A18";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#684C3B";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#5B4131";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#5E521B";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#514610";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFF1EA";
    public string SurfaceContainer => "#FEEAE0";
    public string SurfaceContainerHigh => "#F9E4DA";
    public string SurfaceContainerHighest => "#F5DED2";
}
