using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class LightMode_NormalContrast_Spec2025_Purple : ITestTheme
{
    public string SourceColor => "#945CCD"; //Purple
    public bool IsDark => false;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#754C9E";
    public string OnPrimary => "#FFF6FF";
    public string PrimaryContainer => "#D9B1FF";
    public string OnPrimaryContainer => "#502878";

    public string Secondary => "#4B6647";
    public string OnSecondary => "#EAFFE2";
    public string SecondaryContainer => "#D5F4CC";
    public string OnSecondaryContainer => "#435D3F";

    public string Tertiary => "#356B23";
    public string OnTertiary => "#ECFFDE";
    public string TertiaryContainer => "#BFFFA4";
    public string OnTertiaryContainer => "#2E641D";

    public string Error => "#AC3149";
    public string OnError => "#FFF7F7";
    public string ErrorContainer => "#F76A80";
    public string OnErrorContainer => "#68001F";

    public string Surface => "#FFF7FE";
    public string OnSurface => "#3D2A51";
    public string OnSurfaceVariant => "#6C5681";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FBF0FF";
    public string SurfaceContainer => "#F7E9FF";
    public string SurfaceContainerHigh => "#F4E2FF";
    public string SurfaceContainerHighest => "#F0DBFF";
}
