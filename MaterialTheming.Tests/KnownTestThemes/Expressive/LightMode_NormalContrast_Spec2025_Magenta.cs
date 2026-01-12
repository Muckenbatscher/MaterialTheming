using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class LightMode_NormalContrast_Spec2025_Magenta : ITestTheme
{
    public string SourceColor => "#E85DAE"; //Magenta
    public bool IsDark => false;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#954271";
    public string OnPrimary => "#FFF7F8";
    public string PrimaryContainer => "#FFA6D3";
    public string OnPrimaryContainer => "#6A1E4C";

    public string Secondary => "#396763";
    public string OnSecondary => "#E1FFFB";
    public string SecondaryContainer => "#CAFAF4";
    public string OnSecondaryContainer => "#34625E";

    public string Tertiary => "#006B60";
    public string OnTertiary => "#E2FFF8";
    public string TertiaryContainer => "#6EF2DF";
    public string OnTertiaryContainer => "#00594F";

    public string Error => "#AC3149";
    public string OnError => "#FFF7F7";
    public string ErrorContainer => "#F76A80";
    public string OnErrorContainer => "#68001F";

    public string Surface => "#FFF8F8";
    public string OnSurface => "#4E243B";
    public string OnSurfaceVariant => "#815069";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFF0F4";
    public string SurfaceContainer => "#FFE8F0";
    public string SurfaceContainerHigh => "#FFE0EC";
    public string SurfaceContainerHighest => "#FFD8E8";
}
