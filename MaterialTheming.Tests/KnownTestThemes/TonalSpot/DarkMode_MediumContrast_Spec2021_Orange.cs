using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class DarkMode_MediumContrast_Spec2021_Orange : ITestTheme
{
    public string SourceColor => "#D77837"; //Orange
    public bool IsDark => true;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#FFD3BB";
    public string OnPrimary => "#411A00";
    public string PrimaryContainer => "#C78053";
    public string OnPrimaryContainer => "#000000";

    public string Secondary => "#FCD4BE";
    public string OnSecondary => "#372012";
    public string SecondaryContainer => "#AC8A76";
    public string OnSecondaryContainer => "#000000";

    public string Tertiary => "#E2DFA6";
    public string OnTertiary => "#282701";
    public string TertiaryContainer => "#959361";
    public string OnTertiaryContainer => "#000000";

    public string Error => "#FFD2CC";
    public string OnError => "#540003";
    public string ErrorContainer => "#FF5449";
    public string OnErrorContainer => "#000000";

    public string Surface => "#1A120D";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#EED8CD";

    public string SurfaceContainerLowest => "#0C0604";
    public string SurfaceContainerLow => "#241C17";
    public string SurfaceContainer => "#2F2621";
    public string SurfaceContainerHigh => "#3A312B";
    public string SurfaceContainerHighest => "#463C36";
}
