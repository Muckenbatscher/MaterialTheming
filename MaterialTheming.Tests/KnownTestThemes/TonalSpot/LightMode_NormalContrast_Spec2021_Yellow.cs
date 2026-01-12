using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class LightMode_NormalContrast_Spec2021_Yellow : ITestTheme
{
    public string SourceColor => "#B2B037"; //Yellow
    public bool IsDark => false;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#626117";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#E9E78E";
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

    public string Surface => "#FDF9EC";
    public string OnSurface => "#1C1C14";
    public string OnSurfaceVariant => "#48473A";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F7F4E6";
    public string SurfaceContainer => "#F2EEE0";
    public string SurfaceContainerHigh => "#ECE8DB";
    public string SurfaceContainerHighest => "#E6E2D5";
}
