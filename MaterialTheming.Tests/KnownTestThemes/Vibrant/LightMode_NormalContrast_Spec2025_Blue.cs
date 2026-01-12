using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class LightMode_NormalContrast_Spec2025_Blue : ITestTheme
{
    public string SourceColor => "#185FAA"; //Blue
    public bool IsDark => false;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#005CAB";
    public string OnPrimary => "#EEF2FF";
    public string PrimaryContainer => "#5BA2FF";
    public string OnPrimaryContainer => "#002347";

    public string Secondary => "#2656B7";
    public string OnSecondary => "#F1F2FF";
    public string SecondaryContainer => "#C2D1FF";
    public string OnSecondaryContainer => "#0041A0";

    public string Tertiary => "#823E9B";
    public string OnTertiary => "#FFEDFE";
    public string TertiaryContainer => "#E094F8";
    public string OnTertiaryContainer => "#52076C";

    public string Error => "#B31B25";
    public string OnError => "#FFEFEE";
    public string ErrorContainer => "#FB5151";
    public string OnErrorContainer => "#570008";

    public string Surface => "#F6F6FF";
    public string OnSurface => "#1F2D51";
    public string OnSurfaceVariant => "#4C5B81";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#EEF0FF";
    public string SurfaceContainer => "#E2E7FF";
    public string SurfaceContainerHigh => "#DAE2FF";
    public string SurfaceContainerHighest => "#D2DCFF";
}
