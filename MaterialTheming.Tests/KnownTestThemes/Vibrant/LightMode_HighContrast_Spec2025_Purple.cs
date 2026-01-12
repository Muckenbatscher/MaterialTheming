using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class LightMode_HighContrast_Spec2025_Purple : ITestTheme
{
    public string SourceColor => "#945CCD"; //Purple
    public bool IsDark => false;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#31005A";
    public string OnPrimary => "#E6CAFF";
    public string PrimaryContainer => "#7017BC";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#38004F";
    public string OnSecondary => "#F2C5FF";
    public string SecondaryContainer => "#72318F";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#470013";
    public string OnTertiary => "#FFC6CB";
    public string TertiaryContainer => "#8F293C";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#470013";
    public string OnError => "#FFC6CB";
    public string ErrorContainer => "#A00035";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#FFF3FD";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#2E1538";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FEEBFF";
    public string SurfaceContainer => "#FAE0FF";
    public string SurfaceContainerHigh => "#F8D8FF";
    public string SurfaceContainerHighest => "#F5D1FF";
}
