using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class LightMode_HighContrast_Spec2021_Green : ITestTheme
{
    public string SourceColor => "#338745"; //Green
    public bool IsDark => false;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#53180D";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#793426";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#063325";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#285141";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#003231";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#005251";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#600004";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#98000A";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#F3FCF3";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#000000";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#EAF3EB";
    public string SurfaceContainer => "#DCE5DD";
    public string SurfaceContainerHigh => "#CDD7CF";
    public string SurfaceContainerHighest => "#C0C9C1";
}
