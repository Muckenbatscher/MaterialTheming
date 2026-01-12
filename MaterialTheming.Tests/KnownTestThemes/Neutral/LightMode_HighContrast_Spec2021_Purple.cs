using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class LightMode_HighContrast_Spec2021_Purple : ITestTheme
{
    public string SourceColor => "#945CCD"; //Purple
    public bool IsDark => false;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#302937";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#4E4654";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#2F2A33";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#4D4750";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#32283B";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#504559";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#600004";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#98000A";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#FDF8FA";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#000000";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F5EFF1";
    public string SurfaceContainer => "#E6E1E3";
    public string SurfaceContainerHigh => "#D8D3D5";
    public string SurfaceContainerHighest => "#CAC5C7";
}
