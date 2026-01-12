using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class LightMode_MediumContrast_Spec2021_Magenta : ITestTheme
{
    public string SourceColor => "#E85DAE"; //Magenta
    public bool IsDark => false;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#003B4F";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#127698";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#532C20";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#926152";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#393800";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#71702F";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#740006";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#CF2C27";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#FFF8F7";
    public string OnSurface => "#190E10";
    public string OnSurfaceVariant => "#453135";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFF0F1";
    public string SurfaceContainer => "#F9E3E6";
    public string SurfaceContainerHigh => "#EDD8DA";
    public string SurfaceContainerHighest => "#E1CDCF";
}
