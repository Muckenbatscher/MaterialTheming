using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class DarkMode_NormalContrast_Spec2025_Yellow : ITestTheme
{
    public string SourceColor => "#B2B037"; //Yellow
    public bool IsDark => true;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#CCC98D";
    public string OnPrimary => "#434214";
    public string PrimaryContainer => "#555424";
    public string OnPrimaryContainer => "#E9E6A8";

    public string Secondary => "#CBC8A4";
    public string OnSecondary => "#424127";
    public string SecondaryContainer => "#3D3D22";
    public string OnSecondaryContainer => "#C3C19D";

    public string Tertiary => "#FFE4C0";
    public string OnTertiary => "#6D501D";
    public string TertiaryContainer => "#FED494";
    public string OnTertiaryContainer => "#644715";

    public string Error => "#F97758";
    public string OnError => "#450900";
    public string ErrorContainer => "#85230A";
    public string OnErrorContainer => "#FF9B82";

    public string Surface => "#0F0E08";
    public string OnSurface => "#E9E6D3";
    public string OnSurfaceVariant => "#AEAC9A";

    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#14140C";
    public string SurfaceContainer => "#1A1A11";
    public string SurfaceContainerHigh => "#212016";
    public string SurfaceContainerHighest => "#27261A";
}
