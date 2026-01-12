using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class LightMode_NormalContrast_Spec2021_Orange : ITestTheme
{
    public string SourceColor => "#D77837"; //Orange
    public bool IsDark => false;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#8C4F26";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#FFDBC8";
    public string OnPrimaryContainer => "#6F3811";

    public string Secondary => "#765847";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#FFDBC8";
    public string OnSecondaryContainer => "#5C4131";

    public string Tertiary => "#626033";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#E8E5AC";
    public string OnTertiaryContainer => "#49491E";

    public string Error => "#BA1A1A";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#FFDAD6";
    public string OnErrorContainer => "#93000A";

    public string Surface => "#FFF8F5";
    public string OnSurface => "#221A15";
    public string OnSurfaceVariant => "#52443C";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFF1EA";
    public string SurfaceContainer => "#FCEAE2";
    public string SurfaceContainerHigh => "#F6E5DD";
    public string SurfaceContainerHighest => "#F0DFD7";
}
