using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class LightMode_NormalContrast_Spec2025_Orange : ITestTheme
{
    public string SourceColor => "#D77837"; //Orange
    public bool IsDark => false;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#944500";
    public string OnPrimary => "#FFF0E9";
    public string PrimaryContainer => "#FF7B00";
    public string OnPrimaryContainer => "#3D1800";

    public string Secondary => "#8A4C00";
    public string OnSecondary => "#FFF0E6";
    public string SecondaryContainer => "#FFC697";
    public string OnSecondaryContainer => "#6D3B00";

    public string Tertiary => "#765600";
    public string OnTertiary => "#FFF1DC";
    public string TertiaryContainer => "#FFC32D";
    public string OnTertiaryContainer => "#584000";

    public string Error => "#B02500";
    public string OnError => "#FFEFEC";
    public string ErrorContainer => "#F95630";
    public string OnErrorContainer => "#520C00";

    public string Surface => "#FFF4EF";
    public string OnSurface => "#482603";
    public string OnSurfaceVariant => "#7D522B";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFEEE2";
    public string SurfaceContainer => "#FFE3CF";
    public string SurfaceContainerHigh => "#FFDCC1";
    public string SurfaceContainerHighest => "#FFD5B4";
}
