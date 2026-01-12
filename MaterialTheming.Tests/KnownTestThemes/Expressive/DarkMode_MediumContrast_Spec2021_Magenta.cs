using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class DarkMode_MediumContrast_Spec2021_Magenta : ITestTheme
{
    public string SourceColor => "#E85DAE"; //Magenta
    public bool IsDark => true;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#AFE4FF";
    public string OnPrimary => "#002938";
    public string PrimaryContainer => "#479ABD";
    public string OnPrimaryContainer => "#000000";

    public string Secondary => "#FFD3C6";
    public string OnSecondary => "#3F1C11";
    public string SecondaryContainer => "#BA8474";
    public string OnSecondaryContainer => "#000000";

    public string Tertiary => "#E3E093";
    public string OnTertiary => "#282700";
    public string TertiaryContainer => "#96944F";
    public string OnTertiaryContainer => "#000000";

    public string Error => "#FFD2CC";
    public string OnError => "#540003";
    public string ErrorContainer => "#FF5449";
    public string OnErrorContainer => "#000000";

    public string Surface => "#1B1013";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#F4D5DA";

    public string SurfaceContainerLowest => "#0E0507";
    public string SurfaceContainerLow => "#261B1D";
    public string SurfaceContainer => "#312527";
    public string SurfaceContainerHigh => "#3C2F32";
    public string SurfaceContainerHighest => "#483A3D";
}
