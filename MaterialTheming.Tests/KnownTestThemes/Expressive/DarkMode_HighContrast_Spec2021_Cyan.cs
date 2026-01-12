using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class DarkMode_HighContrast_Spec2021_Cyan : ITestTheme
{
    public string SourceColor => "#00BCD1"; //Cyan
    public bool IsDark => true;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#FFEECB";
    public string OnPrimary => "#000000";
    public string PrimaryContainer => "#E3BF5E";
    public string OnPrimaryContainer => "#100A00";

    public string Secondary => "#F5EDFF";
    public string OnSecondary => "#000000";
    public string SecondaryContainer => "#CABCE4";
    public string OnSecondaryContainer => "#0F0524";

    public string Tertiary => "#DCF4FF";
    public string OnTertiary => "#000000";
    public string TertiaryContainer => "#8FCBE4";
    public string OnTertiaryContainer => "#000D13";

    public string Error => "#FFECE9";
    public string OnError => "#000000";
    public string ErrorContainer => "#FFAEA4";
    public string OnErrorContainer => "#220001";

    public string Surface => "#0D1418";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#FFFFFF";

    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#192124";
    public string SurfaceContainer => "#2A3235";
    public string SurfaceContainerHigh => "#353D40";
    public string SurfaceContainerHighest => "#40484C";
}
