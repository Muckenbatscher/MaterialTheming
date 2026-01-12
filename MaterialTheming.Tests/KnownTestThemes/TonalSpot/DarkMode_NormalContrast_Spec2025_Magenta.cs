using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class DarkMode_NormalContrast_Spec2025_Magenta : ITestTheme
{
    public string SourceColor => "#E85DAE"; //Magenta
    public bool IsDark => true;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#EEB7D0";
    public string OnPrimary => "#5B3448";
    public string PrimaryContainer => "#70465B";
    public string OnPrimaryContainer => "#FFD9E9";

    public string Secondary => "#E0BDCC";
    public string OnSecondary => "#513945";
    public string SecondaryContainer => "#4C3540";
    public string OnSecondaryContainer => "#D8B6C4";

    public string Tertiary => "#F9E0FF";
    public string OnTertiary => "#664B72";
    public string TertiaryContainer => "#F0CEFD";
    public string OnTertiaryContainer => "#5D4369";

    public string Error => "#F97386";
    public string OnError => "#490013";
    public string ErrorContainer => "#871C34";
    public string OnErrorContainer => "#FF97A3";

    public string Surface => "#120D0F";
    public string OnSurface => "#F4E0E7";
    public string OnSurfaceVariant => "#B8A6AD";

    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#191115";
    public string SurfaceContainer => "#20171B";
    public string SurfaceContainerHigh => "#271D21";
    public string SurfaceContainerHighest => "#2E2328";
}
