using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class LightMode_MediumContrast_Spec2025_Orange : ITestTheme
{
    public string SourceColor => "#D77837"; //Orange
    public bool IsDark => false;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#6E3100";
    public string OnPrimary => "#FFD0B6";
    public string PrimaryContainer => "#B25E22";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#2C455E";
    public string OnSecondary => "#C2DCFB";
    public string SecondaryContainer => "#5E7792";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#00476C";
    public string OnTertiary => "#BADEFF";
    public string TertiaryContainer => "#0E7BB6";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#821B02";
    public string OnError => "#FFCFC4";
    public string ErrorContainer => "#C74C2F";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#FFF8F5";
    public string OnSurface => "#3A1C00";
    public string OnSurfaceVariant => "#613A13";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFF1E8";
    public string SurfaceContainer => "#FFEADC";
    public string SurfaceContainerHigh => "#FFE3CF";
    public string SurfaceContainerHighest => "#FFDCC1";
}
