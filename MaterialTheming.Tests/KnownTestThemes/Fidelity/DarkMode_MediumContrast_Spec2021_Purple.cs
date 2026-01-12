using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Fidelity;

internal class DarkMode_MediumContrast_Spec2021_Purple : ITestTheme
{
    public string SourceColor => "#945CCD"; //Purple
    public bool IsDark => true;
    public Variant Variant => Variant.Fidelity;
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

    public string Tertiary => "#F8DB69";
    public string OnTertiary => "#2E2500";
    public string TertiaryContainer => "#C4AA3D";
    public string OnTertiaryContainer => "#282000";

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
