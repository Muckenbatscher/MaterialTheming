using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Content;

internal class DarkMode_MediumContrast_Spec2021_Blue : ITestTheme
{
    public string SourceColor => "#185FAA"; //Blue
    public bool IsDark => true;
    public Variant Variant => Variant.Content;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#CBDDFF";
    public string OnPrimary => "#00264C";
    public string PrimaryContainer => "#5892E1";
    public string OnPrimaryContainer => "#000000";

    public string Secondary => "#CBDDFF";
    public string OnSecondary => "#112642";
    public string SecondaryContainer => "#7E92B3";
    public string OnSecondaryContainer => "#000000";

    public string Tertiary => "#F7CFFF";
    public string OnTertiary => "#420357";
    public string TertiaryContainer => "#B879CC";
    public string OnTertiaryContainer => "#000000";

    public string Error => "#FFD2CC";
    public string OnError => "#540003";
    public string ErrorContainer => "#FF5449";
    public string OnErrorContainer => "#000000";

    public string Surface => "#111318";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#D8DCE9";

    public string SurfaceContainerLowest => "#05070C";
    public string SurfaceContainerLow => "#1B1E23";
    public string SurfaceContainer => "#25282D";
    public string SurfaceContainerHigh => "#303338";
    public string SurfaceContainerHighest => "#3B3E43";
}
