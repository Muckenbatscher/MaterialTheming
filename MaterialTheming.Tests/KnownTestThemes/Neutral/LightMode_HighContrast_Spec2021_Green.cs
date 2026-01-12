using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class LightMode_HighContrast_Spec2021_Green : ITestTheme
{
    public string SourceColor => "#338745"; //Green
    public bool IsDark => false;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#242F23";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#404C3F";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#272E26";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#444B43";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#203020";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#3C4D3C";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#600004";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#98000A";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#FBF9F6";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#000000";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F2F0ED";
    public string SurfaceContainer => "#E4E2DF";
    public string SurfaceContainerHigh => "#D6D4D1";
    public string SurfaceContainerHighest => "#C7C6C3";
}
