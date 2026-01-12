using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class LightMode_NormalContrast_Spec2025_Purple : ITestTheme
{
    public string SourceColor => "#945CCD"; //Purple
    public bool IsDark => false;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#625C65";
    public string OnPrimary => "#FEF5FF";
    public string PrimaryContainer => "#E9DFEB";
    public string OnPrimaryContainer => "#555059";

    public string Secondary => "#625E62";
    public string OnSecondary => "#FEF7FC";
    public string SecondaryContainer => "#E7E1E5";
    public string OnSecondaryContainer => "#545155";

    public string Tertiary => "#615B77";
    public string OnTertiary => "#FCF7FF";
    public string TertiaryContainer => "#E1D8FA";
    public string OnTertiaryContainer => "#504B66";

    public string Error => "#9E3F4E";
    public string OnError => "#FFF7F7";
    public string ErrorContainer => "#FF8B9A";
    public string OnErrorContainer => "#782232";

    public string Surface => "#FDF8F9";
    public string OnSurface => "#343234";
    public string OnSurfaceVariant => "#615E61";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F7F2F4";
    public string SurfaceContainer => "#F2ECEF";
    public string SurfaceContainerHigh => "#ECE7E9";
    public string SurfaceContainerHighest => "#E7E1E4";
}
