using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class DarkMode_MediumContrast_Spec2021_Orange : ITestTheme
{
    public string SourceColor => "#D77837"; //Orange
    public bool IsDark => true;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#DDD8FF";
    public string OnPrimary => "#221B5B";
    public string PrimaryContainer => "#8F89CF";
    public string OnPrimaryContainer => "#000000";

    public string Secondary => "#C6E5BE";
    public string OnSecondary => "#132B11";
    public string SecondaryContainer => "#7C9876";
    public string OnSecondaryContainer => "#000000";

    public string Tertiary => "#A9EACE";
    public string OnTertiary => "#002C1F";
    public string TertiaryContainer => "#5E9D84";
    public string OnTertiaryContainer => "#000000";

    public string Error => "#FFD2CC";
    public string OnError => "#540003";
    public string ErrorContainer => "#FF5449";
    public string OnErrorContainer => "#000000";

    public string Surface => "#1A1209";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#F2D8C1";

    public string SurfaceContainerLowest => "#0D0602";
    public string SurfaceContainerLow => "#251C13";
    public string SurfaceContainer => "#30261D";
    public string SurfaceContainerHigh => "#3B3127";
    public string SurfaceContainerHighest => "#473C31";
}
