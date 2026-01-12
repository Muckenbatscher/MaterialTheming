using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class LightMode_NormalContrast_Spec2021_Red : ITestTheme
{
    public string SourceColor => "#D2463D"; //Red
    public bool IsDark => false;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#715855";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#FDDBD7";
    public string OnPrimaryContainer => "#58413F";

    public string Secondary => "#6B5A58";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#F5DDDA";
    public string OnSecondaryContainer => "#534341";

    public string Tertiary => "#775653";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#FFDAD6";
    public string OnTertiaryContainer => "#5D3F3C";

    public string Error => "#BA1A1A";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#FFDAD6";
    public string OnErrorContainer => "#93000A";

    public string Surface => "#FFF8F7";
    public string OnSurface => "#1E1B1A";
    public string OnSurfaceVariant => "#4A4645";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FAF2F0";
    public string SurfaceContainer => "#F4ECEB";
    public string SurfaceContainerHigh => "#EFE6E5";
    public string SurfaceContainerHighest => "#E9E1DF";
}
