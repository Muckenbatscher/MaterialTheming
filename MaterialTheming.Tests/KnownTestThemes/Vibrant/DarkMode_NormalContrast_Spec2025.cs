using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class DarkMode_NormalContrast_Spec2025 : ITestTheme
{
    public string SourceColor => "#338745"; //green
    public bool IsDark => true;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#63FC85";
    public string OnPrimary => "#005D24";
    public string PrimaryContainer => "#02BF51";
    public string OnPrimaryContainer => "#002F0E";

    public string Secondary => "#7AF8B1";
    public string OnSecondary => "#005C37";
    public string SecondaryContainer => "#006D42";
    public string OnSecondaryContainer => "#E2FFE8";

    public string Tertiary => "#86ECFF";
    public string OnTertiary => "#005762";
    public string TertiaryContainer => "#00E3FF";
    public string OnTertiaryContainer => "#004D58";

    public string Error => "#FF7351";
    public string OnError => "#450900";
    public string ErrorContainer => "#B92902";
    public string OnErrorContainer => "#FFD2C8";

    public string Surface => "#001207";
    public string OnSurface => "#CBFCDA";
    public string OnSurfaceVariant => "#87B697";

    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#00180A";
    public string SurfaceContainer => "#001F0F";
    public string SurfaceContainerHigh => "#002613";
    public string SurfaceContainerHighest => "#002D18";
}
