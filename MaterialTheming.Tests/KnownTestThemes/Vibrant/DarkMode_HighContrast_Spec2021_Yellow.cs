using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class DarkMode_HighContrast_Spec2021_Yellow : ITestTheme
{
    public string SourceColor => "#B2B037"; //Yellow
    public bool IsDark => true;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#FAF700";
    public string OnPrimary => "#000000";
    public string PrimaryContainer => "#CBC800";
    public string OnPrimaryContainer => "#0C0C00";

    public string Secondary => "#EBF5BF";
    public string OnSecondary => "#000000";
    public string SecondaryContainer => "#BEC895";
    public string OnSecondaryContainer => "#090D00";

    public string Tertiary => "#DAFABB";
    public string OnTertiary => "#000000";
    public string TertiaryContainer => "#ADCC91";
    public string OnTertiaryContainer => "#040E00";

    public string Error => "#FFECE9";
    public string OnError => "#000000";
    public string ErrorContainer => "#FFAEA4";
    public string OnErrorContainer => "#220001";

    public string Surface => "#141407";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#FFFFFF";

    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#212012";
    public string SurfaceContainer => "#323122";
    public string SurfaceContainerHigh => "#3D3C2C";
    public string SurfaceContainerHighest => "#484737";
}
