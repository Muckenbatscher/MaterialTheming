using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class LightMode_MediumContrast_Spec2021_Orange : ITestTheme
{
    public string SourceColor => "#D77837"; //Orange
    public bool IsDark => false;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#453227";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#80685B";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#41332C";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#7A6A61";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#493121";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#856655";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#740006";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#CF2C27";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#FFF8F5";
    public string OnSurface => "#13110F";
    public string OnSurfaceVariant => "#393534";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FAF2EF";
    public string SurfaceContainer => "#EEE6E4";
    public string SurfaceContainerHigh => "#E3DBD8";
    public string SurfaceContainerHighest => "#D8D0CD";
}
