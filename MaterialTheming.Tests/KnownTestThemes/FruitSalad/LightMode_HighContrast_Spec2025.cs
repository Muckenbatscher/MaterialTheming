using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.FruitSalad;

internal class LightMode_HighContrast_Spec2025 : ITestTheme
{
    public string SourceColor => "#B2B037"; //yellow
    public bool IsDark => false;
    public Variant Variant => Variant.FruitSalad;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#462300";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#703C00";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#462300";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#6E3D07";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#2E2E00";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#4D4C00";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#600004";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#98000A";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#FEFAE3";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#000000";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F5F1DA";
    public string SurfaceContainer => "#E6E3CD";
    public string SurfaceContainerHigh => "#D8D5BF";
    public string SurfaceContainerHighest => "#CAC7B1";
}
