using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class LightMode_HighContrast_Spec2021_Red : ITestTheme
{
    public string SourceColor => "#D2463D"; //Red
    public bool IsDark => false;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#002B5F";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#254881";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#292F09";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#464D24";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#0F330F";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#2D5129";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#600004";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#98000A";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#FFF8F6";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#000000";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFEDE7";
    public string SurfaceContainer => "#F5DED6";
    public string SurfaceContainerHigh => "#E6D0C8";
    public string SurfaceContainerHighest => "#D8C2BB";
}
