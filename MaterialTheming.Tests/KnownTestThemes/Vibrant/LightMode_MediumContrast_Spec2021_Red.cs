using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class LightMode_MediumContrast_Spec2021_Red : ITestTheme
{
    public string SourceColor => "#D2463D"; //Red
    public bool IsDark => false;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#740006";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#DC0017";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#522C1B";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#91624D";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#542C01";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#956132";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#740006";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#CF2C27";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#FFF8F7";
    public string OnSurface => "#1B0E0C";
    public string OnSurfaceVariant => "#46312E";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFF0EE";
    public string SurfaceContainer => "#FFE2DE";
    public string SurfaceContainerHigh => "#F3D7D3";
    public string SurfaceContainerHighest => "#E7CBC8";
}
