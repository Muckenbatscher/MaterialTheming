using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class LightMode_MediumContrast_Spec2025_Orange : ITestTheme
{
    public string SourceColor => "#D77837"; //Orange
    public bool IsDark => false;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#692F00";
    public string OnPrimary => "#FFC9AA";
    public string PrimaryContainer => "#BB5800";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#623400";
    public string OnSecondary => "#FFCA9E";
    public string SecondaryContainer => "#AF6100";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#523C00";
    public string OnTertiary => "#FFCD61";
    public string TertiaryContainer => "#956E00";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#7D1800";
    public string OnError => "#FFC7BA";
    public string ErrorContainer => "#D53D18";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#FFF4EF";
    public string OnSurface => "#331900";
    public string OnSurfaceVariant => "#5C3611";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFEEE2";
    public string SurfaceContainer => "#FFE3CF";
    public string SurfaceContainerHigh => "#FFDCC1";
    public string SurfaceContainerHighest => "#FFD5B4";
}
