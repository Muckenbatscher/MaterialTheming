using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class LightMode_MediumContrast_Spec2021_Green : ITestTheme
{
    public string SourceColor => "#338745"; //Green
    public bool IsDark => false;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#004016";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#007E33";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#163D2C";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#4F7561";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#003E34";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#33786A";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#740006";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#CF2C27";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#F2FCEE";
    public string OnSurface => "#0B130B";
    public string OnSurfaceVariant => "#2D392D";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#ECF7E8";
    public string SurfaceContainer => "#E1EBDD";
    public string SurfaceContainerHigh => "#D6E0D2";
    public string SurfaceContainerHighest => "#CAD5C7";
}
