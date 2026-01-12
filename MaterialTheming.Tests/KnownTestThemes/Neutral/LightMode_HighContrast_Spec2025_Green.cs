using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class LightMode_HighContrast_Spec2025_Green : ITestTheme
{
    public string SourceColor => "#338745"; //Green
    public bool IsDark => false;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#1F261E";
    public string OnPrimary => "#D5DCD1";
    public string PrimaryContainer => "#4D544C";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#222521";
    public string OnSecondary => "#D9DBD5";
    public string SecondaryContainer => "#50534F";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#0E291A";
    public string OnTertiary => "#C2E2CA";
    public string TertiaryContainer => "#3D5846";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#4C0A00";
    public string OnError => "#FFCFC4";
    public string ErrorContainer => "#8D3621";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#FBF9F6";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#232422";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F5F3F0";
    public string SurfaceContainer => "#EFEEEA";
    public string SurfaceContainerHigh => "#E9E8E4";
    public string SurfaceContainerHighest => "#E3E3DE";
}
