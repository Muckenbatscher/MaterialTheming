using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class LightMode_HighContrast_Spec2021 : ITestTheme
{
    public string SourceColor => "#B2B037"; //yellow
    public bool IsDark => false;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#2E2E00";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#4D4C00";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#282F0B";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#444D25";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#1A3206";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#365021";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#600004";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#98000A";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#FEFAE3";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#000000";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F5F1DA";
    public string SurfaceContainer => "#E6E3CD";
    public string SurfaceContainerHigh => "#D8D5BF";
    public string SurfaceContainerHighest => "#CAC7B1";
}
