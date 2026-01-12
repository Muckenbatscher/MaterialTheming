using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class LightMode_MediumContrast_Spec2025_Green : ITestTheme
{
    public string SourceColor => "#338745"; //Green
    public bool IsDark => false;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#3E453D";
    public string OnPrimary => "#D5DCD1";
    public string PrimaryContainer => "#6F776D";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#414440";
    public string OnSecondary => "#D9DAD5";
    public string SecondaryContainer => "#737571";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#2D4938";
    public string OnTertiary => "#C2E1CA";
    public string TertiaryContainer => "#5E7B68";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#792713";
    public string OnError => "#FFCFC4";
    public string ErrorContainer => "#BA573F";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#FBF9F6";
    public string OnSurface => "#232422";
    public string OnSurfaceVariant => "#424340";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F5F3F0";
    public string SurfaceContainer => "#EFEEEA";
    public string SurfaceContainerHigh => "#E9E8E4";
    public string SurfaceContainerHighest => "#E3E3DE";
}
