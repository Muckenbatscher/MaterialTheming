using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class DarkMode_NormalContrast_Spec2025_Orange : ITestTheme
{
    public string SourceColor => "#D77837"; //Orange
    public bool IsDark => true;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#FFC29E";
    public string OnPrimary => "#6D3710";
    public string PrimaryContainer => "#FFAF7E";
    public string OnPrimaryContainer => "#622E07";

    public string Secondary => "#B9C8DA";
    public string OnSecondary => "#344150";
    public string SecondaryContainer => "#192735";
    public string OnSecondaryContainer => "#97A5B7";

    public string Tertiary => "#91CDFF";
    public string OnTertiary => "#004468";
    public string TertiaryContainer => "#6FC0FF";
    public string OnTertiaryContainer => "#003A5A";

    public string Error => "#FE7453";
    public string OnError => "#450900";
    public string ErrorContainer => "#881F05";
    public string OnErrorContainer => "#FF9B82";

    public string Surface => "#190B01";
    public string OnSurface => "#FFE0C8";
    public string OnSurfaceVariant => "#CFA27E";

    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#200F02";
    public string SurfaceContainer => "#291503";
    public string SurfaceContainerHigh => "#311A04";
    public string SurfaceContainerHighest => "#3A1F05";
}
