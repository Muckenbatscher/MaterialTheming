using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class DarkMode_MediumContrast_Spec2025_Orange : ITestTheme
{
    public string SourceColor => "#D77837"; //Orange
    public bool IsDark => true;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#FFA268";
    public string OnPrimary => "#4B2000";
    public string PrimaryContainer => "#FF7B00";
    public string OnPrimaryContainer => "#270D00";

    public string Secondary => "#FFA44D";
    public string OnSecondary => "#462300";
    public string SecondaryContainer => "#AF6100";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#FFD47D";
    public string OnTertiary => "#573F00";
    public string TertiaryContainer => "#FFC32D";
    public string OnTertiaryContainer => "#4C3600";

    public string Error => "#FFA089";
    public string OnError => "#5A0E00";
    public string ErrorContainer => "#D53D18";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#1B0A00";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#E5AD7E";

    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#220E00";
    public string SurfaceContainer => "#2B1400";
    public string SurfaceContainerHigh => "#341900";
    public string SurfaceContainerHighest => "#3D1E00";
}
