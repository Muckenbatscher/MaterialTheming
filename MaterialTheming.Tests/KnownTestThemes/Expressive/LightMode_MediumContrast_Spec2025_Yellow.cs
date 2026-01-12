using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class LightMode_MediumContrast_Spec2025_Yellow : ITestTheme
{
    public string SourceColor => "#B2B037"; //Yellow
    public bool IsDark => false;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#3E3D00";
    public string OnPrimary => "#D5D35C";
    public string PrimaryContainer => "#7A7800";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#394865";
    public string OnSecondary => "#D7E2FF";
    public string SecondaryContainer => "#667594";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#1F4491";
    public string OnTertiary => "#D9E1FF";
    public string TertiaryContainer => "#5272C1";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#8A2006";
    public string OnError => "#FFDAD1";
    public string ErrorContainer => "#C74C2F";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#FFFBFF";
    public string OnSurface => "#2C2C00";
    public string OnSurfaceVariant => "#4B4A00";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFFCC6";
    public string SurfaceContainer => "#FAF7B0";
    public string SurfaceContainerHigh => "#F5F29B";
    public string SurfaceContainerHighest => "#EFED85";
}
