using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.FruitSalad;

internal class LightMode_NormalContrast_Spec2025 : ITestTheme
{
    public string SourceColor => "#945CCD"; //purple
    public bool IsDark => false;
    public Variant Variant => Variant.FruitSalad;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#215FA6";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#D5E3FF";
    public string OnPrimaryContainer => "#004787";

    public string Secondary => "#3D5F90";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#D5E3FF";
    public string OnSecondaryContainer => "#234776";

    public string Tertiary => "#6E528A";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#F0DBFF";
    public string OnTertiaryContainer => "#563B71";

    public string Error => "#BA1A1A";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#FFDAD6";
    public string OnErrorContainer => "#93000A";

    public string Surface => "#FFF7FE";
    public string OnSurface => "#1F1923";
    public string OnSurfaceVariant => "#4D4357";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FBF0FF";
    public string SurfaceContainer => "#F5EAF9";
    public string SurfaceContainerHigh => "#F0E5F3";
    public string SurfaceContainerHighest => "#EADFED";
}
