using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class DarkMode_HighContrast_Spec2025_Orange : ITestTheme
{
    public string SourceColor => "#D77837"; //Orange
    public bool IsDark => true;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#F7E1D6";
    public string OnPrimary => "#362922";
    public string PrimaryContainer => "#B3A096";
    public string OnPrimaryContainer => "#000000";

    public string Secondary => "#EFE3DD";
    public string OnSecondary => "#312B27";
    public string SecondaryContainer => "#ACA29D";
    public string OnSecondaryContainer => "#000000";

    public string Tertiary => "#FFEEDB";
    public string OnTertiary => "#433011";
    public string TertiaryContainer => "#FFDDB1";
    public string OnTertiaryContainer => "#392708";

    public string Error => "#FFDED7";
    public string OnError => "#591001";
    public string ErrorContainer => "#F48469";
    public string OnErrorContainer => "#000000";

    public string Surface => "#100E0D";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#EEE3DF";

    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#151311";
    public string SurfaceContainer => "#1C1917";
    public string SurfaceContainerHigh => "#231F1D";
    public string SurfaceContainerHighest => "#2A2522";
}
