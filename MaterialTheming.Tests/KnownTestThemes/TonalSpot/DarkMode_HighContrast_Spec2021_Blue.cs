using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class DarkMode_HighContrast_Spec2021_Blue : ITestTheme
{
    public string SourceColor => "#185FAA"; //Blue
    public bool IsDark => true;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#EAF0FF";
    public string OnPrimary => "#000000";
    public string PrimaryContainer => "#A2C4FB";
    public string OnPrimaryContainer => "#000B1E";

    public string Secondary => "#EAF0FF";
    public string OnSecondary => "#000000";
    public string SecondaryContainer => "#B9C3D8";
    public string OnSecondaryContainer => "#020B1A";

    public string Tertiary => "#FDEAFF";
    public string OnTertiary => "#000000";
    public string TertiaryContainer => "#D6B9DE";
    public string OnTertiaryContainer => "#15041E";

    public string Error => "#FFECE9";
    public string OnError => "#000000";
    public string ErrorContainer => "#FFAEA4";
    public string OnErrorContainer => "#220001";

    public string Surface => "#111318";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#FFFFFF";

    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#1D2024";
    public string SurfaceContainer => "#2E3035";
    public string SurfaceContainerHigh => "#393B41";
    public string SurfaceContainerHighest => "#45474C";
}
