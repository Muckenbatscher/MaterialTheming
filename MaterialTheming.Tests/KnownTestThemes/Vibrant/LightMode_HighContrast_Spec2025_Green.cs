using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class LightMode_HighContrast_Spec2025_Green : ITestTheme
{
    public string SourceColor => "#338745"; //Green
    public bool IsDark => false;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#00260A";
    public string OnPrimary => "#57F17B";
    public string PrimaryContainer => "#005C23";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#002513";
    public string OnSecondary => "#6EECA7";
    public string SecondaryContainer => "#005B36";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#002429";
    public string OnTertiary => "#54E7FF";
    public string TertiaryContainer => "#005763";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#440800";
    public string OnError => "#FFC8BB";
    public string ErrorContainer => "#991F00";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#DCFFE5";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#002513";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#C7FDD8";
    public string SurfaceContainer => "#BBF6CE";
    public string SurfaceContainerHigh => "#B2F1C7";
    public string SurfaceContainerHighest => "#A8ECC0";
}
