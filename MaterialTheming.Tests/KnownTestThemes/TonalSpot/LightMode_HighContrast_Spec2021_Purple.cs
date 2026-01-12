using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class LightMode_HighContrast_Spec2021_Purple : ITestTheme
{
    public string SourceColor => "#945CCD"; //Purple
    public bool IsDark => false;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#3A1F54";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#583D73";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#32283B";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#504559";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#462127";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#683D43";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#600004";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#98000A";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#FFF7FE";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#000000";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F6EEF6";
    public string SurfaceContainer => "#E8E0E8";
    public string SurfaceContainerHigh => "#DAD2DA";
    public string SurfaceContainerHighest => "#CBC4CC";
}
