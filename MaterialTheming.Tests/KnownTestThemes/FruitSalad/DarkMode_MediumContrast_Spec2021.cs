using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.FruitSalad;

internal class DarkMode_MediumContrast_Spec2021 : ITestTheme
{
    public string SourceColor => "#D2463D"; //red
    public bool IsDark => true;
    public Variant Variant => Variant.FruitSalad;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#FFCDF4";
    public string OnPrimary => "#480447";
    public string PrimaryContainer => "#C376BA";
    public string OnPrimaryContainer => "#000000";

    public string Secondary => "#FFCDF4";
    public string OnSecondary => "#3F143D";
    public string SecondaryContainer => "#B77EAE";
    public string OnSecondaryContainer => "#000000";

    public string Tertiary => "#FFD2CD";
    public string OnTertiary => "#481310";
    public string TertiaryContainer => "#CC7B72";
    public string OnTertiaryContainer => "#000000";

    public string Error => "#FFD2CC";
    public string OnError => "#540003";
    public string ErrorContainer => "#FF5449";
    public string OnErrorContainer => "#000000";

    public string Surface => "#1E100E";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#FED2CD";

    public string SurfaceContainerLowest => "#100504";
    public string SurfaceContainerLow => "#291A18";
    public string SurfaceContainer => "#342422";
    public string SurfaceContainerHigh => "#402E2C";
    public string SurfaceContainerHighest => "#4C3937";
}
