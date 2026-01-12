using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.FruitSalad;

internal class DarkMode_MediumContrast_Spec2021_Yellow : ITestTheme
{
    public string SourceColor => "#B2B037"; //Yellow
    public bool IsDark => true;
    public Variant Variant => Variant.FruitSalad;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#FFD4B2";
    public string OnPrimary => "#3C1E00";
    public string PrimaryContainer => "#CF7D2B";
    public string OnPrimaryContainer => "#000000";

    public string Secondary => "#FFD4B2";
    public string OnSecondary => "#3C1E00";
    public string SecondaryContainer => "#C28349";
    public string OnSecondaryContainer => "#000000";

    public string Tertiary => "#E3E089";
    public string OnTertiary => "#282700";
    public string TertiaryContainer => "#969445";
    public string OnTertiaryContainer => "#000000";

    public string Error => "#FFD2CC";
    public string OnError => "#540003";
    public string ErrorContainer => "#FF5449";
    public string OnErrorContainer => "#000000";

    public string Surface => "#141407";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#E1DEB9";

    public string SurfaceContainerLowest => "#080801";
    public string SurfaceContainerLow => "#1F1E10";
    public string SurfaceContainer => "#29291A";
    public string SurfaceContainerHigh => "#343324";
    public string SurfaceContainerHighest => "#3F3E2E";
}
