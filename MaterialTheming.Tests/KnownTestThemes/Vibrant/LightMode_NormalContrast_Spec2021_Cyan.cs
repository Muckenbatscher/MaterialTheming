using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class LightMode_NormalContrast_Spec2021_Cyan : ITestTheme
{
    public string SourceColor => "#00BCD1"; //Cyan
    public bool IsDark => false;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#006875";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#9AF0FF";
    public string OnPrimaryContainer => "#004F58";

    public string Secondary => "#3E6374";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#C2E8FC";
    public string OnSecondaryContainer => "#254B5B";

    public string Tertiary => "#366285";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#CCE5FF";
    public string OnTertiaryContainer => "#1A4A6C";

    public string Error => "#BA1A1A";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#FFDAD6";
    public string OnErrorContainer => "#93000A";

    public string Surface => "#EEFCFF";
    public string OnSurface => "#111D20";
    public string OnSurfaceVariant => "#39494D";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#E9F6F9";
    public string SurfaceContainer => "#E3F0F3";
    public string SurfaceContainerHigh => "#DDEBED";
    public string SurfaceContainerHighest => "#D7E5E8";
}
