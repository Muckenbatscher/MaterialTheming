using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class DarkMode_NormalContrast_Spec2025_Red : ITestTheme
{
    public string SourceColor => "#D2463D"; //Red
    public bool IsDark => true;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#FF8E82";
    public string OnPrimary => "#650005";
    public string PrimaryContainer => "#FF766A";
    public string OnPrimaryContainer => "#4F0003";

    public string Secondary => "#FD7E92";
    public string OnSecondary => "#57001B";
    public string SecondaryContainer => "#842137";
    public string OnSecondaryContainer => "#FFC0C7";

    public string Tertiary => "#D5A1FF";
    public string OnTertiary => "#4E137B";
    public string TertiaryContainer => "#CA90FA";
    public string OnTertiaryContainer => "#42006F";

    public string Error => "#FF6E84";
    public string OnError => "#490013";
    public string ErrorContainer => "#A70138";
    public string OnErrorContainer => "#FFB2B9";

    public string Surface => "#240209";
    public string OnSurface => "#FFDDE0";
    public string OnSurfaceVariant => "#DB9AA1";

    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#2C050D";
    public string SurfaceContainer => "#360812";
    public string SurfaceContainerHigh => "#3F0D18";
    public string SurfaceContainerHighest => "#48121D";
}
