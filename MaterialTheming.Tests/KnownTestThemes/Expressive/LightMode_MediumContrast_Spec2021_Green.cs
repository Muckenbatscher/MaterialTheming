using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class LightMode_MediumContrast_Spec2021_Green : ITestTheme
{
    public string SourceColor => "#338745"; //Green
    public bool IsDark => false;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#612115";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#A65646";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#133D2F";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#4C7564";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#003D3C";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#2E7876";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#740006";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#CF2C27";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#F3FCF3";
    public string OnSurface => "#0B130E";
    public string OnSurfaceVariant => "#2B3931";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#EDF6EE";
    public string SurfaceContainer => "#E1EBE2";
    public string SurfaceContainerHigh => "#D6DFD7";
    public string SurfaceContainerHighest => "#CBD4CC";
}
