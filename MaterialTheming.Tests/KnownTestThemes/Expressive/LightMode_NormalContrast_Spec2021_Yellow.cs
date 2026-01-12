using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class LightMode_NormalContrast_Spec2021_Yellow : ITestTheme
{
    public string SourceColor => "#B2B037"; //Yellow
    public bool IsDark => false;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#8C486C";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#FFD8E8";
    public string OnPrimaryContainer => "#703054";

    public string Secondary => "#45664C";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#C6ECCC";
    public string OnSecondaryContainer => "#2D4E36";

    public string Tertiary => "#506530";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#D2ECA9";
    public string OnTertiaryContainer => "#394D1B";

    public string Error => "#BA1A1A";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#FFDAD6";
    public string OnErrorContainer => "#93000A";

    public string Surface => "#FAFBEA";
    public string OnSurface => "#1A1D13";
    public string OnSurfaceVariant => "#444937";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F4F5E4";
    public string SurfaceContainer => "#EEEFDF";
    public string SurfaceContainerHigh => "#E8E9D9";
    public string SurfaceContainerHighest => "#E2E4D4";
}
