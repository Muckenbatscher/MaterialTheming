using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Content;

internal class LightMode_MediumContrast_Spec2025_Magenta : ITestTheme
{
    public string SourceColor => "#E85DAE"; //Magenta
    public bool IsDark => false;
    public Variant Variant => Variant.Content;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#6C004A";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#BC3889";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#5A2142";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#9B587B";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#6F0D00";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#C33F26";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#740006";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#CF2C27";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#FFF8F8";
    public string OnSurface => "#180E13";
    public string OnSurfaceVariant => "#433139";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFF0F4";
    public string SurfaceContainer => "#F8E3EA";
    public string SurfaceContainerHigh => "#ECD8DF";
    public string SurfaceContainerHighest => "#E0CDD3";
}
