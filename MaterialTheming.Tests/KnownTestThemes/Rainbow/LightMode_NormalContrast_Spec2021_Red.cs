using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Rainbow;

internal class LightMode_NormalContrast_Spec2021_Red : ITestTheme
{
    public string SourceColor => "#D2463D"; //Red
    public bool IsDark => false;
    public Variant Variant => Variant.Rainbow;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#9C423A";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#FFDAD6";
    public string OnPrimaryContainer => "#7D2B25";

    public string Secondary => "#775653";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#FFDAD6";
    public string OnSecondaryContainer => "#5D3F3C";

    public string Tertiary => "#715B2E";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#FDDFA6";
    public string OnTertiaryContainer => "#584419";

    public string Error => "#BA1A1A";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#FFDAD6";
    public string OnErrorContainer => "#93000A";

    public string Surface => "#F9F9F9";
    public string OnSurface => "#1B1B1B";
    public string OnSurfaceVariant => "#474747";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F3F3F3";
    public string SurfaceContainer => "#EEEEEE";
    public string SurfaceContainerHigh => "#E8E8E8";
    public string SurfaceContainerHighest => "#E2E2E2";
}
