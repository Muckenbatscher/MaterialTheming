using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class LightMode_MediumContrast_Spec2025 : ITestTheme
{
    public string SourceColor => "#338745"; //green
    public bool IsDark => false;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#214B28";
    public string OnPrimary => "#B5E6B5";
    public string PrimaryContainer => "#537F56";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#364736";
    public string OnSecondary => "#CBDFC8";
    public string SecondaryContainer => "#677966";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#404616";
    public string OnTertiary => "#D8DF9F";
    public string TertiaryContainer => "#727943";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#801F07";
    public string OnError => "#FFCFC4";
    public string ErrorContainer => "#C44F34";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#F8FAF3";
    public string OnSurface => "#1F261E";
    public string OnSurfaceVariant => "#3D453C";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F1F5EC";
    public string SurfaceContainer => "#EAF0E6";
    public string SurfaceContainerHigh => "#E4EADF";
    public string SurfaceContainerHighest => "#DDE5D9";
}
