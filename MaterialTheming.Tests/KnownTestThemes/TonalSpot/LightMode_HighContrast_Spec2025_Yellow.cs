using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class LightMode_HighContrast_Spec2025_Yellow : ITestTheme
{
    public string SourceColor => "#B2B037"; //Yellow
    public bool IsDark => false;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#2C2C00";
    public string OnPrimary => "#E9E698";
    public string PrimaryContainer => "#5B5A1B";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#2C2B12";
    public string OnSecondary => "#E7E4BF";
    public string SecondaryContainer => "#5A593C";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#3B2600";
    public string OnTertiary => "#FFDDAD";
    public string TertiaryContainer => "#70521F";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#570D00";
    public string OnError => "#FFDAD2";
    public string ErrorContainer => "#9C331A";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#FFFBFF";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#2B2B1E";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FDF9EB";
    public string SurfaceContainer => "#F8F4E4";
    public string SurfaceContainerHigh => "#F2EEDD";
    public string SurfaceContainerHighest => "#ECE9D5";
}
