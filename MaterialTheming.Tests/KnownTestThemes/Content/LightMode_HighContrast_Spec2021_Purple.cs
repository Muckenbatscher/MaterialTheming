using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Content;

internal class LightMode_HighContrast_Spec2021_Purple : ITestTheme
{
    public string SourceColor => "#945CCD"; //Purple
    public bool IsDark => false;
    public Variant Variant => Variant.Content;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#430077";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#632A9B";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#37234C";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#55406B";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#5B0038";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#861D58";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#600004";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#98000A";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#FFF7FE";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#000000";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F7EEF8";
    public string SurfaceContainer => "#E9E0EA";
    public string SurfaceContainerHigh => "#DAD2DC";
    public string SurfaceContainerHighest => "#CCC4CE";
}
