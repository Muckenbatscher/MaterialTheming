using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class LightMode_MediumContrast_Spec2025_Orange : ITestTheme
{
    public string SourceColor => "#D77837"; //Orange
    public bool IsDark => false;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#4E4038";
    public string OnPrimary => "#EBD5CB";
    public string PrimaryContainer => "#827168";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#49413E";
    public string OnSecondary => "#E3D7D2";
    public string SecondaryContainer => "#7C736E";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#543F1F";
    public string OnTertiary => "#F5D5A9";
    public string TertiaryContainer => "#8A704C";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#792713";
    public string OnError => "#FFCFC4";
    public string ErrorContainer => "#BA573F";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#FFF8F6";
    public string OnSurface => "#282320";
    public string OnSurfaceVariant => "#48423F";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FAF2EF";
    public string SurfaceContainer => "#F5ECE9";
    public string SurfaceContainerHigh => "#F0E6E2";
    public string SurfaceContainerHighest => "#EBE0DC";
}
