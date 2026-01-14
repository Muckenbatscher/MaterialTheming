using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class LightMode_HighContrast_Spec2025_Red : ITestTheme
{
    public string SourceColor => "#D2463D"; //Red
    public bool IsDark => false;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#4D0706";
    public string OnPrimary => "#FFCFC9";
    public string PrimaryContainer => "#8C362F";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#002834";
    public string OnSecondary => "#B8E0F2";
    public string SecondaryContainer => "#305766";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#002832";
    public string OnTertiary => "#95E6FF";
    public string TertiaryContainer => "#005A6D";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#500016";
    public string OnError => "#FFCED2";
    public string ErrorContainer => "#9A243D";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#FFF8F6";
    public string SurfaceVariant => "#FFDBD1";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#40170B";
    public string SurfaceDim => "#FFCFC2";
    public string SurfaceBright => "#FFF8F6";
    public string SurfaceTint => "#4D0706";
    // Background
    public string Background => "#FFF8F6";
    public string OnBackground => "#000000";
    // Outline
    public string Outline => "#673526";
    public string OutlineVariant => "#794434";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#1E0803";
    public string InverseOnSurface => "#FFFFFF";
    public string InversePrimary => "#FFB1A8";
    // Primary Fixed
    public string PrimaryFixed => "#8C362F";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#7D2A24";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#305766";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#234B5A";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#005A6D";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#004E5E";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFF1ED";
    public string SurfaceContainer => "#FFE9E4";
    public string SurfaceContainerHigh => "#FFE2DA";
    public string SurfaceContainerHighest => "#FFDBD1";
}
