using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class LightMode_MediumContrast_Spec2021_Magenta : ITestTheme
{
    public string SourceColor => "#E85DAE"; //Magenta
    public bool IsDark => false;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#6C004A";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#CF0092";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#512A36";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#8F606C";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#5A252A";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#9C5B5F";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#740006";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#CF2C27";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#FFF8F8";
    public string OnSurface => "#190E13";
    public string OnSurfaceVariant => "#433139";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFF0F4";
    public string SurfaceContainer => "#FAE2EB";
    public string SurfaceContainerHigh => "#EED7DF";
    public string SurfaceContainerHighest => "#E2CCD4";
}
