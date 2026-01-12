using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class LightMode_MediumContrast_Spec2021_Orange : ITestTheme
{
    public string SourceColor => "#D77837"; //Orange
    public bool IsDark => false;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#5A2802";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#9D5D33";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#493121";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#856655";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#39380E";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#706F40";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#740006";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#CF2C27";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#FFF8F5";
    public string OnSurface => "#170F0B";
    public string OnSurfaceVariant => "#41332C";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFF1EA";
    public string SurfaceContainer => "#F6E5DD";
    public string SurfaceContainerHigh => "#EADAD1";
    public string SurfaceContainerHighest => "#DFCEC6";
}
