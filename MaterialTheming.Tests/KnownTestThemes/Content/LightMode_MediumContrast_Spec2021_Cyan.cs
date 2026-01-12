using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Content;

internal class LightMode_MediumContrast_Spec2021_Cyan : ITestTheme
{
    public string SourceColor => "#00BCD1"; //Cyan
    public bool IsDark => false;
    public Variant Variant => Variant.Content;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#003C44";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#007886";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#043C44";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#46747C";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#501C6E";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#8C57AA";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#740006";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#CF2C27";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#F4FAFC";
    public string OnSurface => "#0C1213";
    public string OnSurfaceVariant => "#2C383B";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#EFF5F6";
    public string SurfaceContainer => "#E3E9EB";
    public string SurfaceContainerHigh => "#D8DEDF";
    public string SurfaceContainerHighest => "#CCD3D4";
}
