using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class LightMode_NormalContrast_Spec2025_Purple : ITestTheme
{
    public string SourceColor => "#945CCD"; //Purple
    public bool IsDark => false;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#7E2CCA";
    public string OnPrimary => "#FBEFFF";
    public string PrimaryContainer => "#C185FF";
    public string OnPrimaryContainer => "#360062";

    public string Secondary => "#803E9D";
    public string OnSecondary => "#FFEDFF";
    public string SecondaryContainer => "#F0C1FF";
    public string OnSecondaryContainer => "#6A2887";

    public string Tertiary => "#A03648";
    public string OnTertiary => "#FFEFEF";
    public string TertiaryContainer => "#FF909D";
    public string OnTertiaryContainer => "#650620";

    public string Error => "#B41340";
    public string OnError => "#FFEFEF";
    public string ErrorContainer => "#F74B6D";
    public string OnErrorContainer => "#510017";

    public string Surface => "#FFF3FD";
    public string OnSurface => "#3E2548";
    public string OnSurfaceVariant => "#6E5178";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FEEBFF";
    public string SurfaceContainer => "#FAE0FF";
    public string SurfaceContainerHigh => "#F8D8FF";
    public string SurfaceContainerHighest => "#F5D1FF";
}
