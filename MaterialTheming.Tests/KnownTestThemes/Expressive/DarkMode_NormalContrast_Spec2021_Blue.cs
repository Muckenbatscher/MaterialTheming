using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class DarkMode_NormalContrast_Spec2021_Blue : ITestTheme
{
    public string SourceColor => "#185FAA"; //Blue
    public bool IsDark => true;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#A3D48D";
    public string OnPrimary => "#103903";
    public string PrimaryContainer => "#275018";
    public string OnPrimaryContainer => "#BFF0A6";

    public string Secondary => "#EBB8CF";
    public string OnSecondary => "#482537";
    public string SecondaryContainer => "#613B4E";
    public string OnSecondaryContainer => "#FFD8E8";

    public string Tertiary => "#B8C4FA";
    public string OnTertiary => "#212E5A";
    public string TertiaryContainer => "#384472";
    public string OnTertiaryContainer => "#DCE1FF";

    public string Error => "#FFB4AB";
    public string OnError => "#690005";
    public string ErrorContainer => "#93000A";
    public string OnErrorContainer => "#FFDAD6";

    public string Surface => "#11131A";
    public string OnSurface => "#E2E1EC";
    public string OnSurfaceVariant => "#C4C5D6";

    public string SurfaceContainerLowest => "#0C0E15";
    public string SurfaceContainerLow => "#1A1B23";
    public string SurfaceContainer => "#1E1F27";
    public string SurfaceContainerHigh => "#282A31";
    public string SurfaceContainerHighest => "#33343C";
}
