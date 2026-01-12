using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class DarkMode_MediumContrast_Spec2021_Red : ITestTheme
{
    public string SourceColor => "#D2463D"; //Red
    public bool IsDark => true;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#CEDCFF";
    public string OnPrimary => "#002453";
    public string PrimaryContainer => "#7191CE";
    public string OnPrimaryContainer => "#000000";

    public string Secondary => "#DAE1AB";
    public string OnSecondary => "#232804";
    public string SecondaryContainer => "#8E9565";
    public string OnSecondaryContainer => "#000000";

    public string Tertiary => "#BDE8B2";
    public string OnTertiary => "#072C09";
    public string TertiaryContainer => "#739B6C";
    public string OnTertiaryContainer => "#000000";

    public string Error => "#FFD2CC";
    public string OnError => "#540003";
    public string ErrorContainer => "#FF5449";
    public string OnErrorContainer => "#000000";

    public string Surface => "#1C110D";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#F6D5CA";

    public string SurfaceContainerLowest => "#0E0603";
    public string SurfaceContainerLow => "#271B16";
    public string SurfaceContainer => "#322520";
    public string SurfaceContainerHigh => "#3D302B";
    public string SurfaceContainerHighest => "#493A35";
}
