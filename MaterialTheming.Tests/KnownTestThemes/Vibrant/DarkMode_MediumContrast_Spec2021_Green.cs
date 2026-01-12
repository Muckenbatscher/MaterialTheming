using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class DarkMode_MediumContrast_Spec2021_Green : ITestTheme
{
    public string SourceColor => "#338745"; //Green
    public bool IsDark => true;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#00FD6E";
    public string OnPrimary => "#002D0D";
    public string PrimaryContainer => "#00A746";
    public string OnPrimaryContainer => "#000000";

    public string Secondary => "#BCE6CD";
    public string OnSecondary => "#022C1C";
    public string SecondaryContainer => "#729984";
    public string OnSecondaryContainer => "#000000";

    public string Tertiary => "#A5EAD8";
    public string OnTertiary => "#002C24";
    public string TertiaryContainer => "#599D8D";
    public string OnTertiaryContainer => "#000000";

    public string Error => "#FFD2CC";
    public string OnError => "#540003";
    public string ErrorContainer => "#FF5449";
    public string OnErrorContainer => "#000000";

    public string Surface => "#0D150D";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#D3E0CF";

    public string SurfaceContainerLowest => "#030903";
    public string SurfaceContainerLow => "#172017";
    public string SurfaceContainer => "#212A21";
    public string SurfaceContainerHigh => "#2C352B";
    public string SurfaceContainerHighest => "#374036";
}
