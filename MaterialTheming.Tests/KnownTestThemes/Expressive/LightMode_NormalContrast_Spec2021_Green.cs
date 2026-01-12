using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class LightMode_NormalContrast_Spec2021_Green : ITestTheme
{
    public string SourceColor => "#338745"; //Green
    public bool IsDark => false;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#944839";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#FFDAD3";
    public string OnPrimaryContainer => "#763224";

    public string Secondary => "#3E6656";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#C0ECD7";
    public string OnSecondaryContainer => "#264E3F";

    public string Tertiary => "#1A6967";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#A8EFED";
    public string OnTertiaryContainer => "#00504E";

    public string Error => "#BA1A1A";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#FFDAD6";
    public string OnErrorContainer => "#93000A";

    public string Surface => "#F3FCF3";
    public string OnSurface => "#151D19";
    public string OnSurfaceVariant => "#3B4A41";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#EDF6EE";
    public string SurfaceContainer => "#E7F0E8";
    public string SurfaceContainerHigh => "#E1EBE2";
    public string SurfaceContainerHighest => "#DCE5DD";
}
