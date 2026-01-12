using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class LightMode_HighContrast_Spec2025_Yellow : ITestTheme
{
    public string SourceColor => "#B2B037"; //Yellow
    public bool IsDark => false;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#212100";
    public string OnPrimary => "#DEDB00";
    public string PrimaryContainer => "#525100";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#271F00";
    public string OnSecondary => "#F7D239";
    public string SecondaryContainer => "#5E4D00";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#2A1D00";
    public string OnTertiary => "#FFCE5E";
    public string TertiaryContainer => "#654A00";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#440800";
    public string OnError => "#FFC8BB";
    public string ErrorContainer => "#991F00";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#FFF6E1";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#271F00";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFF0C4";
    public string SurfaceContainer => "#FFE796";
    public string SurfaceContainerHigh => "#FAE18C";
    public string SurfaceContainerHighest => "#F5DC81";
}
