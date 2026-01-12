using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class DarkMode_MediumContrast_Spec2025_Red : ITestTheme
{
    public string SourceColor => "#D2463D"; //Red
    public bool IsDark => true;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#F9B6AE";
    public string OnPrimary => "#552A25";
    public string PrimaryContainer => "#9E6660";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#E7BDB8";
    public string OnSecondary => "#4B2F2C";
    public string SecondaryContainer => "#8F6C68";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#FFE0BD";
    public string OnTertiary => "#634314";
    public string TertiaryContainer => "#FFCF93";
    public string OnTertiaryContainer => "#593B0C";

    public string Error => "#FF9DA8";
    public string OnError => "#5F001C";
    public string ErrorContainer => "#C44B5F";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#130C0C";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#CAB4B1";

    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#1A1110";
    public string SurfaceContainer => "#221716";
    public string SurfaceContainerHigh => "#291D1B";
    public string SurfaceContainerHighest => "#302221";
}
