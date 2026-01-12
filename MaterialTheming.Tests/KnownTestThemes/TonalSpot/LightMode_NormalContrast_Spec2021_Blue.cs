using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class LightMode_NormalContrast_Spec2021_Blue : ITestTheme
{
    public string SourceColor => "#185FAA"; //Blue
    public bool IsDark => false;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#3D5F90";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#D5E3FF";
    public string OnPrimaryContainer => "#234776";

    public string Secondary => "#555F71";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#D9E3F8";
    public string OnSecondaryContainer => "#3D4758";

    public string Tertiary => "#6E5676";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#F7D8FF";
    public string OnTertiaryContainer => "#553F5D";

    public string Error => "#BA1A1A";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#FFDAD6";
    public string OnErrorContainer => "#93000A";

    public string Surface => "#F9F9FF";
    public string OnSurface => "#191C20";
    public string OnSurfaceVariant => "#43474E";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F3F3FA";
    public string SurfaceContainer => "#EDEDF4";
    public string SurfaceContainerHigh => "#E7E8EE";
    public string SurfaceContainerHighest => "#E1E2E9";
}
