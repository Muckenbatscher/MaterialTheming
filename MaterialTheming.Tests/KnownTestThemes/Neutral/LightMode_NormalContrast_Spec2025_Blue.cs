using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class LightMode_NormalContrast_Spec2025_Blue : ITestTheme
{
    public string SourceColor => "#185FAA"; //Blue
    public bool IsDark => false;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#585F6B";
    public string OnPrimary => "#F6F7FF";
    public string PrimaryContainer => "#DCE2F2";
    public string OnPrimaryContainer => "#4B525E";

    public string Secondary => "#5D5F65";
    public string OnSecondary => "#F8F8FF";
    public string SecondaryContainer => "#E1E2E9";
    public string OnSecondaryContainer => "#505257";

    public string Tertiary => "#5C5D78";
    public string OnTertiary => "#FBF7FF";
    public string TertiaryContainer => "#DBDAFB";
    public string OnTertiaryContainer => "#4B4C67";

    public string Error => "#9F403D";
    public string OnError => "#FFF7F6";
    public string ErrorContainer => "#FE8983";
    public string OnErrorContainer => "#752121";

    public string Surface => "#FCF8F9";
    public string OnSurface => "#323235";
    public string OnSurfaceVariant => "#5F5F61";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F6F3F4";
    public string SurfaceContainer => "#F0EDEF";
    public string SurfaceContainerHigh => "#EAE7EA";
    public string SurfaceContainerHighest => "#E4E2E5";
}
