using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class LightMode_NormalContrast_Spec2025_Magenta : ITestTheme
{
    public string SourceColor => "#E85DAE"; //Magenta
    public bool IsDark => false;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#844E6A";
    public string OnPrimary => "#FFF7F8";
    public string PrimaryContainer => "#FDB8D9";
    public string OnPrimaryContainer => "#65334E";

    public string Secondary => "#725864";
    public string OnSecondary => "#FFF7F8";
    public string SecondaryContainer => "#FDD9E8";
    public string OnSecondaryContainer => "#644A56";

    public string Tertiary => "#70557C";
    public string OnTertiary => "#FFF7FC";
    public string TertiaryContainer => "#F0CEFD";
    public string OnTertiaryContainer => "#5D4369";

    public string Error => "#A8364B";
    public string OnError => "#FFF7F7";
    public string ErrorContainer => "#F97386";
    public string OnErrorContainer => "#6E0523";

    public string Surface => "#FFF8F8";
    public string OnSurface => "#3B2F34";
    public string OnSurfaceVariant => "#6A5B61";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFF0F4";
    public string SurfaceContainer => "#FBEAEF";
    public string SurfaceContainerHigh => "#F6E4E9";
    public string SurfaceContainerHighest => "#F1DDE4";
}
