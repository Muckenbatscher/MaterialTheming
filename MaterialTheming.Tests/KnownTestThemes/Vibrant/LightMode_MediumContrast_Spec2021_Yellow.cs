using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class LightMode_MediumContrast_Spec2021_Yellow : ITestTheme
{
    public string SourceColor => "#B2B037"; //Yellow
    public bool IsDark => false;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#393800";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#727000";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#323A14";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#687146";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#243D10";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#597542";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#740006";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#CF2C27";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#FEFAE3";
    public string OnSurface => "#121205";
    public string OnSurfaceVariant => "#383724";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F8F4DD";
    public string SurfaceContainer => "#ECE9D2";
    public string SurfaceContainerHigh => "#E1DEC7";
    public string SurfaceContainerHighest => "#D5D2BC";
}
