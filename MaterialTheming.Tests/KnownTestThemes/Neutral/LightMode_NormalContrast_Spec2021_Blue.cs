using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class LightMode_NormalContrast_Spec2021_Blue : ITestTheme
{
    public string SourceColor => "#185FAA"; //Blue
    public bool IsDark => false;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#585F6B";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#DCE2F2";
    public string OnPrimaryContainer => "#404753";

    public string Secondary => "#5B5E66";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#E0E2EC";
    public string OnSecondaryContainer => "#43474E";

    public string Tertiary => "#555F71";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#D9E3F8";
    public string OnTertiaryContainer => "#3D4758";

    public string Error => "#BA1A1A";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#FFDAD6";
    public string OnErrorContainer => "#93000A";

    public string Surface => "#FBF8FA";
    public string OnSurface => "#1B1B1D";
    public string OnSurfaceVariant => "#474648";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F6F3F4";
    public string SurfaceContainer => "#F0EDEE";
    public string SurfaceContainerHigh => "#EAE7E9";
    public string SurfaceContainerHighest => "#E4E2E3";
}
