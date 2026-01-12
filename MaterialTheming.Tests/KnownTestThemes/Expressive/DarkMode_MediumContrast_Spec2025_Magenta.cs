using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class DarkMode_MediumContrast_Spec2025_Magenta : ITestTheme
{
    public string SourceColor => "#E85DAE"; //Magenta
    public bool IsDark => true;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#FFC0DD";
    public string OnPrimary => "#612A49";
    public string PrimaryContainer => "#F9ADD2";
    public string OnPrimaryContainer => "#56213F";

    public string Secondary => "#B0CCC8";
    public string OnSecondary => "#223B38";
    public string SecondaryContainer => "#607A76";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#89FFED";
    public string OnTertiary => "#00574E";
    public string TertiaryContainer => "#6EF2DF";
    public string OnTertiaryContainer => "#004E46";

    public string Error => "#FF9DA8";
    public string OnError => "#5F001C";
    public string ErrorContainer => "#C8475D";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#190911";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#DAACC1";

    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#200D17";
    public string SurfaceContainer => "#29121E";
    public string SurfaceContainerHigh => "#311725";
    public string SurfaceContainerHighest => "#3A1C2C";
}
