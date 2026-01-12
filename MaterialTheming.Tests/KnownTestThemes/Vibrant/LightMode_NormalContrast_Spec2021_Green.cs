using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class LightMode_NormalContrast_Spec2021_Green : ITestTheme
{
    public string SourceColor => "#338745"; //Green
    public bool IsDark => false;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#006E2B";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#69FF89";
    public string OnPrimaryContainer => "#00531F";

    public string Secondary => "#406653";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#C2ECD3";
    public string OnSecondaryContainer => "#284E3C";

    public string Tertiary => "#22695B";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#ABF0DE";
    public string OnTertiaryContainer => "#005144";

    public string Error => "#BA1A1A";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#FFDAD6";
    public string OnErrorContainer => "#93000A";

    public string Surface => "#F2FCEE";
    public string OnSurface => "#151E15";
    public string OnSurfaceVariant => "#3E4A3D";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#ECF7E8";
    public string SurfaceContainer => "#E7F1E2";
    public string SurfaceContainerHigh => "#E1EBDD";
    public string SurfaceContainerHighest => "#DBE5D7";
}
