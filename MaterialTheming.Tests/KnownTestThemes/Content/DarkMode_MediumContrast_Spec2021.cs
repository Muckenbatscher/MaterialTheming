using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Content;

internal class DarkMode_MediumContrast_Spec2021 : ITestTheme
{
    public string SourceColor => "#945CCD"; //purple
    public bool IsDark => true;
    public Variant Variant => Variant.Content;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#ECD3FF";
    public string OnPrimary => "#3A0068";
    public string PrimaryContainer => "#AF76E9";
    public string OnPrimaryContainer => "#000000";

    public string Secondary => "#ECD3FF";
    public string OnSecondary => "#301C45";
    public string SecondaryContainer => "#A087B7";
    public string OnSecondaryContainer => "#000000";

    public string Tertiary => "#FFD0E1";
    public string OnTertiary => "#4F0030";
    public string TertiaryContainer => "#E067A2";
    public string OnTertiaryContainer => "#000000";

    public string Error => "#FFD2CC";
    public string OnError => "#540003";
    public string ErrorContainer => "#FF5449";
    public string OnErrorContainer => "#000000";

    public string Surface => "#161219";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#E4D8E9";

    public string SurfaceContainerLowest => "#09060C";
    public string SurfaceContainerLow => "#201C23";
    public string SurfaceContainer => "#2B262E";
    public string SurfaceContainerHigh => "#363139";
    public string SurfaceContainerHighest => "#413C44";
}
