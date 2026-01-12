using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class LightMode_MediumContrast_Spec2021_Yellow : ITestTheme
{
    public string SourceColor => "#B2B037"; //Yellow
    public bool IsDark => false;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#383724";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#6F6E58";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#37372A";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#6F6E5F";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#38371D";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#706E50";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#740006";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#CF2C27";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#FDF9F4";
    public string OnSurface => "#12110F";
    public string OnSurfaceVariant => "#373633";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F7F3EE";
    public string SurfaceContainer => "#EBE7E3";
    public string SurfaceContainerHigh => "#E0DCD8";
    public string SurfaceContainerHighest => "#D5D1CD";
}
