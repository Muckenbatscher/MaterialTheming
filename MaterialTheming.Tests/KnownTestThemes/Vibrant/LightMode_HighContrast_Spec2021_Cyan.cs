using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class LightMode_HighContrast_Spec2021_Cyan : ITestTheme
{
    public string SourceColor => "#00BCD1"; //Cyan
    public bool IsDark => false;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#003138";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#00515B";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#023040";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#284E5E";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#002F4A";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#1D4D6E";
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
