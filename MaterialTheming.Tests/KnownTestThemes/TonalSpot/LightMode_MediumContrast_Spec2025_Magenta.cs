using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class LightMode_MediumContrast_Spec2025_Magenta : ITestTheme
{
    public string SourceColor => "#E85DAE"; //Magenta
    public bool IsDark => false;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#64324D";
    public string OnPrimary => "#FFCCE2";
    public string PrimaryContainer => "#9C6380";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#543C47";
    public string OnSecondary => "#F4D0DF";
    public string SecondaryContainer => "#896D79";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#52395E";
    public string OnTertiary => "#F0CEFC";
    public string TertiaryContainer => "#876A93";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#821830";
    public string OnError => "#FFCDD1";
    public string ErrorContainer => "#C44B5F";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#FFF8F8";
    public string OnSurface => "#2C2126";
    public string OnSurfaceVariant => "#4C3F45";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFF0F4";
    public string SurfaceContainer => "#FBEAEF";
    public string SurfaceContainerHigh => "#F6E4E9";
    public string SurfaceContainerHighest => "#F1DDE4";
}
