using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class LightMode_HighContrast_Spec2021_Orange : ITestTheme
{
    public string SourceColor => "#D77837"; //Orange
    public bool IsDark => false;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#3A281D";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#5A4539";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#362A23";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#55463E";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#3E2718";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#5E4333";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#600004";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#98000A";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#FFF8F5";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#000000";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F7EFEC";
    public string SurfaceContainer => "#E9E1DE";
    public string SurfaceContainerHigh => "#DAD3D0";
    public string SurfaceContainerHighest => "#CCC5C2";
}
