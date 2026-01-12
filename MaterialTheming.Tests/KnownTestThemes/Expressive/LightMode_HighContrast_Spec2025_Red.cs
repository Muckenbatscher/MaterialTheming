using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class LightMode_HighContrast_Spec2025_Red : ITestTheme
{
    public string SourceColor => "#D2463D"; //Red
    public bool IsDark => false;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#4D0706";
    public string OnPrimary => "#FFCFC9";
    public string PrimaryContainer => "#8C362F";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#002834";
    public string OnSecondary => "#B8E0F2";
    public string SecondaryContainer => "#305766";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#002832";
    public string OnTertiary => "#95E6FF";
    public string TertiaryContainer => "#005A6D";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#500016";
    public string OnError => "#FFCED2";
    public string ErrorContainer => "#9A243D";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#FFF8F6";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#40170B";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFF1ED";
    public string SurfaceContainer => "#FFE9E4";
    public string SurfaceContainerHigh => "#FFE2DA";
    public string SurfaceContainerHighest => "#FFDBD1";
}
