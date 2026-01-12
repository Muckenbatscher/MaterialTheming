using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.FruitSalad;

internal class DarkMode_MediumContrast_Spec2025_Orange : ITestTheme
{
    public string SourceColor => "#D77837"; //Orange
    public bool IsDark => true;
    public Variant Variant => Variant.FruitSalad;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#FFD0DC";
    public string OnPrimary => "#4F0328";
    public string PrimaryContainer => "#D57193";
    public string OnPrimaryContainer => "#000000";

    public string Secondary => "#FFD0DC";
    public string OnSecondary => "#471227";
    public string SecondaryContainer => "#C67B92";
    public string OnSecondaryContainer => "#000000";

    public string Tertiary => "#FFD3BB";
    public string OnTertiary => "#411A00";
    public string TertiaryContainer => "#C78053";
    public string OnTertiaryContainer => "#000000";

    public string Error => "#FFD2CC";
    public string OnError => "#540003";
    public string ErrorContainer => "#FF5449";
    public string OnErrorContainer => "#000000";

    public string Surface => "#1D1009";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#FCD4BE";

    public string SurfaceContainerLowest => "#0F0502";
    public string SurfaceContainerLow => "#281B12";
    public string SurfaceContainer => "#33251C";
    public string SurfaceContainerHigh => "#3F2F26";
    public string SurfaceContainerHighest => "#4B3A31";
}
