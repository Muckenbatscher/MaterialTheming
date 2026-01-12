using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class LightMode_MediumContrast_Spec2021_Blue : ITestTheme
{
    public string SourceColor => "#185FAA"; //Blue
    public bool IsDark => false;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#003669";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#006DCA";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#2D3553";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#646C8D";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#34305F";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#6C679A";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#740006";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#CF2C27";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#F9F9FF";
    public string OnSurface => "#0C111A";
    public string OnSurfaceVariant => "#303642";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F0F3FF";
    public string SurfaceContainer => "#E4E8F4";
    public string SurfaceContainerHigh => "#D8DDE9";
    public string SurfaceContainerHighest => "#CDD1DE";
}
