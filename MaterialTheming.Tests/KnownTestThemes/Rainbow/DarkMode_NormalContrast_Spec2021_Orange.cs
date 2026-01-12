using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Rainbow;

internal class DarkMode_NormalContrast_Spec2021_Orange : ITestTheme
{
    public string SourceColor => "#D77837"; //Orange
    public bool IsDark => true;
    public Variant Variant => Variant.Rainbow;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#FFB68B";
    public string OnPrimary => "#522300";
    public string PrimaryContainer => "#743400";
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

    public string Surface => "#131313";
    public string OnSurface => "#E2E2E2";
    public string OnSurfaceVariant => "#C6C6C6";

    public string SurfaceContainerLowest => "#0E0E0E";
    public string SurfaceContainerLow => "#1B1B1B";
    public string SurfaceContainer => "#1F1F1F";
    public string SurfaceContainerHigh => "#2A2A2A";
    public string SurfaceContainerHighest => "#353535";
}
