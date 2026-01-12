using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Fidelity;

internal class LightMode_MediumContrast_Spec2021_Orange : ITestTheme
{
    public string SourceColor => "#D77837"; //Orange
    public bool IsDark => false;
    public Variant Variant => Variant.Fidelity;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#5B2700";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#AB5616";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#522D15";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#916246";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#003C4A";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#007791";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#740006";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#CF2C27";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#FFF8F5";
    public string OnSurface => "#170F0B";
    public string OnSurfaceVariant => "#433329";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFF1EA";
    public string SurfaceContainer => "#F6E5DC";
    public string SurfaceContainerHigh => "#EBD9D1";
    public string SurfaceContainerHighest => "#DFCEC6";
}
