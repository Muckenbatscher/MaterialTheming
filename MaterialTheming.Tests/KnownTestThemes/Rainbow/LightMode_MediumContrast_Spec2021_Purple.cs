using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Rainbow;

internal class LightMode_MediumContrast_Spec2021_Purple : ITestTheme
{
    public string SourceColor => "#945CCD"; //Purple
    public bool IsDark => false;
    public Variant Variant => Variant.Rainbow;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#492171";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#835AAD";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#3C3245";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#75697E";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#522A30";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#916066";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#740006";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#CF2C27";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#F9F9F9";
    public string OnSurface => "#111111";
    public string OnSurfaceVariant => "#363636";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F3F3F3";
    public string SurfaceContainer => "#E8E8E8";
    public string SurfaceContainerHigh => "#DDDDDD";
    public string SurfaceContainerHighest => "#D1D1D1";
}
