using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Content;

internal class LightMode_HighContrast_Spec2025_Red : ITestTheme
{
    public string SourceColor => "#D2463D"; //Red
    public bool IsDark => false;
    public Variant Variant => Variant.Content;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#600004";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#911615";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#531814";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#78342E";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#3F2700";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#654200";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#600004";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#98000A";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#FFF8F7";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#000000";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFEDEA";
    public string SurfaceContainer => "#F6DDDA";
    public string SurfaceContainerHigh => "#E8CFCC";
    public string SurfaceContainerHighest => "#D9C1BE";
}
