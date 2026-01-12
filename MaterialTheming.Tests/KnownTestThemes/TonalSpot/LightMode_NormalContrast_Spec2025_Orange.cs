using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class LightMode_NormalContrast_Spec2025_Orange : ITestTheme
{
    public string SourceColor => "#D77837"; //Orange
    public bool IsDark => false;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#88512E";
    public string OnPrimary => "#FFF7F5";
    public string PrimaryContainer => "#FFB68B";
    public string OnPrimaryContainer => "#633412";

    public string Secondary => "#765947";
    public string OnSecondary => "#FFF7F5";
    public string SecondaryContainer => "#FFDBC8";
    public string OnSecondaryContainer => "#684C3B";

    public string Tertiary => "#6B5F27";
    public string OnTertiary => "#FFF8EB";
    public string TertiaryContainer => "#FAE8A2";
    public string OnTertiaryContainer => "#61551E";

    public string Error => "#A73B21";
    public string OnError => "#FFF7F6";
    public string ErrorContainer => "#FD795A";
    public string OnErrorContainer => "#6E1400";

    public string Surface => "#FFF8F5";
    public string OnSurface => "#3D3028";
    public string OnSurfaceVariant => "#6C5C53";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFF1EA";
    public string SurfaceContainer => "#FEEAE0";
    public string SurfaceContainerHigh => "#F9E4DA";
    public string SurfaceContainerHighest => "#F5DED2";
}
