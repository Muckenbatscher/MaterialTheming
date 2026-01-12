using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class DarkMode_NormalContrast_Spec2021_Magenta : ITestTheme
{
    public string SourceColor => "#E85DAE"; //Magenta
    public bool IsDark => true;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#81D1F6";
    public string OnPrimary => "#003547";
    public string PrimaryContainer => "#004D65";
    public string OnPrimaryContainer => "#BFE9FF";

    public string Secondary => "#F5B8A7";
    public string OnSecondary => "#4C261A";
    public string SecondaryContainer => "#663C2F";
    public string OnSecondaryContainer => "#FFDBD1";

    public string Tertiary => "#CCCA7F";
    public string OnTertiary => "#333200";
    public string TertiaryContainer => "#4A490A";
    public string OnTertiaryContainer => "#E9E698";

    public string Error => "#FFB4AB";
    public string OnError => "#690005";
    public string ErrorContainer => "#93000A";
    public string OnErrorContainer => "#FFDAD6";

    public string Surface => "#1B1013";
    public string OnSurface => "#F3DDE0";
    public string OnSurfaceVariant => "#DDBFC4";

    public string SurfaceContainerLowest => "#160B0E";
    public string SurfaceContainerLow => "#24191B";
    public string SurfaceContainer => "#281C1F";
    public string SurfaceContainerHigh => "#332729";
    public string SurfaceContainerHighest => "#3F3134";
}
