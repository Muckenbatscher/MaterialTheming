using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class DarkMode_MediumContrast_Spec2025_Purple : ITestTheme
{
    public string SourceColor => "#945CCD"; //Purple
    public bool IsDark => true;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#CCC4CE";
    public string OnPrimary => "#39343D";
    public string PrimaryContainer => "#79727C";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#BDB7BC";
    public string OnSecondary => "#2E2B2F";
    public string SecondaryContainer => "#777377";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#EFE7FF";
    public string OnTertiary => "#4F4964";
    public string TertiaryContainer => "#E1D8FA";
    public string OnTertiaryContainer => "#46415C";

    public string Error => "#FF9DA8";
    public string OnError => "#5B0A1E";
    public string ErrorContainer => "#B95463";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#0F0E0F";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#BCB7BB";

    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#141314";
    public string SurfaceContainer => "#1B191B";
    public string SurfaceContainerHigh => "#211F21";
    public string SurfaceContainerHighest => "#272528";
}
