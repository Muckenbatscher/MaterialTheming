using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Fidelity;

internal class DarkMode_NormalContrast_Spec2025_Green : ITestTheme
{
    public string SourceColor => "#338745"; //Green
    public bool IsDark => true;
    public Variant Variant => Variant.Fidelity;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#84D98E";
    public string OnPrimary => "#003913";
    public string PrimaryContainer => "#4EA25C";
    public string OnPrimaryContainer => "#000801";

    public string Secondary => "#ACD0AB";
    public string OnSecondary => "#19371D";
    public string SecondaryContainer => "#2F4E32";
    public string OnSecondaryContainer => "#9BBE9B";

    public string Tertiary => "#FFB1C2";
    public string OnTertiary => "#600E2C";
    public string TertiaryContainer => "#BB5671";
    public string OnTertiaryContainer => "#140004";

    public string Error => "#FFB4AB";
    public string OnError => "#690005";
    public string ErrorContainer => "#93000A";
    public string OnErrorContainer => "#FFDAD6";

    public string Surface => "#101510";
    public string OnSurface => "#DFE4DB";
    public string OnSurfaceVariant => "#BFCABB";

    public string SurfaceContainerLowest => "#0B0F0B";
    public string SurfaceContainerLow => "#181D18";
    public string SurfaceContainer => "#1C211B";
    public string SurfaceContainerHigh => "#262B26";
    public string SurfaceContainerHighest => "#313630";
}
