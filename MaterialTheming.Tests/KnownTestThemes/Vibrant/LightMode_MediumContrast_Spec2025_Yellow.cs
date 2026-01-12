using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class LightMode_MediumContrast_Spec2025_Yellow : ITestTheme
{
    public string SourceColor => "#B2B037"; //Yellow
    public bool IsDark => false;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#424100";
    public string OnPrimary => "#DDDA00";
    public string PrimaryContainer => "#7A7800";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#4C3E00";
    public string OnSecondary => "#F6D239";
    public string SecondaryContainer => "#8A7300";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#523C00";
    public string OnTertiary => "#FFCD5B";
    public string TertiaryContainer => "#946F00";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#7D1800";
    public string OnError => "#FFC7BA";
    public string ErrorContainer => "#D53D18";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#FFF6E1";
    public string OnSurface => "#271F00";
    public string OnSurfaceVariant => "#4B3E08";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFF0C4";
    public string SurfaceContainer => "#FFE796";
    public string SurfaceContainerHigh => "#FAE18C";
    public string SurfaceContainerHighest => "#F5DC81";
}
