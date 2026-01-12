using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class LightMode_NormalContrast_Spec2025_Cyan : ITestTheme
{
    public string SourceColor => "#00BCD1"; //Cyan
    public bool IsDark => false;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#576062";
    public string OnPrimary => "#F0F9FB";
    public string PrimaryContainer => "#DBE4E6";
    public string OnPrimaryContainer => "#4A5355";

    public string Secondary => "#5C6060";
    public string OnSecondary => "#F7F9FA";
    public string SecondaryContainer => "#E1E3E3";
    public string OnSecondaryContainer => "#4F5253";

    public string Tertiary => "#486272";
    public string OnTertiary => "#F4FAFF";
    public string TertiaryContainer => "#D0ECFF";
    public string OnTertiaryContainer => "#3E5868";

    public string Error => "#9F403D";
    public string OnError => "#FFF7F6";
    public string ErrorContainer => "#FE8983";
    public string OnErrorContainer => "#752121";

    public string Surface => "#FBF9F8";
    public string OnSurface => "#313333";
    public string OnSurfaceVariant => "#5D5F60";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F5F3F3";
    public string SurfaceContainer => "#EEEEED";
    public string SurfaceContainerHigh => "#E8E8E8";
    public string SurfaceContainerHighest => "#E2E2E3";
}
