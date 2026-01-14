using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Rainbow;

internal class LightMode_NormalContrast_Spec2021_Green : ITestTheme
{
    public string SourceColor => "#338745"; //Green
    public bool IsDark => false;
    public Variant Variant => Variant.Rainbow;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#1B6C31";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#A3F5AA";
    public string OnPrimaryContainer => "#00531F";
    // Secondary
    public string Secondary => "#516350";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#D4E8D1";
    public string OnSecondaryContainer => "#3A4B3A";
    // Tertiary
    public string Tertiary => "#39656C";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#BDEAF3";
    public string OnTertiaryContainer => "#1F4D54";
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
    public string SurfaceTint => "#1B6C31";
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
    public string InversePrimary => "#88D990";
    // Primary Fixed
    public string PrimaryFixed => "#A3F5AA";
    public string OnPrimaryFixed => "#002108";
    public string PrimaryFixedDim => "#88D990";
    public string OnPrimaryFixedVariant => "#00531F";
    // Secondary Fixed
    public string SecondaryFixed => "#D4E8D1";
    public string OnSecondaryFixed => "#0F1F11";
    public string SecondaryFixedDim => "#B8CCB5";
    public string OnSecondaryFixedVariant => "#3A4B3A";
    // Tertiary Fixed
    public string TertiaryFixed => "#BDEAF3";
    public string OnTertiaryFixed => "#001F24";
    public string TertiaryFixedDim => "#A1CED6";
    public string OnTertiaryFixedVariant => "#1F4D54";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F3F3F3";
    public string SurfaceContainer => "#EEEEEE";
    public string SurfaceContainerHigh => "#E8E8E8";
    public string SurfaceContainerHighest => "#E2E2E2";
}
