using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class LightMode_MediumContrast_Spec2025_Orange : ITestTheme
{
    public string SourceColor => "#D77837"; //Orange
    public bool IsDark => false;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#673615";
    public string OnPrimary => "#FFD0B6";
    public string PrimaryContainer => "#A26641";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#573D2D";
    public string OnSecondary => "#F9D2BC";
    public string SecondaryContainer => "#8E6E5C";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#4E420C";
    public string OnTertiary => "#EBD995";
    public string TertiaryContainer => "#82743A";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#801F07";
    public string OnError => "#FFCFC4";
    public string ErrorContainer => "#C44F34";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#FFF8F5";
    public string OnSurface => "#2E211A";
    public string OnSurfaceVariant => "#4F4038";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFF1EA";
    public string SurfaceContainer => "#FEEAE0";
    public string SurfaceContainerHigh => "#F9E4DA";
    public string SurfaceContainerHighest => "#F5DED2";
}
