using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class LightMode_NormalContrast_Spec2025_Yellow : ITestTheme
{
    public string SourceColor => "#B2B037"; //Yellow
    public bool IsDark => false;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#3E3D00";
    public string OnPrimary => "#C6C44F";
    public string PrimaryContainer => "#EAE86E";
    public string OnPrimaryContainer => "#565400";

    public string Secondary => "#566483";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#D7E2FF";
    public string OnSecondaryContainer => "#435270";

    public string Tertiary => "#4061AF";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#9DB7FF";
    public string OnTertiaryContainer => "#01327E";

    public string Error => "#B23D21";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#FA7150";
    public string OnErrorContainer => "#671200";

    public string Surface => "#FFFBFF";
    public string OnSurface => "#3B3A00";
    public string OnSurfaceVariant => "#69670A";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFFCC6";
    public string SurfaceContainer => "#FAF7B0";
    public string SurfaceContainerHigh => "#F5F29B";
    public string SurfaceContainerHighest => "#EFED85";
}
