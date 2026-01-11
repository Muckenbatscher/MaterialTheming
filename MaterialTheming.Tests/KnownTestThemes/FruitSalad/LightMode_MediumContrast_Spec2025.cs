using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.FruitSalad;

internal class LightMode_MediumContrast_Spec2025 : ITestTheme
{
    public string SourceColor => "#185FAA"; //blue
    public bool IsDark => false;
    public Variant Variant => Variant.FruitSalad;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#003C44";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#007886";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#003C44";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#187884";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#0C3765";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#4C6EA0";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#740006";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#CF2C27";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#F9F9FF";
    public string OnSurface => "#0C111A";
    public string OnSurfaceVariant => "#2D3747";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F0F3FF";
    public string SurfaceContainer => "#E4E8F4";
    public string SurfaceContainerHigh => "#D8DDE9";
    public string SurfaceContainerHighest => "#CDD1DE";
}
