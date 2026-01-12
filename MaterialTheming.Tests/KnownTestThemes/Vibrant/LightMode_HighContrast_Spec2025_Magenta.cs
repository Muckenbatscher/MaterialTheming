using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class LightMode_HighContrast_Spec2025_Magenta : ITestTheme
{
    public string SourceColor => "#E85DAE"; //Magenta
    public bool IsDark => false;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#43002D";
    public string OnPrimary => "#FFC4DF";
    public string PrimaryContainer => "#97036A";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#3F003D";
    public string OnSecondary => "#FFC2F1";
    public string SecondaryContainer => "#802C79";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#001463";
    public string OnTertiary => "#CCD2FF";
    public string TertiaryContainer => "#3045AA";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#470013";
    public string OnError => "#FFC6CB";
    public string ErrorContainer => "#A00035";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#FFF3F8";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#331330";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFEBF7";
    public string SurfaceContainer => "#FFDFF5";
    public string SurfaceContainerHigh => "#FFD7F4";
    public string SurfaceContainerHighest => "#FFCEF3";
}
