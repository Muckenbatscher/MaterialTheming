using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class LightMode_MediumContrast_Spec2021_Green : ITestTheme
{
    public string SourceColor => "#338745"; //Green
    public bool IsDark => false;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#083F18";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#45784B";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#2A3A2A";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#60725F";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#083C43";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#48747B";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#740006";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#CF2C27";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#F7FBF2";
    public string OnSurface => "#0E120E";
    public string OnSurfaceVariant => "#313830";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F1F5EC";
    public string SurfaceContainer => "#E5E9E1";
    public string SurfaceContainerHigh => "#DADED6";
    public string SurfaceContainerHighest => "#CFD3CB";
}
