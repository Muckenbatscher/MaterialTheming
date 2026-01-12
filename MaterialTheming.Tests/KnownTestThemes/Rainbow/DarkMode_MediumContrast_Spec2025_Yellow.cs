using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Rainbow;

internal class DarkMode_MediumContrast_Spec2025_Yellow : ITestTheme
{
    public string SourceColor => "#B2B037"; //Yellow
    public bool IsDark => true;
    public Variant Variant => Variant.Rainbow;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#E4E269";
    public string OnPrimary => "#282700";
    public string PrimaryContainer => "#979523";
    public string OnPrimaryContainer => "#000000";

    public string Secondary => "#E1DEB9";
    public string OnSecondary => "#27270E";
    public string SecondaryContainer => "#949271";
    public string OnSecondaryContainer => "#000000";

    public string Tertiary => "#BAE6D1";
    public string OnTertiary => "#002C1F";
    public string TertiaryContainer => "#709A87";
    public string OnTertiaryContainer => "#000000";

    public string Error => "#FFD2CC";
    public string OnError => "#540003";
    public string ErrorContainer => "#FF5449";
    public string OnErrorContainer => "#000000";

    public string Surface => "#131313";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#DCDCDC";

    public string SurfaceContainerLowest => "#070707";
    public string SurfaceContainerLow => "#1D1D1D";
    public string SurfaceContainer => "#282828";
    public string SurfaceContainerHigh => "#323232";
    public string SurfaceContainerHighest => "#3E3E3E";
}
