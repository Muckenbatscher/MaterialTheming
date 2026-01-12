using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class LightMode_MediumContrast_Spec2021_Cyan : ITestTheme
{
    public string SourceColor => "#00BCD1"; //Cyan
    public bool IsDark => false;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#29393C";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#5F7073";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#2F3839";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#656F71";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#223A3E";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#597176";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#740006";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#CF2C27";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#FAF9F9";
    public string OnSurface => "#101112";
    public string OnSurfaceVariant => "#353636";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F5F3F3";
    public string SurfaceContainer => "#E9E8E8";
    public string SurfaceContainerHigh => "#DDDCDC";
    public string SurfaceContainerHighest => "#D2D1D1";
}
