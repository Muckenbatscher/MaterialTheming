using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class DarkMode_HighContrast_Spec2021_Purple : ITestTheme
{
    public string SourceColor => "#945CCD"; //Purple
    public bool IsDark => true;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#ACFFF7";
    public string OnPrimary => "#000000";
    public string PrimaryContainer => "#6FD3CA";
    public string OnPrimaryContainer => "#000E0D";

    public string Secondary => "#FFEBF0";
    public string OnSecondary => "#000000";
    public string SecondaryContainer => "#E9B4C7";
    public string OnSecondaryContainer => "#1C020E";

    public string Tertiary => "#FFEAFA";
    public string OnTertiary => "#000000";
    public string TertiaryContainer => "#E5B3E2";
    public string OnTertiaryContainer => "#1B001F";

    public string Error => "#FFECE9";
    public string OnError => "#000000";
    public string ErrorContainer => "#FFAEA4";
    public string OnErrorContainer => "#220001";

    public string Surface => "#181118";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#FFFFFF";

    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#241D24";
    public string SurfaceContainer => "#362E36";
    public string SurfaceContainerHigh => "#413941";
    public string SurfaceContainerHighest => "#4D444C";
}
