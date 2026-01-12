using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class DarkMode_NormalContrast_Spec2021_Green : ITestTheme
{
    public string SourceColor => "#338745"; //Green
    public bool IsDark => true;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#FFB4A5";
    public string OnPrimary => "#591C10";
    public string PrimaryContainer => "#763224";
    public string OnPrimaryContainer => "#FFDAD3";

    public string Secondary => "#A4D0BC";
    public string OnSecondary => "#0C3729";
    public string SecondaryContainer => "#264E3F";
    public string OnSecondaryContainer => "#C0ECD7";

    public string Tertiary => "#8CD3D1";
    public string OnTertiary => "#003736";
    public string TertiaryContainer => "#00504E";
    public string OnTertiaryContainer => "#A8EFED";

    public string Error => "#FFB4AB";
    public string OnError => "#690005";
    public string ErrorContainer => "#93000A";
    public string OnErrorContainer => "#FFDAD6";

    public string Surface => "#0D1511";
    public string OnSurface => "#DCE5DD";
    public string OnSurfaceVariant => "#BACBBF";

    public string SurfaceContainerLowest => "#08100C";
    public string SurfaceContainerLow => "#151D19";
    public string SurfaceContainer => "#19211D";
    public string SurfaceContainerHigh => "#232C27";
    public string SurfaceContainerHighest => "#2E3731";
}
