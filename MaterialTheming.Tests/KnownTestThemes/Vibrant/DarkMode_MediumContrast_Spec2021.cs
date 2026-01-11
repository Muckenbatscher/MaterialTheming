using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class DarkMode_MediumContrast_Spec2021 : ITestTheme
{
    public string SourceColor => "#B2B037"; //yellow
    public bool IsDark => true;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#E6E300";
    public string OnPrimary => "#282700";
    public string PrimaryContainer => "#979500";
    public string OnPrimaryContainer => "#000000";

    public string Secondary => "#D7E2AD";
    public string OnSecondary => "#212905";
    public string SecondaryContainer => "#8C9567";
    public string OnSecondaryContainer => "#000000";

    public string Tertiary => "#C6E6A8";
    public string OnTertiary => "#142B02";
    public string TertiaryContainer => "#7C9963";
    public string OnTertiaryContainer => "#000000";

    public string Error => "#FFD2CC";
    public string OnError => "#540003";
    public string ErrorContainer => "#FF5449";
    public string OnErrorContainer => "#000000";

    public string Surface => "#141407";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#E0DDC2";

    public string SurfaceContainerLowest => "#080801";
    public string SurfaceContainerLow => "#1F1E10";
    public string SurfaceContainer => "#29291A";
    public string SurfaceContainerHigh => "#343324";
    public string SurfaceContainerHighest => "#3F3E2E";
}
