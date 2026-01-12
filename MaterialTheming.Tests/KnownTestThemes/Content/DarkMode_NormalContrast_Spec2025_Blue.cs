using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Content;

internal class DarkMode_NormalContrast_Spec2025_Blue : ITestTheme
{
    public string SourceColor => "#185FAA"; //Blue
    public bool IsDark => true;
    public Variant Variant => Variant.Content;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#A6C8FF";
    public string OnPrimary => "#00315F";
    public string PrimaryContainer => "#185FAA";
    public string OnPrimaryContainer => "#C5DAFF";

    public string Secondary => "#B3C7EB";
    public string OnSecondary => "#1D314D";
    public string SecondaryContainer => "#344765";
    public string OnSecondaryContainer => "#A2B6D9";

    public string Tertiary => "#EEB0FF";
    public string OnTertiary => "#4E1363";
    public string TertiaryContainer => "#814695";
    public string OnTertiaryContainer => "#F6CAFF";

    public string Error => "#FFB4AB";
    public string OnError => "#690005";
    public string ErrorContainer => "#93000A";
    public string OnErrorContainer => "#FFDAD6";

    public string Surface => "#111318";
    public string OnSurface => "#E1E2E9";
    public string OnSurfaceVariant => "#C2C6D3";

    public string SurfaceContainerLowest => "#0C0E13";
    public string SurfaceContainerLow => "#191C21";
    public string SurfaceContainer => "#1D2025";
    public string SurfaceContainerHigh => "#272A2F";
    public string SurfaceContainerHighest => "#32353A";
}
