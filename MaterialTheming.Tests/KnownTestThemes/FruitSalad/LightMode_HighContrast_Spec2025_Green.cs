using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.FruitSalad;

internal class LightMode_HighContrast_Spec2025_Green : ITestTheme
{
    public string SourceColor => "#338745"; //Green
    public bool IsDark => false;
    public Variant Variant => Variant.FruitSalad;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#342C00";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#554900";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#342C00";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#554900";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#003411";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#20532A";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#600004";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#98000A";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#F2FCEE";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#000000";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#E9F4E5";
    public string SurfaceContainer => "#DBE5D7";
    public string SurfaceContainerHigh => "#CDD7C9";
    public string SurfaceContainerHighest => "#BFC9BC";
}
