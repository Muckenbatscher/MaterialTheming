using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Content;

internal class LightMode_HighContrast_Spec2025_Cyan : ITestTheme
{
    public string SourceColor => "#00BCD1"; //Cyan
    public bool IsDark => false;
    public Variant Variant => Variant.Content;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#003138";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#00515B";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#003138";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#1F5057";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#450F63";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#653283";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#600004";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#98000A";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#F4FAFC";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#000000";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#ECF2F3";
    public string SurfaceContainer => "#DDE4E5";
    public string SurfaceContainerHigh => "#CFD5D7";
    public string SurfaceContainerHighest => "#C1C8C9";
}
