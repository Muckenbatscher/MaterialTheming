using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Fidelity;

internal class LightMode_MediumContrast_Spec2025_Blue : ITestTheme
{
    public string SourceColor => "#185FAA"; //Blue
    public bool IsDark => false;
    public Variant Variant => Variant.Fidelity;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#003669";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#185FAA";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#233753";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#5A6E8D";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#582900";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#954A00";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#740006";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#CF2C27";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#F9F9FF";
    public string OnSurface => "#0F1116";
    public string OnSurfaceVariant => "#313640";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F2F3FA";
    public string SurfaceContainer => "#E7E8EF";
    public string SurfaceContainerHigh => "#DBDCE3";
    public string SurfaceContainerHighest => "#D0D1D8";
}
