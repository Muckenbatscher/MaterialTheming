using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class DarkMode_MediumContrast_Spec2025_Blue : ITestTheme
{
    public string SourceColor => "#185FAA"; //Blue
    public bool IsDark => true;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#BED6FF";
    public string OnPrimary => "#19406E";
    public string PrimaryContainer => "#A6C8FF";
    public string OnPrimaryContainer => "#0C3765";

    public string Secondary => "#B4CCBC";
    public string OnSecondary => "#263B2F";
    public string SecondaryContainer => "#637A6C";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#DDFFE4";
    public string OnTertiary => "#006038";
    public string TertiaryContainer => "#9AFDBF";
    public string OnTertiaryContainer => "#005732";

    public string Error => "#FF9F99";
    public string OnError => "#60000A";
    public string ErrorContainer => "#C94947";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#060E1B";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#A9BAD8";

    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#091423";
    public string SurfaceContainer => "#0D1A2C";
    public string SurfaceContainerHigh => "#112035";
    public string SurfaceContainerHighest => "#15263E";
}
