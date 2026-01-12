using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class DarkMode_NormalContrast_Spec2025_Blue : ITestTheme
{
    public string SourceColor => "#185FAA"; //Blue
    public bool IsDark => true;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#78B0FF";
    public string OnPrimary => "#002F5C";
    public string PrimaryContainer => "#5BA2FF";
    public string OnPrimaryContainer => "#002347";

    public string Secondary => "#719BFF";
    public string OnSecondary => "#001D50";
    public string SecondaryContainer => "#0845A6";
    public string OnSecondaryContainer => "#CAD7FF";

    public string Tertiary => "#EAA5FF";
    public string OnTertiary => "#5D1877";
    public string TertiaryContainer => "#E094F8";
    public string OnTertiaryContainer => "#52076C";

    public string Error => "#FF716C";
    public string OnError => "#490006";
    public string ErrorContainer => "#9F0519";
    public string OnErrorContainer => "#FFA8A3";

    public string Surface => "#000C2B";
    public string OnSurface => "#DEE5FF";
    public string OnSurfaceVariant => "#9CAAD5";

    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#001136";
    public string SurfaceContainer => "#011742";
    public string SurfaceContainerHigh => "#041D4B";
    public string SurfaceContainerHighest => "#082355";
}
