using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Rainbow;

internal class LightMode_NormalContrast_Spec2025 : ITestTheme
{
    public string SourceColor => "#D77837"; //orange
    public bool IsDark => false;
    public Variant Variant => Variant.Rainbow;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#96490B";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#FFDBC8";
    public string OnPrimaryContainer => "#743400";

    public string Secondary => "#765847";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#FFDBC8";
    public string OnSecondaryContainer => "#5C4131";

    public string Tertiary => "#626033";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#E8E5AC";
    public string OnTertiaryContainer => "#49491E";

    public string Error => "#BA1A1A";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#FFDAD6";
    public string OnErrorContainer => "#93000A";

    public string Surface => "#F9F9F9";
    public string OnSurface => "#1B1B1B";
    public string OnSurfaceVariant => "#474747";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F3F3F3";
    public string SurfaceContainer => "#EEEEEE";
    public string SurfaceContainerHigh => "#E8E8E8";
    public string SurfaceContainerHighest => "#E2E2E2";
}
