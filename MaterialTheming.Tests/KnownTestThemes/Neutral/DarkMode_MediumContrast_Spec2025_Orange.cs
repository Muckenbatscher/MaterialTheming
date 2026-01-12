using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class DarkMode_MediumContrast_Spec2025_Orange : ITestTheme
{
    public string SourceColor => "#D77837"; //Orange
    public bool IsDark => true;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#D7C2B8";
    public string OnPrimary => "#41332C";
    public string PrimaryContainer => "#827168";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#C2B6B1";
    public string OnSecondary => "#312B27";
    public string SecondaryContainer => "#7C736E";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#FFEEDB";
    public string OnTertiary => "#634C2B";
    public string TertiaryContainer => "#FFDDB1";
    public string OnTertiaryContainer => "#5A4423";

    public string Error => "#FFA089";
    public string OnError => "#591001";
    public string ErrorContainer => "#BA573F";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#100E0D";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#C0B7B3";

    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#151311";
    public string SurfaceContainer => "#1C1917";
    public string SurfaceContainerHigh => "#231F1D";
    public string SurfaceContainerHighest => "#2A2522";
}
