using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class LightMode_HighContrast_Spec2025_Cyan : ITestTheme
{
    public string SourceColor => "#00BCD1"; //Cyan
    public bool IsDark => false;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#002429";
    public string OnPrimary => "#46E8FF";
    public string PrimaryContainer => "#005762";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#00232C";
    public string OnSecondary => "#82E2FF";
    public string SecondaryContainer => "#005669";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#001F42";
    public string OnTertiary => "#BED6FF";
    public string TertiaryContainer => "#004F96";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#480005";
    public string OnError => "#FFC7C3";
    public string ErrorContainer => "#A0071A";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#EAF9FF";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#00232C";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#DBF5FF";
    public string SurfaceContainer => "#C3EFFF";
    public string SurfaceContainerHigh => "#B2EBFF";
    public string SurfaceContainerHighest => "#A0E7FF";
}
