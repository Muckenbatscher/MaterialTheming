using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class LightMode_HighContrast_Spec2025_Yellow : ITestTheme
{
    public string SourceColor => "#B2B037"; //Yellow
    public bool IsDark => false;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#2C2C00";
    public string OnPrimary => "#EAE86E";
    public string PrimaryContainer => "#5B5A00";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#1B2A46";
    public string OnSecondary => "#D7E2FF";
    public string SecondaryContainer => "#495776";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#002665";
    public string OnTertiary => "#DAE2FF";
    public string TertiaryContainer => "#3254A1";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#570D00";
    public string OnError => "#FFDAD2";
    public string ErrorContainer => "#9F3015";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#FFFBFF";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#2C2C00";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFFCC6";
    public string SurfaceContainer => "#FAF7B0";
    public string SurfaceContainerHigh => "#F5F29B";
    public string SurfaceContainerHighest => "#EFED85";
}
