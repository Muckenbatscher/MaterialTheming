using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class DarkMode_MediumContrast_Spec2025_Orange : ITestTheme
{
    public string SourceColor => "#D77837"; //Orange
    public bool IsDark => true;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#FFC29E";
    public string OnPrimary => "#612D06";
    public string PrimaryContainer => "#FFAF7E";
    public string OnPrimaryContainer => "#552400";

    public string Secondary => "#B9C8DA";
    public string OnSecondary => "#2A3746";
    public string SecondaryContainer => "#687686";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#91CDFF";
    public string OnTertiary => "#003959";
    public string TertiaryContainer => "#6FC0FF";
    public string OnTertiaryContainer => "#002F4A";

    public string Error => "#FFA089";
    public string OnError => "#5A0E00";
    public string ErrorContainer => "#C74C2F";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#190B01";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#DEB08A";

    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#200F02";
    public string SurfaceContainer => "#291503";
    public string SurfaceContainerHigh => "#311A04";
    public string SurfaceContainerHighest => "#3A1F05";
}
