using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class DarkMode_NormalContrast_Spec2021_Yellow : ITestTheme
{
    public string SourceColor => "#B2B037"; //Yellow
    public bool IsDark => true;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#CFCC00";
    public string OnPrimary => "#333200";
    public string PrimaryContainer => "#4A4900";
    public string OnPrimaryContainer => "#ECE900";

    public string Secondary => "#C2CC99";
    public string OnSecondary => "#2C340F";
    public string SecondaryContainer => "#424A23";
    public string OnSecondaryContainer => "#DEE8B3";

    public string Tertiary => "#B1D094";
    public string OnTertiary => "#1E370A";
    public string TertiaryContainer => "#344E1F";
    public string OnTertiaryContainer => "#CCEDAE";

    public string Error => "#FFB4AB";
    public string OnError => "#690005";
    public string ErrorContainer => "#93000A";
    public string OnErrorContainer => "#FFDAD6";

    public string Surface => "#141407";
    public string OnSurface => "#E6E3CD";
    public string OnSurfaceVariant => "#CAC7AD";

    public string SurfaceContainerLowest => "#0F0F04";
    public string SurfaceContainerLow => "#1D1C0E";
    public string SurfaceContainer => "#212012";
    public string SurfaceContainerHigh => "#2B2B1C";
    public string SurfaceContainerHighest => "#363526";
}
