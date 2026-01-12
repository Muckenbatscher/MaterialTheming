using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class DarkMode_HighContrast_Spec2025_Purple : ITestTheme
{
    public string SourceColor => "#945CCD"; //Purple
    public bool IsDark => true;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#F2DFFF";
    public string OnPrimary => "#352546";
    public string PrimaryContainer => "#B19BC5";
    public string OnPrimaryContainer => "#000000";

    public string Secondary => "#F0E0F9";
    public string OnSecondary => "#32283B";
    public string SecondaryContainer => "#AD9FB6";
    public string OnSecondaryContainer => "#000000";

    public string Tertiary => "#FFDCEA";
    public string OnTertiary => "#461F34";
    public string TertiaryContainer => "#F7BBD7";
    public string OnTertiaryContainer => "#2E0A1F";

    public string Error => "#FFDDDF";
    public string OnError => "#5F001C";
    public string ErrorContainer => "#FF798C";
    public string OnErrorContainer => "#000000";

    public string Surface => "#100D11";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#ECE2EE";

    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#151218";
    public string SurfaceContainer => "#1C181F";
    public string SurfaceContainerHigh => "#221E25";
    public string SurfaceContainerHighest => "#29242D";
}
