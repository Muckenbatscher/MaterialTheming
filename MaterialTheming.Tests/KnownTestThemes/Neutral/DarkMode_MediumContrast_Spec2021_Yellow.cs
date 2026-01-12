using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class DarkMode_MediumContrast_Spec2021_Yellow : ITestTheme
{
    public string SourceColor => "#B2B037"; //Yellow
    public bool IsDark => true;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#E0DDC2";
    public string OnPrimary => "#272615";
    public string PrimaryContainer => "#94927A";
    public string OnPrimaryContainer => "#000000";

    public string Secondary => "#E0DDCB";
    public string OnSecondary => "#27261B";
    public string SecondaryContainer => "#939181";
    public string OnSecondaryContainer => "#000000";

    public string Tertiary => "#E1DEB9";
    public string OnTertiary => "#27270E";
    public string TertiaryContainer => "#949271";
    public string OnTertiaryContainer => "#000000";

    public string Error => "#FFD2CC";
    public string OnError => "#540003";
    public string ErrorContainer => "#FF5449";
    public string OnErrorContainer => "#000000";

    public string Surface => "#141311";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#DFDCD7";

    public string SurfaceContainerLowest => "#080706";
    public string SurfaceContainerLow => "#1E1E1B";
    public string SurfaceContainer => "#292825";
    public string SurfaceContainerHigh => "#333230";
    public string SurfaceContainerHighest => "#3F3D3B";
}
