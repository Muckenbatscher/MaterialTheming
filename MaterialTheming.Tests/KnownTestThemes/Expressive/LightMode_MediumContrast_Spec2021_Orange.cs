using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class LightMode_MediumContrast_Spec2021_Orange : ITestTheme
{
    public string SourceColor => "#D77837"; //Orange
    public bool IsDark => false;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#332D6D";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#6B65A8";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#233C21";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#597454";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#003F2D";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#3A7861";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#740006";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#CF2C27";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#FFF8F5";
    public string OnSurface => "#181007";
    public string OnSurfaceVariant => "#433324";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFF1E7";
    public string SurfaceContainer => "#F8E5D6";
    public string SurfaceContainerHigh => "#ECDACB";
    public string SurfaceContainerHighest => "#E0CEC0";
}
