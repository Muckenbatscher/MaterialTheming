using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.FruitSalad;

internal class LightMode_MediumContrast_Spec2021_Magenta : ITestTheme
{
    public string SourceColor => "#E85DAE"; //Magenta
    public bool IsDark => false;
    public Variant Variant => Variant.FruitSalad;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#3F2578";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#775EB4";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#3C2C63";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#75649E";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#592341";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#99597A";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#740006";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#CF2C27";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#FFF8F8";
    public string OnSurface => "#190E13";
    public string OnSurfaceVariant => "#472F3A";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFF0F4";
    public string SurfaceContainer => "#FAE2EB";
    public string SurfaceContainerHigh => "#EED7DF";
    public string SurfaceContainerHighest => "#E2CCD4";
}
