using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Fidelity;

internal class LightMode_HighContrast_Spec2021_Cyan : ITestTheme
{
    public string SourceColor => "#00BCD1"; //Cyan
    public bool IsDark => false;
    public Variant Variant => Variant.Fidelity;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#003138";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#00515B";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#003138";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#1F5057";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#482200";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#733A00";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#600004";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#98000A";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#F4FAFC";
    public string SurfaceVariant => "#D7E5E8";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#000000";
    public string SurfaceDim => "#B3BABB";
    public string SurfaceBright => "#F4FAFC";
    public string SurfaceTint => "#006875";
    // Background
    public string Background => "#F4FAFC";
    public string OnBackground => "#161D1E";
    // Outline
    public string Outline => "#222E31";
    public string OutlineVariant => "#3E4B4E";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#2B3133";
    public string InverseOnSurface => "#FFFFFF";
    public string InversePrimary => "#45D8EE";
    // Primary Fixed
    public string PrimaryFixed => "#00515B";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#003940";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#1F5057";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#003940";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#733A00";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#522700";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#ECF2F3";
    public string SurfaceContainer => "#DDE4E5";
    public string SurfaceContainerHigh => "#CFD5D7";
    public string SurfaceContainerHighest => "#C1C8C9";
}
