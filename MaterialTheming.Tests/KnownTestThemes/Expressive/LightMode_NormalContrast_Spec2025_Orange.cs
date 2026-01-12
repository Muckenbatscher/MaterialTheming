using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class LightMode_NormalContrast_Spec2025_Orange : ITestTheme
{
    public string SourceColor => "#D77837"; //Orange
    public bool IsDark => false;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#97490C";
    public string OnPrimary => "#FFF7F5";
    public string PrimaryContainer => "#FFAF7D";
    public string OnPrimaryContainer => "#652C00";

    public string Secondary => "#48617B";
    public string OnSecondary => "#F7F9FF";
    public string SecondaryContainer => "#CFE5FF";
    public string OnSecondaryContainer => "#3B546D";

    public string Tertiary => "#006497";
    public string OnTertiary => "#F6F9FF";
    public string TertiaryContainer => "#6FC0FF";
    public string OnTertiaryContainer => "#003A5A";

    public string Error => "#AA371C";
    public string OnError => "#FFF7F6";
    public string ErrorContainer => "#FA7150";
    public string OnErrorContainer => "#671200";

    public string Surface => "#FFF8F5";
    public string OnSurface => "#4D2A04";
    public string OnSurfaceVariant => "#82552C";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFF1E8";
    public string SurfaceContainer => "#FFEADC";
    public string SurfaceContainerHigh => "#FFE3CF";
    public string SurfaceContainerHighest => "#FFDCC1";
}
