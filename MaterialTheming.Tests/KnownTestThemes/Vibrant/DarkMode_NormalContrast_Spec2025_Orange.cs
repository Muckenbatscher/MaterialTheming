using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class DarkMode_NormalContrast_Spec2025_Orange : ITestTheme
{
    public string SourceColor => "#D77837"; //Orange
    public bool IsDark => true;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#FF9248";
    public string OnPrimary => "#4F2100";
    public string PrimaryContainer => "#FF7B00";
    public string OnPrimaryContainer => "#3D1800";

    public string Secondary => "#FD9831";
    public string OnSecondary => "#4C2700";
    public string SecondaryContainer => "#8E4E00";
    public string OnSecondaryContainer => "#FFF6F1";

    public string Tertiary => "#FFD47D";
    public string OnTertiary => "#634800";
    public string TertiaryContainer => "#FFC32D";
    public string OnTertiaryContainer => "#584000";

    public string Error => "#FF7351";
    public string OnError => "#450900";
    public string ErrorContainer => "#B92902";
    public string OnErrorContainer => "#FFD2C8";

    public string Surface => "#1B0A00";
    public string OnSurface => "#FFE0C8";
    public string OnSurfaceVariant => "#D6A072";

    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#220E00";
    public string SurfaceContainer => "#2B1400";
    public string SurfaceContainerHigh => "#341900";
    public string SurfaceContainerHighest => "#3D1E00";
}
