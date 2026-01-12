using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class LightMode_NormalContrast_Spec2025_Cyan : ITestTheme
{
    public string SourceColor => "#00BCD1"; //Cyan
    public bool IsDark => false;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#006571";
    public string OnPrimary => "#D8F9FF";
    public string PrimaryContainer => "#00E3FC";
    public string OnPrimaryContainer => "#004D57";

    public string Secondary => "#006479";
    public string OnSecondary => "#E0F6FF";
    public string SecondaryContainer => "#76DFFF";
    public string OnSecondaryContainer => "#004E5F";

    public string Tertiary => "#005BAD";
    public string OnTertiary => "#EEF2FF";
    public string TertiaryContainer => "#7FB2FF";
    public string OnTertiaryContainer => "#003061";

    public string Error => "#B31B25";
    public string OnError => "#FFEFEE";
    public string ErrorContainer => "#FB5151";
    public string OnErrorContainer => "#570008";

    public string Surface => "#EAF9FF";
    public string OnSurface => "#003440";
    public string OnSurfaceVariant => "#2D6272";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#DBF5FF";
    public string SurfaceContainer => "#C3EFFF";
    public string SurfaceContainerHigh => "#B2EBFF";
    public string SurfaceContainerHighest => "#A0E7FF";
}
