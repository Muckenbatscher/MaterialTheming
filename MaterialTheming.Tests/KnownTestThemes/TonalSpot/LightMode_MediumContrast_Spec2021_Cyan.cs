using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class LightMode_MediumContrast_Spec2021_Cyan : ITestTheme
{
    public string SourceColor => "#00BCD1"; //Cyan
    public bool IsDark => false;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#003C44";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#197885";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#223A3E";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#597176";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#2A3553";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#616C8D";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#740006";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#CF2C27";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#F5FAFC";
    public string OnSurface => "#0C1213";
    public string OnSurfaceVariant => "#2F3839";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#EFF5F6";
    public string SurfaceContainer => "#E3E9EA";
    public string SurfaceContainerHigh => "#D8DEDF";
    public string SurfaceContainerHighest => "#CDD3D4";
}
