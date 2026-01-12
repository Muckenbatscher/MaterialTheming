using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.FruitSalad;

internal class LightMode_MediumContrast_Spec2021_Green : ITestTheme
{
    public string SourceColor => "#338745"; //Green
    public bool IsDark => false;
    public Variant Variant => Variant.FruitSalad;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#3F3600";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#7D6D00";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#3F3600";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#7B6D1F";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#083F18";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#45784B";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#740006";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#CF2C27";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#F2FCEE";
    public string OnSurface => "#0B130B";
    public string OnSurfaceVariant => "#2A3A2A";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#ECF7E8";
    public string SurfaceContainer => "#E1EBDD";
    public string SurfaceContainerHigh => "#D6E0D2";
    public string SurfaceContainerHighest => "#CAD5C7";
}
