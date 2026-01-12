using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class LightMode_NormalContrast_Spec2021_Green : ITestTheme
{
    public string SourceColor => "#338745"; //Green
    public bool IsDark => false;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#556254";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#D9E6D5";
    public string OnPrimaryContainer => "#3E4A3D";

    public string Secondary => "#596057";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#DDE5D9";
    public string OnSecondaryContainer => "#424940";

    public string Tertiary => "#516350";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#D4E8D1";
    public string OnTertiaryContainer => "#3A4B3A";

    public string Error => "#BA1A1A";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#FFDAD6";
    public string OnErrorContainer => "#93000A";

    public string Surface => "#FBF9F6";
    public string OnSurface => "#1B1C1A";
    public string OnSurfaceVariant => "#464745";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F5F3F0";
    public string SurfaceContainer => "#EFEEEA";
    public string SurfaceContainerHigh => "#EAE8E5";
    public string SurfaceContainerHighest => "#E4E2DF";
}
