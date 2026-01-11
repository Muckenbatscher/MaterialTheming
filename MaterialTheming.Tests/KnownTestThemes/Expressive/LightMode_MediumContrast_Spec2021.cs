using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class LightMode_MediumContrast_Spec2021 : ITestTheme
{
    public string SourceColor => "#945CCD"; //purple
    public bool IsDark => false;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#003E3A";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#007A74";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#4F2B3A";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#8D6071";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#4D284F";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#895F89";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#740006";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#CF2C27";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#FFF7FA";
    public string OnSurface => "#150F16";
    public string OnSurfaceVariant => "#3E323F";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FDF0FA";
    public string SurfaceContainer => "#F2E4EE";
    public string SurfaceContainerHigh => "#E6D9E3";
    public string SurfaceContainerHighest => "#DBCED8";
}
