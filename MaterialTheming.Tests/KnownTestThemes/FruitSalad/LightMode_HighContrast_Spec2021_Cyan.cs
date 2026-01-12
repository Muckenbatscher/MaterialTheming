using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.FruitSalad;

internal class LightMode_HighContrast_Spec2021_Cyan : ITestTheme
{
    public string SourceColor => "#00BCD1"; //Cyan
    public bool IsDark => false;
    public Variant Variant => Variant.FruitSalad;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#00341D";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#005533";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#00341D";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#0B5434";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#003138";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#00515B";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#600004";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#98000A";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#EEFCFF";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#000000";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#E6F3F6";
    public string SurfaceContainer => "#D7E5E8";
    public string SurfaceContainerHigh => "#C9D7DA";
    public string SurfaceContainerHighest => "#BBC9CC";
}
