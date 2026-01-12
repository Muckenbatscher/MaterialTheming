using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.FruitSalad;

internal class DarkMode_NormalContrast_Spec2021_Magenta : ITestTheme
{
    public string SourceColor => "#E85DAE"; //Magenta
    public bool IsDark => true;
    public Variant Variant => Variant.FruitSalad;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#D0BCFF";
    public string OnPrimary => "#391E72";
    public string PrimaryContainer => "#50378A";
    public string OnPrimaryContainer => "#E9DDFF";

    public string Secondary => "#D0BCFE";
    public string OnSecondary => "#36265D";
    public string SecondaryContainer => "#4D3D75";
    public string OnSecondaryContainer => "#E9DDFF";

    public string Tertiary => "#FCB0D5";
    public string OnTertiary => "#521D3B";
    public string TertiaryContainer => "#6C3353";
    public string OnTertiaryContainer => "#FFD8E8";

    public string Error => "#FFB4AB";
    public string OnError => "#690005";
    public string ErrorContainer => "#93000A";
    public string OnErrorContainer => "#FFDAD6";

    public string Surface => "#1C1016";
    public string OnSurface => "#F4DDE5";
    public string OnSurfaceVariant => "#E0BDCC";

    public string SurfaceContainerLowest => "#160B10";
    public string SurfaceContainerLow => "#24181E";
    public string SurfaceContainer => "#291C22";
    public string SurfaceContainerHigh => "#34262C";
    public string SurfaceContainerHighest => "#3F3137";
}
