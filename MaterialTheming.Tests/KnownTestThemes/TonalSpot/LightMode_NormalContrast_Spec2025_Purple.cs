using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class LightMode_NormalContrast_Spec2025_Purple : ITestTheme
{
    public string SourceColor => "#945CCD"; //Purple
    public bool IsDark => false;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#6D5585";
    public string OnPrimary => "#FFF6FF";
    public string PrimaryContainer => "#E4C6FE";
    public string OnPrimaryContainer => "#543D6C";

    public string Secondary => "#665B70";
    public string OnSecondary => "#FFF6FF";
    public string SecondaryContainer => "#EDDDF6";
    public string OnSecondaryContainer => "#594D62";

    public string Tertiary => "#805168";
    public string OnTertiary => "#FFF7F8";
    public string TertiaryContainer => "#F7BBD7";
    public string OnTertiaryContainer => "#61364C";

    public string Error => "#A8364B";
    public string OnError => "#FFF7F7";
    public string ErrorContainer => "#F97386";
    public string OnErrorContainer => "#6E0523";

    public string Surface => "#FFF7FE";
    public string OnSurface => "#363039";
    public string OnSurfaceVariant => "#635D67";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F9F1F9";
    public string SurfaceContainer => "#F4EBF5";
    public string SurfaceContainerHigh => "#EEE5F0";
    public string SurfaceContainerHighest => "#E9DFEB";
}
