using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class DarkMode_NormalContrast_Spec2025_Purple : ITestTheme
{
    public string SourceColor => "#945CCD"; //Purple
    public bool IsDark => true;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#CCC4CE";
    public string OnPrimary => "#443E47";
    public string PrimaryContainer => "#4A454E";
    public string OnPrimaryContainer => "#D6CDD8";

    public string Secondary => "#A19CA1";
    public string OnSecondary => "#221F23";
    public string SecondaryContainer => "#3D3A3E";
    public string OnSecondaryContainer => "#C3BEC2";

    public string Tertiary => "#EFE7FF";
    public string OnTertiary => "#59536F";
    public string TertiaryContainer => "#E1D8FA";
    public string OnTertiaryContainer => "#504B66";

    public string Error => "#EC7C8A";
    public string OnError => "#490013";
    public string ErrorContainer => "#7F2737";
    public string OnErrorContainer => "#FF97A3";

    public string Surface => "#0F0E0F";
    public string OnSurface => "#EAE4E7";
    public string OnSurfaceVariant => "#AEAAAD";

    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#141314";
    public string SurfaceContainer => "#1B191B";
    public string SurfaceContainerHigh => "#211F21";
    public string SurfaceContainerHighest => "#272528";
}
