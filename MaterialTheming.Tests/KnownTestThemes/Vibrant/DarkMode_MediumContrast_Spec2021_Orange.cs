using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class DarkMode_MediumContrast_Spec2021_Orange : ITestTheme
{
    public string SourceColor => "#D77837"; //Orange
    public bool IsDark => true;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#FFD3BB";
    public string OnPrimary => "#411A00";
    public string PrimaryContainer => "#E76E00";
    public string OnPrimaryContainer => "#000000";

    public string Secondary => "#FFD5AD";
    public string OnSecondary => "#3A2002";
    public string SecondaryContainer => "#B28960";
    public string OnSecondaryContainer => "#000000";

    public string Tertiary => "#FFD695";
    public string OnTertiary => "#342200";
    public string TertiaryContainer => "#B18B48";
    public string OnTertiaryContainer => "#000000";

    public string Error => "#FFD2CC";
    public string OnError => "#540003";
    public string ErrorContainer => "#FF5449";
    public string OnErrorContainer => "#000000";

    public string Surface => "#1D1009";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#F5D6C6";

    public string SurfaceContainerLowest => "#0F0502";
    public string SurfaceContainerLow => "#281B12";
    public string SurfaceContainer => "#33251C";
    public string SurfaceContainerHigh => "#3F2F26";
    public string SurfaceContainerHighest => "#4B3A31";
}
