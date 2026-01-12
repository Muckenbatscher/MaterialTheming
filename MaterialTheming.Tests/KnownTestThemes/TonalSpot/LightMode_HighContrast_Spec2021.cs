using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class LightMode_HighContrast_Spec2021 : ITestTheme
{
    public string SourceColor => "#E85DAE"; //magenta
    public bool IsDark => false;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#4D1937";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#6F3655";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#3C2630";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#5B424E";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#45240D";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#674027";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#600004";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#98000A";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#FFF8F8";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#000000";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FCEDF1";
    public string SurfaceContainer => "#EEDFE3";
    public string SurfaceContainerHigh => "#DFD1D5";
    public string SurfaceContainerHighest => "#D1C3C7";
}
