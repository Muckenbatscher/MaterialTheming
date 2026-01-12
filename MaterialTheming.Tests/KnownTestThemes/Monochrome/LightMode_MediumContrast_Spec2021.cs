using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Monochrome;

internal class LightMode_MediumContrast_Spec2021 : ITestTheme
{
    public string SourceColor => "#E85DAE"; //magenta
    public bool IsDark => false;
    public Variant Variant => Variant.Monochrome;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#000000";
    public string OnPrimary => "#E2E2E2";
    public string PrimaryContainer => "#3B3B3B";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#363636";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#6D6D6D";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#363636";
    public string OnTertiary => "#F5F5F5";
    public string TertiaryContainer => "#6D6D6D";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#740006";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#CF2C27";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#F9F9F9";
    public string OnSurface => "#111111";
    public string OnSurfaceVariant => "#363636";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F3F3F3";
    public string SurfaceContainer => "#E8E8E8";
    public string SurfaceContainerHigh => "#DDDDDD";
    public string SurfaceContainerHighest => "#D1D1D1";
}
