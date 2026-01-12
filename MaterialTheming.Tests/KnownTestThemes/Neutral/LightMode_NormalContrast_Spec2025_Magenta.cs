using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class LightMode_NormalContrast_Spec2025_Magenta : ITestTheme
{
    public string SourceColor => "#E85DAE"; //Magenta
    public bool IsDark => false;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#685B60";
    public string OnPrimary => "#FFF5F7";
    public string PrimaryContainer => "#F1DEE4";
    public string OnPrimaryContainer => "#5B4E53";

    public string Secondary => "#655D5F";
    public string OnSecondary => "#FFF7F8";
    public string SecondaryContainer => "#EBE0E2";
    public string OnSecondaryContainer => "#575052";

    public string Tertiary => "#6B5873";
    public string OnTertiary => "#FFF7FC";
    public string TertiaryContainer => "#F6DDFD";
    public string OnTertiaryContainer => "#5F4D67";

    public string Error => "#9E3F4E";
    public string OnError => "#FFF7F7";
    public string ErrorContainer => "#FF8B9A";
    public string OnErrorContainer => "#782232";

    public string Surface => "#FEF8F8";
    public string OnSurface => "#363133";
    public string OnSurfaceVariant => "#635D5F";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F9F2F2";
    public string SurfaceContainer => "#F4ECED";
    public string SurfaceContainerHigh => "#EFE6E7";
    public string SurfaceContainerHighest => "#E9E0E2";
}
