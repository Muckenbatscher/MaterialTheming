using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class LightMode_MediumContrast_Spec2025_Blue : ITestTheme
{
    public string SourceColor => "#185FAA"; //Blue
    public bool IsDark => false;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#004380";
    public string OnPrimary => "#C6DBFF";
    public string PrimaryContainer => "#3D76BE";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#254A37";
    public string OnSecondary => "#BAE3CA";
    public string SecondaryContainer => "#567D67";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#004E2C";
    public string OnTertiary => "#8CEEB1";
    public string TertiaryContainer => "#1A8552";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#84161B";
    public string OnError => "#FFCECA";
    public string ErrorContainer => "#C94947";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#F9F9FF";
    public string OnSurface => "#062446";
    public string OnSurfaceVariant => "#2B4466";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F0F3FF";
    public string SurfaceContainer => "#E7EEFF";
    public string SurfaceContainerHigh => "#DEE9FF";
    public string SurfaceContainerHighest => "#D5E3FF";
}
