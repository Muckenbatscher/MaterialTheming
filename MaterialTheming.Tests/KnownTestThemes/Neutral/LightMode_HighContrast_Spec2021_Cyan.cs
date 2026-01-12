using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class LightMode_HighContrast_Spec2021_Cyan : ITestTheme
{
    public string SourceColor => "#00BCD1"; //Cyan
    public bool IsDark => false;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#1F2F32";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#3C4C4F";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#252E2F";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#424B4D";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#173034";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#354D51";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#600004";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#98000A";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#FAF9F9";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#000000";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F2F0F0";
    public string SurfaceContainer => "#E3E2E2";
    public string SurfaceContainerHigh => "#D5D4D4";
    public string SurfaceContainerHighest => "#C7C6C6";
}
