using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.FruitSalad;

internal class LightMode_HighContrast_Spec2025_Purple : ITestTheme
{
    public string SourceColor => "#945CCD"; //Purple
    public bool IsDark => false;
    public Variant Variant => Variant.FruitSalad;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#002C58";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#00498B";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#002C58";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#264A79";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#3A1F54";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#583D73";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#600004";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#98000A";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#FFF7FE";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#000000";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F8EDFC";
    public string SurfaceContainer => "#EADFED";
    public string SurfaceContainerHigh => "#DBD1DF";
    public string SurfaceContainerHighest => "#CDC3D1";
}
