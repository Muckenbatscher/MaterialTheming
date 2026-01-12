using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.FruitSalad;

internal class LightMode_NormalContrast_Spec2021_Blue : ITestTheme
{
    public string SourceColor => "#185FAA"; //Blue
    public bool IsDark => false;
    public Variant Variant => Variant.FruitSalad;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#006874";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#98F0FF";
    public string OnPrimaryContainer => "#004F58";

    public string Secondary => "#006874";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#9EEFFD";
    public string OnSecondaryContainer => "#004F58";

    public string Tertiary => "#3D5F90";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#D5E3FF";
    public string OnTertiaryContainer => "#234776";

    public string Error => "#BA1A1A";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#FFDAD6";
    public string OnErrorContainer => "#93000A";

    public string Surface => "#F9F9FF";
    public string OnSurface => "#171C24";
    public string OnSurfaceVariant => "#3D4758";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F0F3FF";
    public string SurfaceContainer => "#E9EEFA";
    public string SurfaceContainerHigh => "#E4E8F4";
    public string SurfaceContainerHighest => "#DEE2EF";
}
