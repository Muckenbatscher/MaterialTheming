using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class DarkMode_NormalContrast_Spec2021_Cyan : ITestTheme
{
    public string SourceColor => "#00BCD1"; //Cyan
    public bool IsDark => true;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#E7C361";
    public string OnPrimary => "#3D2E00";
    public string PrimaryContainer => "#584400";
    public string OnPrimaryContainer => "#FFDF90";

    public string Secondary => "#CEC0E8";
    public string OnSecondary => "#352B4B";
    public string SecondaryContainer => "#4C4163";
    public string OnSecondaryContainer => "#EADDFF";

    public string Tertiary => "#93CFE8";
    public string OnTertiary => "#003544";
    public string TertiaryContainer => "#004D62";
    public string OnTertiaryContainer => "#BAEAFF";

    public string Error => "#FFB4AB";
    public string OnError => "#690005";
    public string ErrorContainer => "#93000A";
    public string OnErrorContainer => "#FFDAD6";

    public string Surface => "#0D1418";
    public string OnSurface => "#DCE4E8";
    public string OnSurfaceVariant => "#BAC9D0";

    public string SurfaceContainerLowest => "#080F13";
    public string SurfaceContainerLow => "#151D20";
    public string SurfaceContainer => "#192124";
    public string SurfaceContainerHigh => "#232B2F";
    public string SurfaceContainerHighest => "#2E363A";
}
