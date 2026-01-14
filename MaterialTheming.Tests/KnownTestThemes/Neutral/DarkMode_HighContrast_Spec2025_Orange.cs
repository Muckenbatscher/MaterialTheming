using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class DarkMode_HighContrast_Spec2025_Orange : ITestTheme
{
    public string SourceColor => "#D77837"; //Orange
    public bool IsDark => true;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#F7E1D6";
    public string OnPrimary => "#362922";
    public string PrimaryContainer => "#B3A096";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#EFE3DD";
    public string OnSecondary => "#312B27";
    public string SecondaryContainer => "#ACA29D";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#FFEEDB";
    public string OnTertiary => "#433011";
    public string TertiaryContainer => "#FFDDB1";
    public string OnTertiaryContainer => "#392708";
    // Error
    public string Error => "#FFDED7";
    public string OnError => "#591001";
    public string ErrorContainer => "#F48469";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#100E0D";
    public string SurfaceVariant => "#2A2522";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#EEE3DF";
    public string SurfaceDim => "#100E0D";
    public string SurfaceBright => "#312B28";
    public string SurfaceTint => "#F7E1D6";
    // Background
    public string Background => "#100E0D";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#C0B7B3";
    public string OutlineVariant => "#ABA29E";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#FFF8F6";
    public string InverseOnSurface => "#000000";
    public string InversePrimary => "#43352E";
    // Primary Fixed
    public string PrimaryFixed => "#F4DED3";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#E5D0C6";
    public string OnPrimaryFixedVariant => "#281D16";
    // Secondary Fixed
    public string SecondaryFixed => "#ECE0DB";
    public string OnSecondaryFixed => "#000000";
    public string SecondaryFixedDim => "#DED2CD";
    public string OnSecondaryFixedVariant => "#241E1B";
    // Tertiary Fixed
    public string TertiaryFixed => "#FFDDB1";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#F0CFA4";
    public string OnTertiaryFixedVariant => "#2D1C02";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#151311";
    public string SurfaceContainer => "#1C1917";
    public string SurfaceContainerHigh => "#231F1D";
    public string SurfaceContainerHighest => "#2A2522";
}
