using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class LightMode_MediumContrast_Spec2021_Green : ITestTheme
{
    public string SourceColor => "#338745"; //Green
    public bool IsDark => false;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#2D392D";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#647062";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#313830";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#686F66";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#2A3A2A";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#60725F";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#740006";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#CF2C27";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#FBF9F6";
    public string OnSurface => "#101110";
    public string OnSurfaceVariant => "#363634";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F5F3F0";
    public string SurfaceContainer => "#EAE8E5";
    public string SurfaceContainerHigh => "#DEDDDA";
    public string SurfaceContainerHighest => "#D3D1CE";
}
