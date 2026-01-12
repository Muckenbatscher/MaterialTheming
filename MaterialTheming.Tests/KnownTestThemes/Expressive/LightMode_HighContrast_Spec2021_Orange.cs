using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class LightMode_HighContrast_Spec2021_Orange : ITestTheme
{
    public string SourceColor => "#D77837"; //Orange
    public bool IsDark => false;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#292262";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#474181";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#193217";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#364F32";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#003325";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#0D533F";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#600004";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#98000A";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#FFF8F5";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#000000";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFEEE0";
    public string SurfaceContainer => "#F2DFD1";
    public string SurfaceContainerHigh => "#E3D1C3";
    public string SurfaceContainerHighest => "#D5C3B5";
}
