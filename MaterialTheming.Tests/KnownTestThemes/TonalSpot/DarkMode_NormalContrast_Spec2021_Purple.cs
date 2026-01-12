using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class DarkMode_NormalContrast_Spec2021_Purple : ITestTheme
{
    public string SourceColor => "#945CCD"; //Purple
    public bool IsDark => true;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#DBB9F9";
    public string OnPrimary => "#3E2459";
    public string PrimaryContainer => "#563B71";
    public string OnPrimaryContainer => "#F0DBFF";

    public string Secondary => "#D0C1DA";
    public string OnSecondary => "#362C3F";
    public string SecondaryContainer => "#4D4357";
    public string OnSecondaryContainer => "#EDDDF6";

    public string Tertiary => "#F3B7BE";
    public string OnTertiary => "#4B252B";
    public string TertiaryContainer => "#653A41";
    public string OnTertiaryContainer => "#FFD9DD";

    public string Error => "#FFB4AB";
    public string OnError => "#690005";
    public string ErrorContainer => "#93000A";
    public string OnErrorContainer => "#FFDAD6";

    public string Surface => "#151218";
    public string OnSurface => "#E8E0E8";
    public string OnSurfaceVariant => "#CCC4CE";

    public string SurfaceContainerLowest => "#100D12";
    public string SurfaceContainerLow => "#1E1A20";
    public string SurfaceContainer => "#221E24";
    public string SurfaceContainerHigh => "#2C292E";
    public string SurfaceContainerHighest => "#373339";
}
