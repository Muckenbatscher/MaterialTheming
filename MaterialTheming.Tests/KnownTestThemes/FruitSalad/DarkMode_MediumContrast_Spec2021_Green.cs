using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.FruitSalad;

internal class DarkMode_MediumContrast_Spec2021_Green : ITestTheme
{
    public string SourceColor => "#338745"; //Green
    public bool IsDark => true;
    public Variant Variant => Variant.FruitSalad;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#F5DC60";
    public string OnPrimary => "#2C2500";
    public string PrimaryContainer => "#A59016";
    public string OnPrimaryContainer => "#000000";

    public string Secondary => "#F0DD83";
    public string OnSecondary => "#2C2500";
    public string SecondaryContainer => "#A19140";
    public string OnSecondaryContainer => "#000000";

    public string Tertiary => "#B2EAB3";
    public string OnTertiary => "#002D0D";
    public string TertiaryContainer => "#689D6C";
    public string OnTertiaryContainer => "#000000";

    public string Error => "#FFD2CC";
    public string OnError => "#540003";
    public string ErrorContainer => "#FF5449";
    public string OnErrorContainer => "#000000";

    public string Surface => "#0D150D";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#CEE2CB";

    public string SurfaceContainerLowest => "#030903";
    public string SurfaceContainerLow => "#172017";
    public string SurfaceContainer => "#212A21";
    public string SurfaceContainerHigh => "#2C352B";
    public string SurfaceContainerHighest => "#374036";
}
