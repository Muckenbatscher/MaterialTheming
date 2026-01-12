using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class LightMode_HighContrast_Spec2025_Orange : ITestTheme
{
    public string SourceColor => "#D77837"; //Orange
    public bool IsDark => false;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#3F1900";
    public string OnPrimary => "#FFD1B7";
    public string PrimaryContainer => "#863D00";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#08263D";
    public string OnSecondary => "#C3DDFB";
    public string SecondaryContainer => "#3B546E";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#00263E";
    public string OnTertiary => "#BBDEFF";
    public string TertiaryContainer => "#005784";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#4C0A00";
    public string OnError => "#FFCFC4";
    public string ErrorContainer => "#982B10";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#FFF8F5";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#3A1C00";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFF1E8";
    public string SurfaceContainer => "#FFEADC";
    public string SurfaceContainerHigh => "#FFE3CF";
    public string SurfaceContainerHighest => "#FFDCC1";
}
