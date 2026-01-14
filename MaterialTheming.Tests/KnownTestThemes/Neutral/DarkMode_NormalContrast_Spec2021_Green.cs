using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class DarkMode_NormalContrast_Spec2021_Green : ITestTheme
{
    public string SourceColor => "#338745"; //Green
    public bool IsDark => true;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#BDCABA";
    public string OnPrimary => "#283328";
    public string PrimaryContainer => "#3E4A3D";
    public string OnPrimaryContainer => "#D9E6D5";
    // Secondary
    public string Secondary => "#C1C9BE";
    public string OnSecondary => "#2B322B";
    public string SecondaryContainer => "#424940";
    public string OnSecondaryContainer => "#DDE5D9";
    // Tertiary
    public string Tertiary => "#B8CCB5";
    public string OnTertiary => "#243424";
    public string TertiaryContainer => "#3A4B3A";
    public string OnTertiaryContainer => "#D4E8D1";
    // Error
    public string Error => "#FFB4AB";
    public string OnError => "#690005";
    public string ErrorContainer => "#93000A";
    public string OnErrorContainer => "#FFDAD6";
    // Surface
    public string Surface => "#131412";
    public string SurfaceVariant => "#464745";
    public string OnSurface => "#E4E2DF";
    public string OnSurfaceVariant => "#C7C6C3";
    public string SurfaceDim => "#131412";
    public string SurfaceBright => "#393937";
    public string SurfaceTint => "#BDCABA";
    // Background
    public string Background => "#131412";
    public string OnBackground => "#E4E2DF";
    // Outline
    public string Outline => "#91918E";
    public string OutlineVariant => "#464745";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#E4E2DF";
    public string InverseOnSurface => "#30312F";
    public string InversePrimary => "#556254";
    // Primary Fixed
    public string PrimaryFixed => "#D9E6D5";
    public string OnPrimaryFixed => "#131E14";
    public string PrimaryFixedDim => "#BDCABA";
    public string OnPrimaryFixedVariant => "#3E4A3D";
    // Secondary Fixed
    public string SecondaryFixed => "#DDE5D9";
    public string OnSecondaryFixed => "#171D16";
    public string SecondaryFixedDim => "#C1C9BE";
    public string OnSecondaryFixedVariant => "#424940";
    // Tertiary Fixed
    public string TertiaryFixed => "#D4E8D1";
    public string OnTertiaryFixed => "#0F1F11";
    public string TertiaryFixedDim => "#B8CCB5";
    public string OnTertiaryFixedVariant => "#3A4B3A";
    // Surface Container
    public string SurfaceContainerLowest => "#0D0E0D";
    public string SurfaceContainerLow => "#1B1C1A";
    public string SurfaceContainer => "#1F201E";
    public string SurfaceContainerHigh => "#292A28";
    public string SurfaceContainerHighest => "#343533";
}
