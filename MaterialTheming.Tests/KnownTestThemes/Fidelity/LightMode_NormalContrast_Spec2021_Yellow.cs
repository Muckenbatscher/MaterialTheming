using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Fidelity;

internal class LightMode_NormalContrast_Spec2021_Yellow : ITestTheme
{
    public string SourceColor => "#B2B037"; //Yellow
    public bool IsDark => false;
    public Variant Variant => Variant.Fidelity;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#636100";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#B2B037";
    public string OnPrimaryContainer => "#434200";

    public string Secondary => "#626031";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#E5E3A7";
    public string OnSecondaryContainer => "#666535";

    public string Tertiary => "#6F4CA4";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#BF9AF8";
    public string OnTertiaryContainer => "#4F2C82";

    public string Error => "#BA1A1A";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#FFDAD6";
    public string OnErrorContainer => "#93000A";

    public string Surface => "#FDF9EB";
    public string OnSurface => "#1C1C14";
    public string OnSurfaceVariant => "#484736";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F7F4E5";
    public string SurfaceContainer => "#F2EEE0";
    public string SurfaceContainerHigh => "#ECE8DA";
    public string SurfaceContainerHighest => "#E6E3D5";
}
