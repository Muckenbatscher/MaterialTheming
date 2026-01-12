using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class DarkMode_MediumContrast_Spec2021_Purple : ITestTheme
{
    public string SourceColor => "#945CCD"; //Purple
    public bool IsDark => true;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#8AEDE4";
    public string OnPrimary => "#002B28";
    public string PrimaryContainer => "#36A098";
    public string OnPrimaryContainer => "#000000";

    public string Secondary => "#FFD0E0";
    public string OnSecondary => "#3C1B29";
    public string SecondaryContainer => "#B48395";
    public string OnSecondaryContainer => "#000000";

    public string Tertiary => "#FFCDFB";
    public string OnTertiary => "#3B183D";
    public string TertiaryContainer => "#B082AE";
    public string OnTertiaryContainer => "#000000";

    public string Error => "#FFD2CC";
    public string OnError => "#540003";
    public string ErrorContainer => "#FF5449";
    public string OnErrorContainer => "#000000";

    public string Surface => "#181118";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#E9D7E7";

    public string SurfaceContainerLowest => "#0B060C";
    public string SurfaceContainerLow => "#221B22";
    public string SurfaceContainer => "#2D262D";
    public string SurfaceContainerHigh => "#383038";
    public string SurfaceContainerHighest => "#433B43";
}
