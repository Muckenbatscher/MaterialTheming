using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class LightMode_MediumContrast_Spec2021_Blue : ITestTheme
{
    public string SourceColor => "#185FAA"; //Blue
    public bool IsDark => false;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#303642";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#676D7A";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#33363D";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#6A6D75";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#2D3747";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#636D80";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#740006";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#CF2C27";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#FBF8FA";
    public string OnSurface => "#111112";
    public string OnSurfaceVariant => "#363637";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F6F3F4";
    public string SurfaceContainer => "#EAE7E9";
    public string SurfaceContainerHigh => "#DFDCDD";
    public string SurfaceContainerHighest => "#D3D1D2";
}
