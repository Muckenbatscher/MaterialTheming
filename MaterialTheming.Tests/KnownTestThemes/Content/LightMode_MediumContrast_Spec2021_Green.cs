using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Content;

internal class LightMode_MediumContrast_Spec2021_Green : ITestTheme
{
    public string SourceColor => "#338745"; //Green
    public bool IsDark => false;
    public Variant Variant => Variant.Content;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#004016";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#277C3C";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#1F3D22";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#557556";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#003861";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#1970B7";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#740006";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#CF2C27";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#F6FBF2";
    public string OnSurface => "#0E120D";
    public string OnSurfaceVariant => "#2F392E";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F1F5EC";
    public string SurfaceContainer => "#E5EAE1";
    public string SurfaceContainerHigh => "#DADED5";
    public string SurfaceContainerHighest => "#CED3CA";
}
