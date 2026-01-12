using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class LightMode_MediumContrast_Spec2021_Cyan : ITestTheme
{
    public string SourceColor => "#00BCD1"; //Cyan
    public bool IsDark => false;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#003C44";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#007886";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#113B4A";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#4D7283";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#00395A";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#467194";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#740006";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#CF2C27";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#EEFCFF";
    public string OnSurface => "#071315";
    public string OnSurfaceVariant => "#29393C";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#E9F6F9";
    public string SurfaceContainer => "#DDEBED";
    public string SurfaceContainerHigh => "#D2DFE2";
    public string SurfaceContainerHighest => "#C7D4D7";
}
