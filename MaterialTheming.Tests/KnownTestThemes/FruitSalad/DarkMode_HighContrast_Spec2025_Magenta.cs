using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.FruitSalad;

internal class DarkMode_HighContrast_Spec2025_Magenta : ITestTheme
{
    public string SourceColor => "#E85DAE"; //Magenta
    public bool IsDark => true;
    public Variant Variant => Variant.FruitSalad;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#F5EDFF";
    public string OnPrimary => "#000000";
    public string PrimaryContainer => "#CDB7FF";
    public string OnPrimaryContainer => "#100032";

    public string Secondary => "#F5EDFF";
    public string OnSecondary => "#000000";
    public string SecondaryContainer => "#CCB8FA";
    public string OnSecondaryContainer => "#100032";

    public string Tertiary => "#FFEBF2";
    public string OnTertiary => "#000000";
    public string TertiaryContainer => "#F8ACD1";
    public string OnTertiaryContainer => "#1F0013";

    public string Error => "#FFECE9";
    public string OnError => "#000000";
    public string ErrorContainer => "#FFAEA4";
    public string OnErrorContainer => "#220001";

    public string Surface => "#1C1016";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#FFFFFF";

    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#291C22";
    public string SurfaceContainer => "#3B2C33";
    public string SurfaceContainerHigh => "#46373E";
    public string SurfaceContainerHighest => "#524249";
}
