using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class LightMode_HighContrast_Spec2021_Purple : ITestTheme
{
    public string SourceColor => "#945CCD"; //Purple
    public bool IsDark => false;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#430077";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#6B00BA";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#3A2440";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#59415F";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#441E41";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#653A5F";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#600004";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#98000A";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#FFF7FE";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#000000";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F8EDFC";
    public string SurfaceContainer => "#EADFED";
    public string SurfaceContainerHigh => "#DBD1DF";
    public string SurfaceContainerHighest => "#CDC3D1";
}
