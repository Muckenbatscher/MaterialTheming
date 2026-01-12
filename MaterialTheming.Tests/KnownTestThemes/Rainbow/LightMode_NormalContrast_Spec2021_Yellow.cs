using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Rainbow;

internal class LightMode_NormalContrast_Spec2021_Yellow : ITestTheme
{
    public string SourceColor => "#B2B037"; //Yellow
    public bool IsDark => false;
    public Variant Variant => Variant.Rainbow;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#636100";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#EAE86E";
    public string OnPrimaryContainer => "#4A4900";

    public string Secondary => "#616042";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#E7E4BF";
    public string OnSecondaryContainer => "#49482D";

    public string Tertiary => "#3E6656";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#C0ECD7";
    public string OnTertiaryContainer => "#264E3F";

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
