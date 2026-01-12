using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class LightMode_NormalContrast_Spec2025_Green : ITestTheme
{
    public string SourceColor => "#338745"; //Green
    public bool IsDark => false;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#3D6942";
    public string OnPrimary => "#E9FFE5";
    public string PrimaryContainer => "#BEEFBE";
    public string OnPrimaryContainer => "#305B36";

    public string Secondary => "#526451";
    public string OnSecondary => "#EAFFE6";
    public string SecondaryContainer => "#D4E8D1";
    public string OnSecondaryContainer => "#455644";

    public string Tertiary => "#5C6330";
    public string OnTertiary => "#F7FEBC";
    public string TertiaryContainer => "#F8FFBC";
    public string OnTertiaryContainer => "#5C632F";

    public string Error => "#A73B21";
    public string OnError => "#FFF7F6";
    public string ErrorContainer => "#FD795A";
    public string OnErrorContainer => "#6E1400";

    public string Surface => "#F8FAF3";
    public string OnSurface => "#2D342C";
    public string OnSurfaceVariant => "#596158";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F1F5EC";
    public string SurfaceContainer => "#EAF0E6";
    public string SurfaceContainerHigh => "#E4EADF";
    public string SurfaceContainerHighest => "#DDE5D9";
}
