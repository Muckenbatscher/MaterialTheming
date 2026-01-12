using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class DarkMode_MediumContrast_Spec2025_Green : ITestTheme
{
    public string SourceColor => "#338745"; //Green
    public bool IsDark => true;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#C6FFC7";
    public string OnPrimary => "#285A30";
    public string PrimaryContainer => "#B8F1B9";
    public string OnPrimaryContainer => "#1F5229";

    public string Secondary => "#E5BFAA";
    public string OnSecondary => "#493122";
    public string SecondaryContainer => "#8E6E5C";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#FFB692";
    public string OnTertiary => "#5F2400";
    public string TertiaryContainer => "#FFA273";
    public string OnTertiaryContainer => "#4F1D00";

    public string Error => "#FFA089";
    public string OnError => "#5A0E00";
    public string ErrorContainer => "#C74C2F";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#031108";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#9EC1A8";

    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#04170C";
    public string SurfaceContainer => "#061E11";
    public string SurfaceContainerHigh => "#082516";
    public string SurfaceContainerHighest => "#0B2C1A";
}
