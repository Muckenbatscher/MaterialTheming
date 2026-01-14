using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class LightMode_NormalContrast_Spec2021_Cyan : ITestTheme
{
    public string SourceColor => "#00BCD1"; //Cyan
    public bool IsDark => false;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#516164";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#D4E6E9";
    public string OnPrimaryContainer => "#39494D";
    // Secondary
    public string Secondary => "#576062";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#DBE4E6";
    public string OnSecondaryContainer => "#3F484A";
    // Tertiary
    public string Tertiary => "#4A6267";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#CDE7EC";
    public string OnTertiaryContainer => "#334B4F";
    // Error
    public string Error => "#BA1A1A";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#FFDAD6";
    public string OnErrorContainer => "#93000A";
    // Surface
    public string Surface => "#FAF9F9";
    public string SurfaceVariant => "#E3E2E2";
    public string OnSurface => "#1B1C1C";
    public string OnSurfaceVariant => "#464747";
    public string SurfaceDim => "#DBDADA";
    public string SurfaceBright => "#FAF9F9";
    public string SurfaceTint => "#516164";
    // Background
    public string Background => "#FAF9F9";
    public string OnBackground => "#1B1C1C";
    // Outline
    public string Outline => "#777777";
    public string OutlineVariant => "#C7C6C6";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#2F3031";
    public string InverseOnSurface => "#F2F0F0";
    public string InversePrimary => "#B8CACD";
    // Primary Fixed
    public string PrimaryFixed => "#D4E6E9";
    public string OnPrimaryFixed => "#0E1E21";
    public string PrimaryFixedDim => "#B8CACD";
    public string OnPrimaryFixedVariant => "#39494D";
    // Secondary Fixed
    public string SecondaryFixed => "#DBE4E6";
    public string OnSecondaryFixed => "#141D1F";
    public string SecondaryFixedDim => "#BFC8CA";
    public string OnSecondaryFixedVariant => "#3F484A";
    // Tertiary Fixed
    public string TertiaryFixed => "#CDE7EC";
    public string OnTertiaryFixed => "#051F23";
    public string TertiaryFixedDim => "#B1CBD0";
    public string OnTertiaryFixedVariant => "#334B4F";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F5F3F3";
    public string SurfaceContainer => "#EFEDED";
    public string SurfaceContainerHigh => "#E9E8E8";
    public string SurfaceContainerHighest => "#E3E2E2";
}
