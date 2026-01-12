using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class DarkMode_HighContrast_Spec2021_Yellow : ITestTheme
{
    public string SourceColor => "#B2B037"; //Yellow
    public bool IsDark => true;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#F7F49A";
    public string OnPrimary => "#000000";
    public string PrimaryContainer => "#C9C772";
    public string OnPrimaryContainer => "#0C0C00";

    public string Secondary => "#F5F2CC";
    public string OnSecondary => "#000000";
    public string SecondaryContainer => "#C7C4A1";
    public string OnSecondaryContainer => "#0C0C00";

    public string Tertiary => "#CDFAE5";
    public string OnTertiary => "#000000";
    public string TertiaryContainer => "#A1CCB8";
    public string OnTertiaryContainer => "#000E08";

    public string Error => "#FFECE9";
    public string OnError => "#000000";
    public string ErrorContainer => "#FFAEA4";
    public string OnErrorContainer => "#220001";

    public string Surface => "#14140C";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#FFFFFF";

    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#202018";
    public string SurfaceContainer => "#313128";
    public string SurfaceContainerHigh => "#3D3C32";
    public string SurfaceContainerHighest => "#48473D";
}
