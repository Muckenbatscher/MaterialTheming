using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Rainbow;

internal class DarkMode_HighContrast_Spec2021_Green : ITestTheme
{
    public string SourceColor => "#338745"; //Green
    public bool IsDark => true;
    public Variant Variant => Variant.Rainbow;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#C2FFC4";
    public string OnPrimary => "#000000";
    public string PrimaryContainer => "#84D58D";
    public string OnPrimaryContainer => "#000F02";
    // Secondary
    public string Secondary => "#E1F6DE";
    public string OnSecondary => "#000000";
    public string SecondaryContainer => "#B4C8B2";
    public string OnSecondaryContainer => "#020E03";
    // Tertiary
    public string Tertiary => "#CEF7FF";
    public string OnTertiary => "#000000";
    public string TertiaryContainer => "#9DCAD2";
    public string OnTertiaryContainer => "#000E10";
    // Error
    public string Error => "#FFECE9";
    public string OnError => "#000000";
    public string ErrorContainer => "#FFAEA4";
    public string OnErrorContainer => "#220001";
    // Surface
    public string Surface => "#131313";
    public string SurfaceVariant => "#474747";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#FFFFFF";
    public string SurfaceDim => "#131313";
    public string SurfaceBright => "#505050";
    public string SurfaceTint => "#88D990";
    // Background
    public string Background => "#131313";
    public string OnBackground => "#E2E2E2";
    // Outline
    public string Outline => "#F0F0F0";
    public string OutlineVariant => "#C2C2C2";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#E2E2E2";
    public string InverseOnSurface => "#000000";
    public string InversePrimary => "#00541F";
    // Primary Fixed
    public string PrimaryFixed => "#A3F5AA";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#88D990";
    public string OnPrimaryFixedVariant => "#001504";
    // Secondary Fixed
    public string SecondaryFixed => "#D4E8D1";
    public string OnSecondaryFixed => "#000000";
    public string SecondaryFixedDim => "#B8CCB5";
    public string OnSecondaryFixedVariant => "#051407";
    // Tertiary Fixed
    public string TertiaryFixed => "#BDEAF3";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#A1CED6";
    public string OnTertiaryFixedVariant => "#001417";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#1F1F1F";
    public string SurfaceContainer => "#303030";
    public string SurfaceContainerHigh => "#3B3B3B";
    public string SurfaceContainerHighest => "#474747";
}
