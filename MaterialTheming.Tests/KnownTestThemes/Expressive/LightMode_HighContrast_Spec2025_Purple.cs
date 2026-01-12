using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class LightMode_HighContrast_Spec2025_Purple : ITestTheme
{
    public string SourceColor => "#945CCD"; //Purple
    public bool IsDark => false;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#36085E";
    public string OnPrimary => "#EAD0FF";
    public string PrimaryContainer => "#673F90";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#112910";
    public string OnSecondary => "#C4E3BC";
    public string SecondaryContainer => "#3F593B";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#062B00";
    public string OnTertiary => "#ACEB92";
    public string TertiaryContainer => "#285E16";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#500016";
    public string OnError => "#FFCED2";
    public string ErrorContainer => "#9A243D";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#FFF7FE";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#2E1B41";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FBF0FF";
    public string SurfaceContainer => "#F7E9FF";
    public string SurfaceContainerHigh => "#F4E2FF";
    public string SurfaceContainerHighest => "#F0DBFF";
}
