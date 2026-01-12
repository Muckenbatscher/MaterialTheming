using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class LightMode_HighContrast_Spec2025_Red : ITestTheme
{
    public string SourceColor => "#D2463D"; //Red
    public bool IsDark => false;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#2E211F";
    public string OnPrimary => "#ECD5D2";
    public string PrimaryContainer => "#5F4E4C";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#292222";
    public string OnSecondary => "#E4D7D5";
    public string SecondaryContainer => "#59504F";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#371B28";
    public string OnTertiary => "#FBCEDF";
    public string TertiaryContainer => "#6A4957";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#4F0116";
    public string OnError => "#FFCED2";
    public string ErrorContainer => "#8E3242";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#FFF8F7";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#282322";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FAF2F1";
    public string SurfaceContainer => "#F5ECEB";
    public string SurfaceContainerHigh => "#F0E6E5";
    public string SurfaceContainerHighest => "#EBE0DF";
}
