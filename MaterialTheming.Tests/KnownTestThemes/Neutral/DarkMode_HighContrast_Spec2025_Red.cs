using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class DarkMode_HighContrast_Spec2025_Red : ITestTheme
{
    public string SourceColor => "#D2463D"; //Red
    public bool IsDark => true;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#F8E0DD";
    public string OnPrimary => "#362927";
    public string PrimaryContainer => "#B49F9C";
    public string OnPrimaryContainer => "#000000";

    public string Secondary => "#F0E3E1";
    public string OnSecondary => "#312A29";
    public string SecondaryContainer => "#ACA1A0";
    public string OnSecondaryContainer => "#000000";

    public string Tertiary => "#FFDCE9";
    public string OnTertiary => "#402330";
    public string TertiaryContainer => "#F5C8DA";
    public string OnTertiaryContainer => "#311723";

    public string Error => "#FFDDDF";
    public string OnError => "#5B0A1E";
    public string ErrorContainer => "#F38190";
    public string OnErrorContainer => "#000000";

    public string Surface => "#100E0D";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#EEE3E1";

    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#161312";
    public string SurfaceContainer => "#1C1918";
    public string SurfaceContainerHigh => "#231F1E";
    public string SurfaceContainerHighest => "#2A2524";
}
