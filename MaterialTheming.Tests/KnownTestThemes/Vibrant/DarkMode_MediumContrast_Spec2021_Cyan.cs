using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class DarkMode_MediumContrast_Spec2021_Cyan : ITestTheme
{
    public string SourceColor => "#00BCD1"; //Cyan
    public bool IsDark => true;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#7CECFF";
    public string OnPrimary => "#002A30";
    public string PrimaryContainer => "#009FB1";
    public string OnPrimaryContainer => "#000000";

    public string Secondary => "#BBE2F6";
    public string OnSecondary => "#002937";
    public string SecondaryContainer => "#7196A8";
    public string OnSecondaryContainer => "#000000";

    public string Tertiary => "#C0E0FF";
    public string OnTertiary => "#002840";
    public string TertiaryContainer => "#6A95BA";
    public string OnTertiaryContainer => "#000000";

    public string Error => "#FFD2CC";
    public string OnError => "#540003";
    public string ErrorContainer => "#FF5449";
    public string OnErrorContainer => "#000000";

    public string Surface => "#091517";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#CEDFE3";

    public string SurfaceContainerLowest => "#01090B";
    public string SurfaceContainerLow => "#131F22";
    public string SurfaceContainer => "#1E2A2C";
    public string SurfaceContainerHigh => "#283537";
    public string SurfaceContainerHighest => "#334042";
}
