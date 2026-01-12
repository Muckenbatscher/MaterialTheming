using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class DarkMode_NormalContrast_Spec2025_Magenta : ITestTheme
{
    public string SourceColor => "#E85DAE"; //Magenta
    public bool IsDark => true;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#FFC0DD";
    public string OnPrimary => "#6D3453";
    public string PrimaryContainer => "#F9ADD2";
    public string OnPrimaryContainer => "#622B4A";

    public string Secondary => "#B0CCC8";
    public string OnSecondary => "#2C4542";
    public string SecondaryContainer => "#102A28";
    public string OnSecondaryContainer => "#8EA9A6";

    public string Tertiary => "#89FFED";
    public string OnTertiary => "#006258";
    public string TertiaryContainer => "#6EF2DF";
    public string OnTertiaryContainer => "#00594F";

    public string Error => "#FD6F85";
    public string OnError => "#490013";
    public string ErrorContainer => "#8A1632";
    public string OnErrorContainer => "#FF97A3";

    public string Surface => "#190911";
    public string OnSurface => "#FFDCEA";
    public string OnSurfaceVariant => "#CC9FB3";

    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#200D17";
    public string SurfaceContainer => "#29121E";
    public string SurfaceContainerHigh => "#311725";
    public string SurfaceContainerHighest => "#3A1C2C";
}
