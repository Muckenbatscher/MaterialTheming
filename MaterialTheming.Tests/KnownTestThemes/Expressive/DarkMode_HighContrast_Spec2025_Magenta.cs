using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class DarkMode_HighContrast_Spec2025_Magenta : ITestTheme
{
    public string SourceColor => "#E85DAE"; //Magenta
    public bool IsDark => true;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#FFDCEA";
    public string OnPrimary => "#4C1937";
    public string PrimaryContainer => "#F9ADD2";
    public string OnPrimaryContainer => "#230015";

    public string Secondary => "#CFEBE7";
    public string OnSecondary => "#17302E";
    public string SecondaryContainer => "#8EA9A5";
    public string OnSecondaryContainer => "#000000";

    public string Tertiary => "#89FFED";
    public string OnTertiary => "#003630";
    public string TertiaryContainer => "#6EF2DF";
    public string OnTertiaryContainer => "#002C27";

    public string Error => "#FFDDDF";
    public string OnError => "#5F001C";
    public string ErrorContainer => "#FF798C";
    public string OnErrorContainer => "#000000";

    public string Surface => "#190911";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#FFDCEA";

    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#200D17";
    public string SurfaceContainer => "#29121E";
    public string SurfaceContainerHigh => "#311725";
    public string SurfaceContainerHighest => "#3A1C2C";
}
