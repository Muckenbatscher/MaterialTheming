using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.FruitSalad;

internal class DarkMode_HighContrast_Spec2025_Red : ITestTheme
{
    public string SourceColor => "#D2463D"; //Red
    public bool IsDark => true;
    public Variant Variant => Variant.FruitSalad;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#FFEAF7";
    public string OnPrimary => "#000000";
    public string PrimaryContainer => "#FBA7EF";
    public string OnPrimaryContainer => "#1D001C";

    public string Secondary => "#FFEAF7";
    public string OnSecondary => "#000000";
    public string SecondaryContainer => "#EDAFE2";
    public string OnSecondaryContainer => "#1D001C";

    public string Tertiary => "#FFECE9";
    public string OnTertiary => "#000000";
    public string TertiaryContainer => "#FFAEA5";
    public string OnTertiaryContainer => "#220001";

    public string Error => "#FFECE9";
    public string OnError => "#000000";
    public string ErrorContainer => "#FFAEA4";
    public string OnErrorContainer => "#220001";

    public string Surface => "#1E100E";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#FFFFFF";

    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#2B1C1A";
    public string SurfaceContainer => "#3D2C2A";
    public string SurfaceContainerHigh => "#493735";
    public string SurfaceContainerHighest => "#554240";
}
