using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class DarkMode_HighContrast_Spec2025_Blue : ITestTheme
{
    public string SourceColor => "#185FAA"; //Blue
    public bool IsDark => true;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#D9E6FF";
    public string OnPrimary => "#002C58";
    public string PrimaryContainer => "#A6C8FF";
    public string OnPrimaryContainer => "#001128";

    public string Secondary => "#D3EBDB";
    public string OnSecondary => "#1B3025";
    public string SecondaryContainer => "#92A99A";
    public string OnSecondaryContainer => "#000000";

    public string Tertiary => "#DDFFE4";
    public string OnTertiary => "#004023";
    public string TertiaryContainer => "#9AFDBF";
    public string OnTertiaryContainer => "#00361D";

    public string Error => "#FFDEDB";
    public string OnError => "#60000A";
    public string ErrorContainer => "#FF7C76";
    public string OnErrorContainer => "#000000";

    public string Surface => "#060E1B";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#D9E6FF";

    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#091423";
    public string SurfaceContainer => "#0D1A2C";
    public string SurfaceContainerHigh => "#112035";
    public string SurfaceContainerHighest => "#15263E";
}
