using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Content;

internal class LightMode_NormalContrast_Spec2025_Blue : ITestTheme
{
    public string SourceColor => "#185FAA"; //Blue
    public bool IsDark => false;
    public Variant Variant => Variant.Content;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#004787";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#185FAA";
    public string OnPrimaryContainer => "#C5DAFF";

    public string Secondary => "#4C5F7E";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#C7DBFF";
    public string OnSecondaryContainer => "#4C607F";

    public string Tertiary => "#672D7B";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#814695";
    public string OnTertiaryContainer => "#F6CAFF";

    public string Error => "#BA1A1A";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#FFDAD6";
    public string OnErrorContainer => "#93000A";

    public string Surface => "#F9F9FF";
    public string OnSurface => "#191C21";
    public string OnSurfaceVariant => "#424751";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F2F3FA";
    public string SurfaceContainer => "#EDEDF4";
    public string SurfaceContainerHigh => "#E7E8EF";
    public string SurfaceContainerHighest => "#E1E2E9";
}
