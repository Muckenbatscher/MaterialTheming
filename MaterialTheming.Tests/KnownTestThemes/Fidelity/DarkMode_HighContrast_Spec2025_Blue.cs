using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Fidelity;

internal class DarkMode_HighContrast_Spec2025_Blue : ITestTheme
{
    public string SourceColor => "#185FAA"; //Blue
    public bool IsDark => true;
    public Variant Variant => Variant.Fidelity;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#EAF0FF";
    public string OnPrimary => "#000000";
    public string PrimaryContainer => "#9FC4FF";
    public string OnPrimaryContainer => "#000B1E";

    public string Secondary => "#EAF0FF";
    public string OnSecondary => "#000000";
    public string SecondaryContainer => "#B0C4E7";
    public string OnSecondaryContainer => "#000B1E";

    public string Tertiary => "#FFECE2";
    public string OnTertiary => "#000000";
    public string TertiaryContainer => "#FFB17B";
    public string OnTertiaryContainer => "#180700";

    public string Error => "#FFECE9";
    public string OnError => "#000000";
    public string ErrorContainer => "#FFAEA4";
    public string OnErrorContainer => "#220001";

    public string Surface => "#111318";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#FFFFFF";

    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#1D2025";
    public string SurfaceContainer => "#2E3036";
    public string SurfaceContainerHigh => "#393B41";
    public string SurfaceContainerHighest => "#44474C";
}
