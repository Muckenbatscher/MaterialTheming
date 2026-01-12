using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class LightMode_MediumContrast_Spec2021_Magenta : ITestTheme
{
    public string SourceColor => "#E85DAE"; //Magenta
    public bool IsDark => false;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#433139";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#7D6770";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#3F3338";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#78696F";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#472F3A";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#816572";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#740006";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#CF2C27";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#FFF8F8";
    public string OnSurface => "#131011";
    public string OnSurfaceVariant => "#393536";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F9F2F3";
    public string SurfaceContainer => "#EEE6E7";
    public string SurfaceContainerHigh => "#E2DBDC";
    public string SurfaceContainerHighest => "#D7D0D1";
}
