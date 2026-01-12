using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class DarkMode_MediumContrast_Spec2025_Green : ITestTheme
{
    public string SourceColor => "#338745"; //Green
    public bool IsDark => true;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#ABD0AA";
    public string OnPrimary => "#1D3D22";
    public string PrimaryContainer => "#5B7D5C";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#B8CCB5";
    public string OnSecondary => "#2A3A2A";
    public string SecondaryContainer => "#677966";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#F8FFBC";
    public string OnTertiary => "#525927";
    public string TertiaryContainer => "#E9F0AF";
    public string OnTertiaryContainer => "#4A511F";

    public string Error => "#FFA089";
    public string OnError => "#5A0E00";
    public string ErrorContainer => "#C44F34";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#0C0F0B";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#B3BBB0";

    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#101510";
    public string SurfaceContainer => "#151B15";
    public string SurfaceContainerHigh => "#1B211B";
    public string SurfaceContainerHighest => "#202820";
}
