using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class DarkMode_MediumContrast_Spec2021_Cyan : ITestTheme
{
    public string SourceColor => "#00BCD1"; //Cyan
    public bool IsDark => true;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#FED874";
    public string OnPrimary => "#302400";
    public string PrimaryContainer => "#AD8D31";
    public string OnPrimaryContainer => "#000000";

    public string Secondary => "#E4D6FF";
    public string OnSecondary => "#2A203F";
    public string SecondaryContainer => "#978BB0";
    public string OnSecondaryContainer => "#000000";

    public string Tertiary => "#A9E5FF";
    public string OnTertiary => "#002A36";
    public string TertiaryContainer => "#5D99B0";
    public string OnTertiaryContainer => "#000000";

    public string Error => "#FFD2CC";
    public string OnError => "#540003";
    public string ErrorContainer => "#FF5449";
    public string OnErrorContainer => "#000000";

    public string Surface => "#0D1418";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#D0DFE6";

    public string SurfaceContainerLowest => "#03080B";
    public string SurfaceContainerLow => "#171F22";
    public string SurfaceContainer => "#21292D";
    public string SurfaceContainerHigh => "#2C3437";
    public string SurfaceContainerHighest => "#373F43";
}
