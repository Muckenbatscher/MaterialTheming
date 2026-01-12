using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class DarkMode_NormalContrast_Spec2021_Cyan : ITestTheme
{
    public string SourceColor => "#00BCD1"; //Cyan
    public bool IsDark => true;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#00DAF2";
    public string OnPrimary => "#00363D";
    public string PrimaryContainer => "#004F58";
    public string OnPrimaryContainer => "#9AF0FF";

    public string Secondary => "#A6CCDF";
    public string OnSecondary => "#093544";
    public string SecondaryContainer => "#254B5B";
    public string OnSecondaryContainer => "#C2E8FC";

    public string Tertiary => "#A0CBF3";
    public string OnTertiary => "#003351";
    public string TertiaryContainer => "#1A4A6C";
    public string OnTertiaryContainer => "#CCE5FF";

    public string Error => "#FFB4AB";
    public string OnError => "#690005";
    public string ErrorContainer => "#93000A";
    public string OnErrorContainer => "#FFDAD6";

    public string Surface => "#091517";
    public string OnSurface => "#D7E5E8";
    public string OnSurfaceVariant => "#B8CACD";

    public string SurfaceContainerLowest => "#051012";
    public string SurfaceContainerLow => "#111D20";
    public string SurfaceContainer => "#152224";
    public string SurfaceContainerHigh => "#202C2E";
    public string SurfaceContainerHighest => "#2B3739";
}
