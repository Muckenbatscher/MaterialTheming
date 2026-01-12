using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class DarkMode_MediumContrast_Spec2021_Purple : ITestTheme
{
    public string SourceColor => "#945CCD"; //Purple
    public bool IsDark => true;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#E4D8EA";
    public string OnPrimary => "#2A2330";
    public string PrimaryContainer => "#978D9D";
    public string OnPrimaryContainer => "#000000";

    public string Secondary => "#E3D9E4";
    public string OnSecondary => "#29242C";
    public string SecondaryContainer => "#968E98";
    public string OnSecondaryContainer => "#000000";

    public string Tertiary => "#E6D7F0";
    public string OnTertiary => "#2B2234";
    public string TertiaryContainer => "#998CA3";
    public string OnTertiaryContainer => "#000000";

    public string Error => "#FFD2CC";
    public string OnError => "#540003";
    public string ErrorContainer => "#FF5449";
    public string OnErrorContainer => "#000000";

    public string Surface => "#141314";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#E0DBDD";

    public string SurfaceContainerLowest => "#080708";
    public string SurfaceContainerLow => "#1F1D1F";
    public string SurfaceContainer => "#292729";
    public string SurfaceContainerHigh => "#343234";
    public string SurfaceContainerHighest => "#3F3D3F";
}
