using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class DarkMode_MediumContrast_Spec2021_Orange : ITestTheme
{
    public string SourceColor => "#D77837"; //Orange
    public bool IsDark => true;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#F5D6C6";
    public string OnPrimary => "#332217";
    public string PrimaryContainer => "#A68B7D";
    public string OnPrimaryContainer => "#000000";

    public string Secondary => "#EED8CD";
    public string OnSecondary => "#2F231C";
    public string SecondaryContainer => "#9F8D84";
    public string OnSecondaryContainer => "#000000";

    public string Tertiary => "#FCD4BE";
    public string OnTertiary => "#372012";
    public string TertiaryContainer => "#AC8A76";
    public string OnTertiaryContainer => "#000000";

    public string Error => "#FFD2CC";
    public string OnError => "#540003";
    public string ErrorContainer => "#FF5449";
    public string OnErrorContainer => "#000000";

    public string Surface => "#161311";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#E2DBD8";

    public string SurfaceContainerLowest => "#090706";
    public string SurfaceContainerLow => "#201D1B";
    public string SurfaceContainer => "#2B2725";
    public string SurfaceContainerHigh => "#363230";
    public string SurfaceContainerHighest => "#413D3B";
}
