using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class LightMode_MediumContrast_Spec2021_Orange : ITestTheme
{
    public string SourceColor => "#D77837"; //Orange
    public bool IsDark => false;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#5B2700";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#AF5200";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#4D300E";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#8B6640";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#4A3200";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#896728";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#740006";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#CF2C27";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#FFF8F5";
    public string OnSurface => "#1B0E07";
    public string OnSurfaceVariant => "#453227";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFF1EA";
    public string SurfaceContainer => "#FEE3D5";
    public string SurfaceContainerHigh => "#F2D8CA";
    public string SurfaceContainerHighest => "#E6CDBF";
}
