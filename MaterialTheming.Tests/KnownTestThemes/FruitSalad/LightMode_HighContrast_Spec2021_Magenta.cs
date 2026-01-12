using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.FruitSalad;

internal class LightMode_HighContrast_Spec2021_Magenta : ITestTheme
{
    public string SourceColor => "#E85DAE"; //Magenta
    public bool IsDark => false;
    public Variant Variant => Variant.FruitSalad;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#34186D";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#52398C";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#322258";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#504078";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#4D1937";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#6F3655";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#600004";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#98000A";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#FFF8F8";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#000000";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFECF2";
    public string SurfaceContainer => "#F4DDE5";
    public string SurfaceContainerHigh => "#E5CFD7";
    public string SurfaceContainerHighest => "#D7C1C9";
}
