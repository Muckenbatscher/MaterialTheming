using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class LightMode_MediumContrast_Spec2025_Yellow : ITestTheme
{
    public string SourceColor => "#B2B037"; //Yellow
    public bool IsDark => false;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#4B4A0C";
    public string OnPrimary => "#E8E698";
    public string PrimaryContainer => "#797736";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#4A492E";
    public string OnSecondary => "#E7E4BE";
    public string SecondaryContainer => "#777657";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#5F4311";
    public string OnTertiary => "#FFDDAC";
    public string TertiaryContainer => "#906F39";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#87240C";
    public string OnError => "#FFDAD1";
    public string ErrorContainer => "#C44F34";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#FFFBFF";
    public string OnSurface => "#2B2B1E";
    public string OnSurfaceVariant => "#4A483A";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FDF9EB";
    public string SurfaceContainer => "#F8F4E4";
    public string SurfaceContainerHigh => "#F2EEDD";
    public string SurfaceContainerHighest => "#ECE9D5";
}
