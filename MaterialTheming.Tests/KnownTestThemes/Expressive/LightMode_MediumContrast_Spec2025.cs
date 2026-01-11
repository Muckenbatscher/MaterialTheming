using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class LightMode_MediumContrast_Spec2025 : ITestTheme
{
    public string SourceColor => "#945CCD"; //purple
    public bool IsDark => false;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#572F7F";
    public string OnPrimary => "#EAD0FF";
    public string PrimaryContainer => "#8B62B5";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#30492C";
    public string OnSecondary => "#C4E2BB";
    public string SecondaryContainer => "#607C5B";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#174D06";
    public string OnTertiary => "#ACEA92";
    public string TertiaryContainer => "#4A8237";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#85112F";
    public string OnError => "#FFCDD1";
    public string ErrorContainer => "#C8475D";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#FFF7FE";
    public string OnSurface => "#2E1B41";
    public string OnSurfaceVariant => "#4E3A62";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FBF0FF";
    public string SurfaceContainer => "#F7E9FF";
    public string SurfaceContainerHigh => "#F4E2FF";
    public string SurfaceContainerHighest => "#F0DBFF";
}
