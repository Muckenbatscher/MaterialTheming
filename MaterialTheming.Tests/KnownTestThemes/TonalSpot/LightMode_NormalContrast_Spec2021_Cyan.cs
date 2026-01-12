using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class LightMode_NormalContrast_Spec2021_Cyan : ITestTheme
{
    public string SourceColor => "#00BCD1"; //Cyan
    public bool IsDark => false;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#006875";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#9EEFFE";
    public string OnPrimaryContainer => "#004F58";

    public string Secondary => "#4A6267";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#CDE7EC";
    public string OnSecondaryContainer => "#334B4F";

    public string Tertiary => "#535E7E";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#DAE2FF";
    public string OnTertiaryContainer => "#3B4665";

    public string Error => "#BA1A1A";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#FFDAD6";
    public string OnErrorContainer => "#93000A";

    public string Surface => "#F5FAFC";
    public string OnSurface => "#171D1E";
    public string OnSurfaceVariant => "#3F484A";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#EFF5F6";
    public string SurfaceContainer => "#E9EFF0";
    public string SurfaceContainerHigh => "#E3E9EA";
    public string SurfaceContainerHighest => "#DEE3E5";
}
