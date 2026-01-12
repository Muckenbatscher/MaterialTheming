using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class LightMode_HighContrast_Spec2025_Orange : ITestTheme
{
    public string SourceColor => "#D77837"; //Orange
    public bool IsDark => false;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#381600";
    public string OnPrimary => "#FFC9AB";
    public string PrimaryContainer => "#813B00";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#331900";
    public string OnSecondary => "#FFCA9F";
    public string SecondaryContainer => "#784100";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#2B1D00";
    public string OnTertiary => "#FFCE63";
    public string TertiaryContainer => "#664A00";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#440800";
    public string OnError => "#FFC8BB";
    public string ErrorContainer => "#991F00";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#FFF4EF";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#331900";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFEEE2";
    public string SurfaceContainer => "#FFE3CF";
    public string SurfaceContainerHigh => "#FFDCC1";
    public string SurfaceContainerHighest => "#FFD5B4";
}
