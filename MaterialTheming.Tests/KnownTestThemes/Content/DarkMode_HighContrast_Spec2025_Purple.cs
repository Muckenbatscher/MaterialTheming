using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Content;

internal class DarkMode_HighContrast_Spec2025_Purple : ITestTheme
{
    public string SourceColor => "#945CCD"; //Purple
    public bool IsDark => true;
    public Variant Variant => Variant.Content;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#F9EBFF";
    public string OnPrimary => "#000000";
    public string PrimaryContainer => "#DAB3FF";
    public string OnPrimaryContainer => "#0B001B";

    public string Secondary => "#F9EBFF";
    public string OnSecondary => "#000000";
    public string SecondaryContainer => "#D3B8EB";
    public string OnSecondaryContainer => "#140129";

    public string Tertiary => "#FFEBF1";
    public string OnTertiary => "#000000";
    public string TertiaryContainer => "#FFA9CE";
    public string OnTertiaryContainer => "#200010";

    public string Error => "#FFECE9";
    public string OnError => "#000000";
    public string ErrorContainer => "#FFAEA4";
    public string OnErrorContainer => "#220001";

    public string Surface => "#161219";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#FFFFFF";

    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#221E25";
    public string SurfaceContainer => "#332F36";
    public string SurfaceContainerHigh => "#3F3A42";
    public string SurfaceContainerHighest => "#4A454D";
}
