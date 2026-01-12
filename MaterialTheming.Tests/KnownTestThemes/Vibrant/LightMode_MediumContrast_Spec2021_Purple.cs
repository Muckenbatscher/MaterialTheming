using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class LightMode_MediumContrast_Spec2021_Purple : ITestTheme
{
    public string SourceColor => "#945CCD"; //Purple
    public bool IsDark => false;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#51008E";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#9A23FF";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#452E4B";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#7E6484";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#50284B";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#8C5E85";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#740006";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#CF2C27";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#FFF7FE";
    public string OnSurface => "#140F19";
    public string OnSurfaceVariant => "#3B3341";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FBF0FF";
    public string SurfaceContainer => "#F0E5F3";
    public string SurfaceContainerHigh => "#E4D9E8";
    public string SurfaceContainerHighest => "#D9CEDC";
}
