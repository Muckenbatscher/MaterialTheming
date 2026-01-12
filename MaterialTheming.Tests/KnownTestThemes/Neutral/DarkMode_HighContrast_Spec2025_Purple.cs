using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class DarkMode_HighContrast_Spec2025_Purple : ITestTheme
{
    public string SourceColor => "#945CCD"; //Purple
    public bool IsDark => true;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#ECE2EE";
    public string OnPrimary => "#2F2A32";
    public string PrimaryContainer => "#A9A1AB";
    public string OnPrimaryContainer => "#000000";

    public string Secondary => "#EAE4E8";
    public string OnSecondary => "#2E2B2F";
    public string SecondaryContainer => "#A7A2A7";
    public string OnSecondaryContainer => "#000000";

    public string Tertiary => "#EFE7FF";
    public string OnTertiary => "#312C45";
    public string TertiaryContainer => "#E1D8FA";
    public string OnTertiaryContainer => "#27233B";

    public string Error => "#FFDDDF";
    public string OnError => "#5B0A1E";
    public string ErrorContainer => "#F38190";
    public string OnErrorContainer => "#000000";

    public string Surface => "#0F0E0F";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#EAE4E7";

    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#141314";
    public string SurfaceContainer => "#1B191B";
    public string SurfaceContainerHigh => "#211F21";
    public string SurfaceContainerHighest => "#272528";
}
