using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class LightMode_NormalContrast_Spec2021_Purple : ITestTheme
{
    public string SourceColor => "#945CCD"; //Purple
    public bool IsDark => false;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#6E528A";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#F0DBFF";
    public string OnPrimaryContainer => "#563B71";

    public string Secondary => "#665A6F";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#EDDDF6";
    public string OnSecondaryContainer => "#4D4357";

    public string Tertiary => "#805158";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#FFD9DD";
    public string OnTertiaryContainer => "#653A41";

    public string Error => "#BA1A1A";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#FFDAD6";
    public string OnErrorContainer => "#93000A";

    public string Surface => "#FFF7FE";
    public string OnSurface => "#1E1A20";
    public string OnSurfaceVariant => "#4A454E";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F9F1F9";
    public string SurfaceContainer => "#F3EBF3";
    public string SurfaceContainerHigh => "#EEE6EE";
    public string SurfaceContainerHighest => "#E8E0E8";
}
