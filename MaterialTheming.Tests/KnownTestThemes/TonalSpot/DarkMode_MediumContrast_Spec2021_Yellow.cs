using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class DarkMode_MediumContrast_Spec2021_Yellow : ITestTheme
{
    public string SourceColor => "#B2B037"; //Yellow
    public bool IsDark => true;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#E3E089";
    public string OnPrimary => "#282700";
    public string PrimaryContainer => "#969445";
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

    public string Surface => "#14140C";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#E0DDCB";

    public string SurfaceContainerLowest => "#080803";
    public string SurfaceContainerLow => "#1E1E16";
    public string SurfaceContainer => "#292820";
    public string SurfaceContainerHigh => "#34332A";
    public string SurfaceContainerHighest => "#3F3E35";
}
