using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class LightMode_HighContrast_Spec2025_Green : ITestTheme
{
    public string SourceColor => "#338745"; //Green
    public bool IsDark => false;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#002B0C";
    public string OnPrimary => "#B6E6B6";
    public string PrimaryContainer => "#305B36";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#172819";
    public string OnSecondary => "#CCE0C8";
    public string SecondaryContainer => "#455745";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#222600";
    public string OnTertiary => "#D8DF9F";
    public string TertiaryContainer => "#4F5624";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#4C0A00";
    public string OnError => "#FFCFC4";
    public string ErrorContainer => "#952E15";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#F8FAF3";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#1F261E";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F1F5EC";
    public string SurfaceContainer => "#EAF0E6";
    public string SurfaceContainerHigh => "#E4EADF";
    public string SurfaceContainerHighest => "#DDE5D9";
}
