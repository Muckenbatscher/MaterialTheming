using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class LightMode_NormalContrast_Spec2021_Yellow : ITestTheme
{
    public string SourceColor => "#B2B037"; //Yellow
    public bool IsDark => false;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#636100";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#ECE900";
    public string OnPrimaryContainer => "#4A4900";

    public string Secondary => "#596239";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#DEE8B3";
    public string OnSecondaryContainer => "#424A23";

    public string Tertiary => "#4B6635";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#CCEDAE";
    public string OnTertiaryContainer => "#344E1F";

    public string Error => "#BA1A1A";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#FFDAD6";
    public string OnErrorContainer => "#93000A";

    public string Surface => "#FEFAE3";
    public string OnSurface => "#1D1C0E";
    public string OnSurfaceVariant => "#494833";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F8F4DD";
    public string SurfaceContainer => "#F2EFD8";
    public string SurfaceContainerHigh => "#ECE9D2";
    public string SurfaceContainerHighest => "#E6E3CD";
}
