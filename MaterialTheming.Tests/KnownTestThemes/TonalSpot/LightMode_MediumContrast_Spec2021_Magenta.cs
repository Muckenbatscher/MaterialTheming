using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class LightMode_MediumContrast_Spec2021_Magenta : ITestTheme
{
    public string SourceColor => "#E85DAE"; //Magenta
    public bool IsDark => false;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#592341";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#99597A";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#472F3A";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#816572";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#512D16";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#906348";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#740006";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#CF2C27";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#FFF8F8";
    public string OnSurface => "#160F12";
    public string OnSurfaceVariant => "#3F3338";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFF0F4";
    public string SurfaceContainer => "#F3E4E9";
    public string SurfaceContainerHigh => "#E8D9DD";
    public string SurfaceContainerHighest => "#DCCED2";
}
