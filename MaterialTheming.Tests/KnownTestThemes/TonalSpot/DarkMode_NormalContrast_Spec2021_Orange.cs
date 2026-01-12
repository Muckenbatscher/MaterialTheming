using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class DarkMode_NormalContrast_Spec2021_Orange : ITestTheme
{
    public string SourceColor => "#D77837"; //Orange
    public bool IsDark => true;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#FFB68B";
    public string OnPrimary => "#522300";
    public string PrimaryContainer => "#6F3811";
    public string OnPrimaryContainer => "#FFDBC8";

    public string Secondary => "#E5BFA9";
    public string OnSecondary => "#432B1C";
    public string SecondaryContainer => "#5C4131";
    public string OnSecondaryContainer => "#FFDBC8";

    public string Tertiary => "#CBC992";
    public string OnTertiary => "#333209";
    public string TertiaryContainer => "#49491E";
    public string OnTertiaryContainer => "#E8E5AC";

    public string Error => "#FFB4AB";
    public string OnError => "#690005";
    public string ErrorContainer => "#93000A";
    public string OnErrorContainer => "#FFDAD6";

    public string Surface => "#1A120D";
    public string OnSurface => "#F0DFD7";
    public string OnSurfaceVariant => "#D7C2B8";

    public string SurfaceContainerLowest => "#140D08";
    public string SurfaceContainerLow => "#221A15";
    public string SurfaceContainer => "#261E19";
    public string SurfaceContainerHigh => "#312823";
    public string SurfaceContainerHighest => "#3D332D";
}
