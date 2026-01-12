using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class LightMode_HighContrast_Spec2025_Blue : ITestTheme
{
    public string SourceColor => "#185FAA"; //Blue
    public bool IsDark => false;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#002449";
    public string OnPrimary => "#C7DBFF";
    public string PrimaryContainer => "#075299";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#022A1A";
    public string OnSecondary => "#BAE4CA";
    public string SecondaryContainer => "#345A46";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#002A16";
    public string OnTertiary => "#8CEEB1";
    public string TertiaryContainer => "#005F37";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#510007";
    public string OnError => "#FFCFCB";
    public string ErrorContainer => "#9A2728";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#F9F9FF";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#062446";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F0F3FF";
    public string SurfaceContainer => "#E7EEFF";
    public string SurfaceContainerHigh => "#DEE9FF";
    public string SurfaceContainerHighest => "#D5E3FF";
}
