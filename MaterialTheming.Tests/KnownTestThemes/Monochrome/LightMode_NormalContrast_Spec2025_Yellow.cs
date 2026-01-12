using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Monochrome;

internal class LightMode_NormalContrast_Spec2025_Yellow : ITestTheme
{
    public string SourceColor => "#B2B037"; //Yellow
    public bool IsDark => false;
    public Variant Variant => Variant.Monochrome;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#000000";
    public string OnPrimary => "#E2E2E2";
    public string PrimaryContainer => "#3B3B3B";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#5E5E5E";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#D4D4D4";
    public string OnSecondaryContainer => "#1B1B1B";

    public string Tertiary => "#3B3B3B";
    public string OnTertiary => "#E2E2E2";
    public string TertiaryContainer => "#747474";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#BA1A1A";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#FFDAD6";
    public string OnErrorContainer => "#410002";

    public string Surface => "#F9F9F9";
    public string OnSurface => "#1B1B1B";
    public string OnSurfaceVariant => "#474747";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F3F3F3";
    public string SurfaceContainer => "#EEEEEE";
    public string SurfaceContainerHigh => "#E8E8E8";
    public string SurfaceContainerHighest => "#E2E2E2";
}
