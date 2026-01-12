using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class LightMode_MediumContrast_Spec2025_Purple : ITestTheme
{
    public string SourceColor => "#945CCD"; //Purple
    public bool IsDark => false;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#5D00A3";
    public string OnPrimary => "#E6C9FF";
    public string PrimaryContainer => "#994CE6";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#611F7E";
    public string OnSecondary => "#F1C5FF";
    public string SecondaryContainer => "#9C58B8";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#7A192E";
    public string OnTertiary => "#FFC6CA";
    public string TertiaryContainer => "#C04F60";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#83002A";
    public string OnError => "#FFC6CA";
    public string ErrorContainer => "#D73357";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#FFF3FD";
    public string OnSurface => "#2E1538";
    public string OnSurfaceVariant => "#50355A";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FEEBFF";
    public string SurfaceContainer => "#FAE0FF";
    public string SurfaceContainerHigh => "#F8D8FF";
    public string SurfaceContainerHighest => "#F5D1FF";
}
