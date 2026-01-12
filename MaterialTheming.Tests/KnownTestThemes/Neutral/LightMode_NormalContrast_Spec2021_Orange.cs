using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class LightMode_NormalContrast_Spec2021_Orange : ITestTheme
{
    public string SourceColor => "#D77837"; //Orange
    public bool IsDark => false;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#705A4D";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#FBDCCC";
    public string OnPrimaryContainer => "#574236";

    public string Secondary => "#6B5B53";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#F4DED3";
    public string OnSecondaryContainer => "#52443C";

    public string Tertiary => "#765847";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#FFDBC8";
    public string OnTertiaryContainer => "#5C4131";

    public string Error => "#BA1A1A";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#FFDAD6";
    public string OnErrorContainer => "#93000A";

    public string Surface => "#FFF8F5";
    public string OnSurface => "#1E1B19";
    public string OnSurfaceVariant => "#4A4644";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FAF2EF";
    public string SurfaceContainer => "#F4ECE9";
    public string SurfaceContainerHigh => "#EEE6E4";
    public string SurfaceContainerHighest => "#E9E1DE";
}
