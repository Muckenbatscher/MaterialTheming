using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class LightMode_HighContrast_Spec2025_Magenta : ITestTheme
{
    public string SourceColor => "#E85DAE"; //Magenta
    public bool IsDark => false;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#4B0132";
    public string OnPrimary => "#FFCCE3";
    public string PrimaryContainer => "#853563";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#002927";
    public string OnSecondary => "#B3E3DE";
    public string SecondaryContainer => "#2C5A56";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#002924";
    public string OnTertiary => "#6BEFDC";
    public string TertiaryContainer => "#005D53";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#500016";
    public string OnError => "#FFCED2";
    public string ErrorContainer => "#9A243D";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#FFF8F8";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#3D162C";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFF0F4";
    public string SurfaceContainer => "#FFE8F0";
    public string SurfaceContainerHigh => "#FFE0EC";
    public string SurfaceContainerHighest => "#FFD8E8";
}
