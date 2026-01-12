using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class DarkMode_MediumContrast_Spec2025_Yellow : ITestTheme
{
    public string SourceColor => "#B2B037"; //Yellow
    public bool IsDark => true;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#FFFCC6";
    public string OnPrimary => "#595800";
    public string PrimaryContainer => "#F5F200";
    public string OnPrimaryContainer => "#514F00";

    public string Secondary => "#FCD83F";
    public string OnSecondary => "#504200";
    public string SecondaryContainer => "#8A7300";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#FFCE5D";
    public string OnTertiary => "#523C00";
    public string TertiaryContainer => "#F7BE26";
    public string OnTertiaryContainer => "#473300";

    public string Error => "#FFA089";
    public string OnError => "#5A0E00";
    public string ErrorContainer => "#D53D18";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#130E00";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#CBB876";

    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#191300";
    public string SurfaceContainer => "#201900";
    public string SurfaceContainerHigh => "#271F00";
    public string SurfaceContainerHighest => "#2E2500";
}
