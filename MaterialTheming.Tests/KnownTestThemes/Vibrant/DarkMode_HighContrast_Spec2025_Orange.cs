using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class DarkMode_HighContrast_Spec2025_Orange : ITestTheme
{
    public string SourceColor => "#D77837"; //Orange
    public bool IsDark => true;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#FFDFCE";
    public string OnPrimary => "#4B1F00";
    public string PrimaryContainer => "#FF801D";
    public string OnPrimaryContainer => "#000000";

    public string Secondary => "#FFE0C8";
    public string OnSecondary => "#462300";
    public string SecondaryContainer => "#ED8C24";
    public string OnSecondaryContainer => "#000000";

    public string Tertiary => "#FFE2AC";
    public string OnTertiary => "#3A2900";
    public string TertiaryContainer => "#FFC32D";
    public string OnTertiaryContainer => "#211600";

    public string Error => "#FFDED7";
    public string OnError => "#5A0E00";
    public string ErrorContainer => "#FF7E5E";
    public string OnErrorContainer => "#000000";

    public string Surface => "#1B0A00";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#FFE0C8";

    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#220E00";
    public string SurfaceContainer => "#2B1400";
    public string SurfaceContainerHigh => "#341900";
    public string SurfaceContainerHighest => "#3D1E00";
}
