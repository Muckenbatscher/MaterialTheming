using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class LightMode_NormalContrast_Spec2021_Cyan : ITestTheme
{
    public string SourceColor => "#00BCD1"; //Cyan
    public bool IsDark => false;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#516164";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#D4E6E9";
    public string OnPrimaryContainer => "#39494D";

    public string Secondary => "#576062";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#DBE4E6";
    public string OnSecondaryContainer => "#3F484A";

    public string Tertiary => "#4A6267";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#CDE7EC";
    public string OnTertiaryContainer => "#334B4F";

    public string Error => "#BA1A1A";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#FFDAD6";
    public string OnErrorContainer => "#93000A";

    public string Surface => "#FAF9F9";
    public string OnSurface => "#1B1C1C";
    public string OnSurfaceVariant => "#464747";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F5F3F3";
    public string SurfaceContainer => "#EFEDED";
    public string SurfaceContainerHigh => "#E9E8E8";
    public string SurfaceContainerHighest => "#E3E2E2";
}
