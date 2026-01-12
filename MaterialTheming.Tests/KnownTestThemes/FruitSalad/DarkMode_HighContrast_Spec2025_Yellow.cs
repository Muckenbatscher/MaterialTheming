using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.FruitSalad;

internal class DarkMode_HighContrast_Spec2025_Yellow : ITestTheme
{
    public string SourceColor => "#B2B037"; //Yellow
    public bool IsDark => true;
    public Variant Variant => Variant.FruitSalad;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#FFEDE0";
    public string OnPrimary => "#000000";
    public string PrimaryContainer => "#FFB26E";
    public string OnPrimaryContainer => "#160800";

    public string Secondary => "#FFEDE0";
    public string OnSecondary => "#000000";
    public string SecondaryContainer => "#FBB375";
    public string OnSecondaryContainer => "#160800";

    public string Tertiary => "#F7F49A";
    public string OnTertiary => "#000000";
    public string TertiaryContainer => "#C9C772";
    public string OnTertiaryContainer => "#0C0C00";

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
