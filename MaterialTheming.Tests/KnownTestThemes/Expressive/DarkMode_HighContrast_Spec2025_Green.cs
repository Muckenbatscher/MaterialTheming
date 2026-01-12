using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class DarkMode_HighContrast_Spec2025_Green : ITestTheme
{
    public string SourceColor => "#338745"; //Green
    public bool IsDark => true;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#C6FFC7";
    public string OnPrimary => "#043C16";
    public string PrimaryContainer => "#B8F1B9";
    public string OnPrimaryContainer => "#00320F";

    public string Secondary => "#FFDFCE";
    public string OnSecondary => "#3E2718";
    public string SecondaryContainer => "#C09C88";
    public string OnSecondaryContainer => "#000000";

    public string Tertiary => "#FFDFD1";
    public string OnTertiary => "#4F1D00";
    public string TertiaryContainer => "#FFA273";
    public string OnTertiaryContainer => "#000000";

    public string Error => "#FFDED7";
    public string OnError => "#5A0E00";
    public string ErrorContainer => "#FF7E5E";
    public string OnErrorContainer => "#000000";

    public string Surface => "#031108";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#CAEED4";

    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#04170C";
    public string SurfaceContainer => "#061E11";
    public string SurfaceContainerHigh => "#082516";
    public string SurfaceContainerHighest => "#0B2C1A";
}
