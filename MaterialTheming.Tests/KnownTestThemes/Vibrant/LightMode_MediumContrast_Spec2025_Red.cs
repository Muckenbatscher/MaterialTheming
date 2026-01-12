using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class LightMode_MediumContrast_Spec2025_Red : ITestTheme
{
    public string SourceColor => "#D2463D"; //Red
    public bool IsDark => false;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#850009";
    public string OnPrimary => "#FFC7C0";
    public string PrimaryContainer => "#D24038";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#7A1930";
    public string OnSecondary => "#FFC6CB";
    public string SecondaryContainer => "#C04F63";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#5A2286";
    public string OnTertiary => "#E9C8FF";
    public string TertiaryContainer => "#935CC1";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#83002A";
    public string OnError => "#FFC6CA";
    public string ErrorContainer => "#D73357";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#FFF4F4";
    public string OnSurface => "#3A1219";
    public string OnSurfaceVariant => "#613138";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFECED";
    public string SurfaceContainer => "#FFE1E3";
    public string SurfaceContainerHigh => "#FFD9DC";
    public string SurfaceContainerHighest => "#FFD2D6";
}
