using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class LightMode_HighContrast_Spec2025_Red : ITestTheme
{
    public string SourceColor => "#D2463D"; //Red
    public bool IsDark => false;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#480002";
    public string OnPrimary => "#FFC7C1";
    public string PrimaryContainer => "#9C1717";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#470014";
    public string OnSecondary => "#FFC6CC";
    public string SecondaryContainer => "#8E293F";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#330057";
    public string OnTertiary => "#E9C9FF";
    public string TertiaryContainer => "#6A3497";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#470013";
    public string OnError => "#FFC6CB";
    public string ErrorContainer => "#A00035";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#FFF4F4";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#3A1219";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFECED";
    public string SurfaceContainer => "#FFE1E3";
    public string SurfaceContainerHigh => "#FFD9DC";
    public string SurfaceContainerHighest => "#FFD2D6";
}
