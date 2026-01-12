using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class LightMode_NormalContrast_Spec2021_Red : ITestTheme
{
    public string SourceColor => "#D2463D"; //Red
    public bool IsDark => false;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#904A43";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#FFDAD6";
    public string OnPrimaryContainer => "#73332D";

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

    public string Surface => "#FFF8F7";
    public string OnSurface => "#231918";
    public string OnSurfaceVariant => "#534341";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFF0EE";
    public string SurfaceContainer => "#FCEAE7";
    public string SurfaceContainerHigh => "#F6E4E2";
    public string SurfaceContainerHighest => "#F1DEDC";
}
