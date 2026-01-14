using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class DarkMode_HighContrast_Spec2025_Orange : ITestTheme
{
    public string SourceColor => "#D77837"; //Orange
    public bool IsDark => true;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#FFDFCE";
    public string OnPrimary => "#46230A";
    public string PrimaryContainer => "#CF9776";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#FFDFCE";
    public string OnSecondary => "#3E2718";
    public string SecondaryContainer => "#C09C88";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#FFF6DE";
    public string OnTertiary => "#403601";
    public string TertiaryContainer => "#FAE8A2";
    public string OnTertiaryContainer => "#372D00";
    // Error
    public string Error => "#FFDED7";
    public string OnError => "#5A0E00";
    public string ErrorContainer => "#FF7E5E";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#130D09";
    public string SurfaceVariant => "#30231C";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#F8E1D5";
    public string SurfaceDim => "#130D09";
    public string SurfaceBright => "#362922";
    public string SurfaceTint => "#FFDFCE";
    // Background
    public string Background => "#130D09";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#CAB5AA";
    public string OutlineVariant => "#B4A095";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#FFF8F5";
    public string InverseOnSurface => "#000000";
    public string InversePrimary => "#552E15";
    // Primary Fixed
    public string PrimaryFixed => "#FCBF9B";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#EDB18F";
    public string OnPrimaryFixedVariant => "#090200";
    // Secondary Fixed
    public string SecondaryFixed => "#FFDBC8";
    public string OnSecondaryFixed => "#000000";
    public string SecondaryFixedDim => "#F4CCB7";
    public string OnSecondaryFixedVariant => "#301A0D";
    // Tertiary Fixed
    public string TertiaryFixed => "#FAE8A2";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#ECDA95";
    public string OnTertiaryFixedVariant => "#2B2300";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#1A120D";
    public string SurfaceContainer => "#211812";
    public string SurfaceContainerHigh => "#281D17";
    public string SurfaceContainerHighest => "#30231C";
}
