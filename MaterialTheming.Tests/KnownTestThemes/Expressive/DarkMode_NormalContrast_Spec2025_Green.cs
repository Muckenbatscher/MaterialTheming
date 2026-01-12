using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class DarkMode_NormalContrast_Spec2025_Green : ITestTheme
{
    public string SourceColor => "#338745"; //Green
    public bool IsDark => true;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#C6FFC7";
    public string OnPrimary => "#326539";
    public string PrimaryContainer => "#B8F1B9";
    public string OnPrimaryContainer => "#295C32";

    public string Secondary => "#E5BFAA";
    public string OnSecondary => "#543A2B";
    public string SecondaryContainer => "#372013";
    public string OnSecondaryContainer => "#C09C89";

    public string Tertiary => "#FFB692";
    public string OnTertiary => "#6F2B00";
    public string TertiaryContainer => "#FFA273";
    public string OnTertiaryContainer => "#602400";

    public string Error => "#FE7453";
    public string OnError => "#450900";
    public string ErrorContainer => "#881F05";
    public string OnErrorContainer => "#FF9B82";

    public string Surface => "#031108";
    public string OnSurface => "#CAEED4";
    public string OnSurfaceVariant => "#90B39B";

    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#04170C";
    public string SurfaceContainer => "#061E11";
    public string SurfaceContainerHigh => "#082516";
    public string SurfaceContainerHighest => "#0B2C1A";
}
