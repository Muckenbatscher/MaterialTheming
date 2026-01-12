using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class LightMode_MediumContrast_Spec2021_Yellow : ITestTheme
{
    public string SourceColor => "#B2B037"; //Yellow
    public bool IsDark => false;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#393800";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#717025";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#38371D";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#706E50";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#133D2F";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#4C7564";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#740006";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#CF2C27";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#FDF9EC";
    public string OnSurface => "#12110A";
    public string OnSurfaceVariant => "#37372A";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F7F4E6";
    public string SurfaceContainer => "#ECE8DB";
    public string SurfaceContainerHigh => "#E0DDD0";
    public string SurfaceContainerHighest => "#D5D2C5";
}
