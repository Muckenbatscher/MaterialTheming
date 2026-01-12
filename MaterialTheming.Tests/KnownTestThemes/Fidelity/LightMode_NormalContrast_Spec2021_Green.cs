using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Fidelity;

internal class LightMode_NormalContrast_Spec2021_Green : ITestTheme
{
    public string SourceColor => "#338745"; //Green
    public bool IsDark => false;
    public Variant Variant => Variant.Fidelity;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#0D6A2C";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#308443";
    public string OnPrimaryContainer => "#F7FFF2";

    public string Secondary => "#466648";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#C8ECC6";
    public string OnSecondaryContainer => "#4C6C4E";

    public string Tertiary => "#9C3E59";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#BB5671";
    public string OnTertiaryContainer => "#140004";

    public string Error => "#BA1A1A";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#FFDAD6";
    public string OnErrorContainer => "#93000A";

    public string Surface => "#F6FBF2";
    public string OnSurface => "#181D18";
    public string OnSurfaceVariant => "#40493F";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F1F5EC";
    public string SurfaceContainer => "#EBEFE6";
    public string SurfaceContainerHigh => "#E5EAE1";
    public string SurfaceContainerHighest => "#DFE4DB";
}
