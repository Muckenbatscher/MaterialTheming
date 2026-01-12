using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class LightMode_MediumContrast_Spec2025_Purple : ITestTheme
{
    public string SourceColor => "#945CCD"; //Purple
    public bool IsDark => false;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#503967";
    public string OnPrimary => "#EAD0FF";
    public string PrimaryContainer => "#846A9C";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#493F52";
    public string OnSecondary => "#E4D4ED";
    public string SecondaryContainer => "#7C7086";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#60354B";
    public string OnTertiary => "#FFCCE2";
    public string TertiaryContainer => "#98667E";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#821830";
    public string OnError => "#FFCDD1";
    public string ErrorContainer => "#C44B5F";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#FFF7FE";
    public string OnSurface => "#27222B";
    public string OnSurfaceVariant => "#46414A";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F9F1F9";
    public string SurfaceContainer => "#F4EBF5";
    public string SurfaceContainerHigh => "#EEE5F0";
    public string SurfaceContainerHighest => "#E9DFEB";
}
