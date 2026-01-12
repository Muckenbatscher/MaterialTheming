using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class DarkMode_MediumContrast_Spec2025_Red : ITestTheme
{
    public string SourceColor => "#D2463D"; //Red
    public bool IsDark => true;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#D8C2BF";
    public string OnPrimary => "#413331";
    public string PrimaryContainer => "#83706E";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#C2B6B4";
    public string OnSecondary => "#322A2A";
    public string SecondaryContainer => "#7C7271";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#FFD8E6";
    public string OnTertiary => "#5F3F4C";
    public string TertiaryContainer => "#F5C8DA";
    public string OnTertiaryContainer => "#553644";

    public string Error => "#FF9DA8";
    public string OnError => "#5B0A1E";
    public string ErrorContainer => "#B95463";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#100E0D";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#C0B7B5";

    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#161312";
    public string SurfaceContainer => "#1C1918";
    public string SurfaceContainerHigh => "#231F1E";
    public string SurfaceContainerHighest => "#2A2524";
}
