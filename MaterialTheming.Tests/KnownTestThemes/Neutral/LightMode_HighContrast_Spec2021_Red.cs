using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class LightMode_HighContrast_Spec2021_Red : ITestTheme
{
    public string SourceColor => "#D2463D"; //Red
    public bool IsDark => false;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#3B2725";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#5B4441";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#362927";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#554544";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#3F2522";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#60423E";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#600004";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#98000A";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#FFF8F7";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#000000";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F7EFEE";
    public string SurfaceContainer => "#E9E1DF";
    public string SurfaceContainerHigh => "#DBD3D1";
    public string SurfaceContainerHighest => "#CCC5C4";
}
