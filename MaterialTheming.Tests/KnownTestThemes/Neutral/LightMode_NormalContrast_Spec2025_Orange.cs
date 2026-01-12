using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class LightMode_NormalContrast_Spec2025_Orange : ITestTheme
{
    public string SourceColor => "#D77837"; //Orange
    public bool IsDark => false;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#6B5B53";
    public string OnPrimary => "#FFF6F2";
    public string PrimaryContainer => "#F4DED3";
    public string OnPrimaryContainer => "#5E4F47";

    public string Secondary => "#665D59";
    public string OnSecondary => "#FFF7F5";
    public string SecondaryContainer => "#ECE0DB";
    public string OnSecondaryContainer => "#58504C";

    public string Tertiary => "#735B38";
    public string OnTertiary => "#FFF8F2";
    public string TertiaryContainer => "#FFDDB1";
    public string OnTertiaryContainer => "#654E2C";

    public string Error => "#9E422C";
    public string OnError => "#FFF7F6";
    public string ErrorContainer => "#FE8B70";
    public string OnErrorContainer => "#742410";

    public string Surface => "#FFF8F6";
    public string OnSurface => "#37312F";
    public string OnSurfaceVariant => "#645E5A";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FAF2EF";
    public string SurfaceContainer => "#F5ECE9";
    public string SurfaceContainerHigh => "#F0E6E2";
    public string SurfaceContainerHighest => "#EBE0DC";
}
