using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class LightMode_HighContrast_Spec2021_Magenta : ITestTheme
{
    public string SourceColor => "#E85DAE"; //Magenta
    public bool IsDark => false;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#003041";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#004F68";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#472217";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#693E31";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#2F2E00";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#4D4B0D";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#600004";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#98000A";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#FFF8F7";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#000000";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFECEE";
    public string SurfaceContainer => "#F3DDE0";
    public string SurfaceContainerHigh => "#E4CFD2";
    public string SurfaceContainerHighest => "#D6C2C4";
}
