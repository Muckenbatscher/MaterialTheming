using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class LightMode_HighContrast_Spec2025_Orange : ITestTheme
{
    public string SourceColor => "#D77837"; //Orange
    public bool IsDark => false;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#3F1900";
    public string OnPrimary => "#FFD1B7";
    public string PrimaryContainer => "#794522";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#351F11";
    public string OnSecondary => "#FAD2BC";
    public string SecondaryContainer => "#684C3B";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#2B2300";
    public string OnTertiary => "#ECDA95";
    public string TertiaryContainer => "#5E521B";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#4C0A00";
    public string OnError => "#FFCFC4";
    public string ErrorContainer => "#952E15";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#FFF8F5";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#2E211A";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFF1EA";
    public string SurfaceContainer => "#FEEAE0";
    public string SurfaceContainerHigh => "#F9E4DA";
    public string SurfaceContainerHighest => "#F5DED2";
}
