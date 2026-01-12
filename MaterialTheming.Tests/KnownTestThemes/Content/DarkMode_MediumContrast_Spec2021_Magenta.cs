using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Content;

internal class DarkMode_MediumContrast_Spec2021_Magenta : ITestTheme
{
    public string SourceColor => "#E85DAE"; //Magenta
    public bool IsDark => true;
    public Variant Variant => Variant.Content;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#FFCFE4";
    public string OnPrimary => "#4E0035";
    public string PrimaryContainer => "#E85DAE";
    public string OnPrimaryContainer => "#000000";

    public string Secondary => "#FFCFE4";
    public string OnSecondary => "#461031";
    public string SecondaryContainer => "#C37A9F";
    public string OnSecondaryContainer => "#000000";

    public string Tertiary => "#FFD2C9";
    public string OnTertiary => "#510700";
    public string TertiaryContainer => "#F36145";
    public string OnTertiaryContainer => "#000000";

    public string Error => "#FFD2CC";
    public string OnError => "#540003";
    public string ErrorContainer => "#FF5449";
    public string OnErrorContainer => "#000000";

    public string Surface => "#1B1015";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#F1D5E0";

    public string SurfaceContainerLowest => "#0D0509";
    public string SurfaceContainerLow => "#261A1F";
    public string SurfaceContainer => "#30252A";
    public string SurfaceContainerHigh => "#3C2F35";
    public string SurfaceContainerHighest => "#473A40";
}
