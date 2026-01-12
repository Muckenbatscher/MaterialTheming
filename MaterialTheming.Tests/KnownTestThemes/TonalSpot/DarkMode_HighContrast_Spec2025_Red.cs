using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class DarkMode_HighContrast_Spec2025_Red : ITestTheme
{
    public string SourceColor => "#D2463D"; //Red
    public bool IsDark => true;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#FFDEDA";
    public string OnPrimary => "#49201C";
    public string PrimaryContainer => "#D2948D";
    public string OnPrimaryContainer => "#000000";

    public string Secondary => "#FFDEDA";
    public string OnSecondary => "#3F2522";
    public string SecondaryContainer => "#C29A96";
    public string OnSecondaryContainer => "#000000";

    public string Tertiary => "#FFE0BD";
    public string OnTertiary => "#402700";
    public string TertiaryContainer => "#FFCF93";
    public string OnTertiaryContainer => "#321D00";

    public string Error => "#FFDDDF";
    public string OnError => "#5F001C";
    public string ErrorContainer => "#FF798C";
    public string OnErrorContainer => "#000000";

    public string Surface => "#130C0C";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#F9E0DD";

    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#1A1110";
    public string SurfaceContainer => "#221716";
    public string SurfaceContainerHigh => "#291D1B";
    public string SurfaceContainerHighest => "#302221";
}
