using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class LightMode_NormalContrast_Spec2025_Red : ITestTheme
{
    public string SourceColor => "#D2463D"; //Red
    public bool IsDark => false;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#8C4E47";
    public string OnPrimary => "#FFF7F6";
    public string PrimaryContainer => "#FDACA3";
    public string OnPrimaryContainer => "#622C27";

    public string Secondary => "#785753";
    public string OnSecondary => "#FFF7F6";
    public string SecondaryContainer => "#FFDAD6";
    public string OnSecondaryContainer => "#694A46";

    public string Tertiary => "#7B5828";
    public string OnTertiary => "#FFF7F3";
    public string TertiaryContainer => "#FFCF93";
    public string OnTertiaryContainer => "#654415";

    public string Error => "#A8364B";
    public string OnError => "#FFF7F7";
    public string ErrorContainer => "#F97386";
    public string OnErrorContainer => "#6E0523";

    public string Surface => "#FFF8F7";
    public string OnSurface => "#3E2F2D";
    public string OnSurfaceVariant => "#6D5B59";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFF0EE";
    public string SurfaceContainer => "#FEE9E6";
    public string SurfaceContainerHigh => "#FAE3E0";
    public string SurfaceContainerHighest => "#F6DDDA";
}
