using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Fidelity;

internal class LightMode_MediumContrast_Spec2025_Red : ITestTheme
{
    public string SourceColor => "#D2463D"; //Red
    public bool IsDark => false;
    public Variant Variant => Variant.Fidelity;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#740006";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#C43C34";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#60221D";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#A4574F";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#003D42";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#007982";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#740006";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#CF2C27";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#FFF8F7";
    public string OnSurface => "#1A0E0D";
    public string OnSurfaceVariant => "#47312E";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFF0EE";
    public string SurfaceContainer => "#FCE2DF";
    public string SurfaceContainerHigh => "#F0D7D4";
    public string SurfaceContainerHighest => "#E5CCC9";
}
