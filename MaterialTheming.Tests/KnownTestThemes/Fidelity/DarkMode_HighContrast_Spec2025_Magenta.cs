using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Fidelity;

internal class DarkMode_HighContrast_Spec2025_Magenta : ITestTheme
{
    public string SourceColor => "#E85DAE"; //Magenta
    public bool IsDark => true;
    public Variant Variant => Variant.Fidelity;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#FFEBF2";
    public string OnPrimary => "#000000";
    public string PrimaryContainer => "#FFA9D4";
    public string OnPrimaryContainer => "#1F0013";

    public string Secondary => "#FFEBF2";
    public string OnSecondary => "#000000";
    public string SecondaryContainer => "#FBABD2";
    public string OnSecondaryContainer => "#1F0013";

    public string Tertiary => "#CBFFA7";
    public string OnTertiary => "#000000";
    public string TertiaryContainer => "#82D84F";
    public string OnTertiaryContainer => "#030E00";

    public string Error => "#FFECE9";
    public string OnError => "#000000";
    public string ErrorContainer => "#FFAEA4";
    public string OnErrorContainer => "#220001";

    public string Surface => "#1B1015";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#FFFFFF";

    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#281C22";
    public string SurfaceContainer => "#392D32";
    public string SurfaceContainerHigh => "#45383D";
    public string SurfaceContainerHighest => "#514349";
}
