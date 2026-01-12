using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class LightMode_HighContrast_Spec2021_Red : ITestTheme
{
    public string SourceColor => "#D2463D"; //Red
    public bool IsDark => false;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#600004";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#98000C";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#462312";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#683F2C";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#462300";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#6B3E12";
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
    public string SurfaceContainer => "#F9DCD9";
    public string SurfaceContainerHigh => "#EACECB";
    public string SurfaceContainerHighest => "#DCC0BD";
}
