using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.FruitSalad;

internal class LightMode_MediumContrast_Spec2025_Red : ITestTheme
{
    public string SourceColor => "#D2463D"; //Red
    public bool IsDark => false;
    public Variant Variant => Variant.FruitSalad;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#5C1A59";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#9B5394";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#53254F";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#905B89";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#5E231E";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#A25851";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#740006";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#CF2C27";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#FFF8F7";
    public string OnSurface => "#1B0E0C";
    public string OnSurfaceVariant => "#4B2F2C";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFF0EE";
    public string SurfaceContainer => "#FFE2DE";
    public string SurfaceContainerHigh => "#F3D7D3";
    public string SurfaceContainerHighest => "#E7CBC8";
}
