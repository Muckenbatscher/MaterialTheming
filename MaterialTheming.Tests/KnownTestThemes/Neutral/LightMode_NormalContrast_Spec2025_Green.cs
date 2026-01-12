using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class LightMode_NormalContrast_Spec2025_Green : ITestTheme
{
    public string SourceColor => "#338745"; //Green
    public bool IsDark => false;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#596057";
    public string OnPrimary => "#F3FAEE";
    public string PrimaryContainer => "#DDE5D9";
    public string OnPrimaryContainer => "#4D544B";

    public string Secondary => "#5D605B";
    public string OnSecondary => "#F8F9F4";
    public string SecondaryContainer => "#E2E3DD";
    public string OnSecondaryContainer => "#50524E";

    public string Tertiary => "#496553";
    public string OnTertiary => "#E7FFEC";
    public string TertiaryContainer => "#DBFCE3";
    public string OnTertiaryContainer => "#466250";

    public string Error => "#9E422C";
    public string OnError => "#FFF7F6";
    public string ErrorContainer => "#FE8B70";
    public string OnErrorContainer => "#742410";

    public string Surface => "#FBF9F6";
    public string OnSurface => "#313330";
    public string OnSurfaceVariant => "#5E5F5C";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F5F3F0";
    public string SurfaceContainer => "#EFEEEA";
    public string SurfaceContainerHigh => "#E9E8E4";
    public string SurfaceContainerHighest => "#E3E3DE";
}
