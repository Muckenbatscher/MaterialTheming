using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.FruitSalad;

internal class LightMode_MediumContrast_Spec2025_Yellow : ITestTheme
{
    public string SourceColor => "#B2B037"; //Yellow
    public bool IsDark => false;
    public Variant Variant => Variant.FruitSalad;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#542C00";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#A35B03";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#542C00";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#996029";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#393800";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#717025";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#740006";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#CF2C27";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#FEFAE3";
    public string OnSurface => "#121205";
    public string OnSurfaceVariant => "#38371D";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F8F4DD";
    public string SurfaceContainer => "#ECE9D2";
    public string SurfaceContainerHigh => "#E1DEC7";
    public string SurfaceContainerHighest => "#D5D2BC";
}
