using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Fidelity;

internal class LightMode_MediumContrast_Spec2021_Purple : ITestTheme
{
    public string SourceColor => "#945CCD"; //Purple
    public bool IsDark => false;
    public Variant Variant => Variant.Fidelity;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#4F0E86";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#8A52C2";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#422D57";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#7B6491";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#413500";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#806C00";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#740006";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#CF2C27";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#FFF7FE";
    public string OnSurface => "#131017";
    public string OnSurfaceVariant => "#3B3340";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FAF1FB";
    public string SurfaceContainer => "#EEE5F0";
    public string SurfaceContainerHigh => "#E3DAE4";
    public string SurfaceContainerHighest => "#D7CFD9";
}
