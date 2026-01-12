using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class LightMode_MediumContrast_Spec2021_Purple : ITestTheme
{
    public string SourceColor => "#945CCD"; //Purple
    public bool IsDark => false;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#442A5F";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#7E619A";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#3C3245";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#75697E";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#522A30";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#916066";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#740006";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#CF2C27";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#FFF7FE";
    public string OnSurface => "#131015";
    public string OnSurfaceVariant => "#39343D";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F9F1F9";
    public string SurfaceContainer => "#EEE6EE";
    public string SurfaceContainerHigh => "#E2DAE2";
    public string SurfaceContainerHighest => "#D7CFD7";
}
