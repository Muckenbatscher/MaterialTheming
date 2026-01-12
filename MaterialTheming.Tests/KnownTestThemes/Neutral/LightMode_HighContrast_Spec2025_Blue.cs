using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class LightMode_HighContrast_Spec2025_Blue : ITestTheme
{
    public string SourceColor => "#185FAA"; //Blue
    public bool IsDark => false;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#1E242F";
    public string OnPrimary => "#D4DAE9";
    public string PrimaryContainer => "#4C525F";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#222429";
    public string OnSecondary => "#D9DAE0";
    public string SecondaryContainer => "#505258";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#21223A";
    public string OnTertiary => "#D8D7F8";
    public string TertiaryContainer => "#4F506B";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#4F0409";
    public string OnError => "#FFCFCB";
    public string ErrorContainer => "#8E3432";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#FCF8F9";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#232426";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F6F3F4";
    public string SurfaceContainer => "#F0EDEF";
    public string SurfaceContainerHigh => "#EAE7EA";
    public string SurfaceContainerHighest => "#E4E2E5";
}
