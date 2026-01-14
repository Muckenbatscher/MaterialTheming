using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Rainbow;

internal class LightMode_NormalContrast_Spec2025_Yellow : ITestTheme
{
    public string SourceColor => "#B2B037"; //Yellow
    public bool IsDark => false;
    public Variant Variant => Variant.Rainbow;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#636100";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#EAE86E";
    public string OnPrimaryContainer => "#4A4900";
    // Secondary
    public string Secondary => "#616042";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#E7E4BF";
    public string OnSecondaryContainer => "#49482D";
    // Tertiary
    public string Tertiary => "#3E6656";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#C0ECD7";
    public string OnTertiaryContainer => "#264E3F";
    // Error
    public string Error => "#BA1A1A";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#FFDAD6";
    public string OnErrorContainer => "#93000A";
    // Surface
    public string Surface => "#F9F9F9";
    public string SurfaceVariant => "#E2E2E2";
    public string OnSurface => "#1B1B1B";
    public string OnSurfaceVariant => "#474747";
    public string SurfaceDim => "#DADADA";
    public string SurfaceBright => "#F9F9F9";
    public string SurfaceTint => "#636100";
    // Background
    public string Background => "#F9F9F9";
    public string OnBackground => "#1B1B1B";
    // Outline
    public string Outline => "#777777";
    public string OutlineVariant => "#C6C6C6";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#303030";
    public string InverseOnSurface => "#F1F1F1";
    public string InversePrimary => "#CECB56";
    // Primary Fixed
    public string PrimaryFixed => "#EAE86E";
    public string OnPrimaryFixed => "#1D1D00";
    public string PrimaryFixedDim => "#CECB56";
    public string OnPrimaryFixedVariant => "#4A4900";
    // Secondary Fixed
    public string SecondaryFixed => "#E7E4BF";
    public string OnSecondaryFixed => "#1D1D06";
    public string SecondaryFixedDim => "#CBC8A4";
    public string OnSecondaryFixedVariant => "#49482D";
    // Tertiary Fixed
    public string TertiaryFixed => "#C0ECD7";
    public string OnTertiaryFixed => "#002116";
    public string TertiaryFixedDim => "#A4D0BC";
    public string OnTertiaryFixedVariant => "#264E3F";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F3F3F3";
    public string SurfaceContainer => "#EEEEEE";
    public string SurfaceContainerHigh => "#E8E8E8";
    public string SurfaceContainerHighest => "#E2E2E2";
}
