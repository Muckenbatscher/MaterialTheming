using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class LightMode_MediumContrast_Spec2025 : ITestTheme
{
    public string SourceColor => "#E85DAE"; //magenta
    public bool IsDark => false;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#7D0056";
    public string OnPrimary => "#FFC3DF";
    public string PrimaryContainer => "#C93A92";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#6D1A68";
    public string OnSecondary => "#FFC1F1";
    public string SecondaryContainer => "#AC53A2";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#1D349A";
    public string OnTertiary => "#CBD1FF";
    public string TertiaryContainer => "#586CD3";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#83002A";
    public string OnError => "#FFC6CA";
    public string ErrorContainer => "#D73357";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#FFF3F8";
    public string OnSurface => "#331330";
    public string OnSurfaceVariant => "#573351";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFEBF7";
    public string SurfaceContainer => "#FFDFF5";
    public string SurfaceContainerHigh => "#FFD7F4";
    public string SurfaceContainerHighest => "#FFCEF3";
}
