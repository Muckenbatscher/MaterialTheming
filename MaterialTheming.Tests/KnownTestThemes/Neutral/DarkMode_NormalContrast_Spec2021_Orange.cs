using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class DarkMode_NormalContrast_Spec2021_Orange : ITestTheme
{
    public string SourceColor => "#D77837"; //Orange
    public bool IsDark => true;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#DEC1B1";
    public string OnPrimary => "#3F2C21";
    public string PrimaryContainer => "#574236";
    public string OnPrimaryContainer => "#FBDCCC";

    public string Secondary => "#D7C2B8";
    public string OnSecondary => "#3A2E27";
    public string SecondaryContainer => "#52443C";
    public string OnSecondaryContainer => "#F4DED3";

    public string Tertiary => "#E5BFA9";
    public string OnTertiary => "#432B1C";
    public string TertiaryContainer => "#5C4131";
    public string OnTertiaryContainer => "#FFDBC8";

    public string Error => "#FFB4AB";
    public string OnError => "#690005";
    public string ErrorContainer => "#93000A";
    public string OnErrorContainer => "#FFDAD6";

    public string Surface => "#161311";
    public string OnSurface => "#E9E1DE";
    public string OnSurfaceVariant => "#CCC5C2";

    public string SurfaceContainerLowest => "#100E0C";
    public string SurfaceContainerLow => "#1E1B19";
    public string SurfaceContainer => "#221F1D";
    public string SurfaceContainerHigh => "#2D2928";
    public string SurfaceContainerHighest => "#383432";
}
