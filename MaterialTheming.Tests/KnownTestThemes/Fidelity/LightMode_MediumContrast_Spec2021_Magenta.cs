using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Fidelity;

internal class LightMode_MediumContrast_Spec2021_Magenta : ITestTheme
{
    public string SourceColor => "#E85DAE"; //Magenta
    public bool IsDark => false;
    public Variant Variant => Variant.Fidelity;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#6C004A";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#BC3889";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#5A2142";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#9B587B";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#183F00";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#367C00";
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
