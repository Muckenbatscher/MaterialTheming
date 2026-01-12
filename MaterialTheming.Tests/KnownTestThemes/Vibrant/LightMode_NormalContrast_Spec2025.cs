using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class LightMode_NormalContrast_Spec2025 : ITestTheme
{
    public string SourceColor => "#E85DAE"; //magenta
    public bool IsDark => false;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#A91C78";
    public string OnPrimary => "#FFEFF3";
    public string PrimaryContainer => "#FF6AC0";
    public string OnPrimaryContainer => "#490031";

    public string Secondary => "#8F3987";
    public string OnSecondary => "#FFEEF7";
    public string SecondaryContainer => "#FFBDF1";
    public string OnSecondaryContainer => "#772371";

    public string Tertiary => "#3E52B7";
    public string OnTertiary => "#F2F1FF";
    public string TertiaryContainer => "#9DABFF";
    public string OnTertiaryContainer => "#03228B";

    public string Error => "#B41340";
    public string OnError => "#FFEFEF";
    public string ErrorContainer => "#F74B6D";
    public string OnErrorContainer => "#510017";

    public string Surface => "#FFF3F8";
    public string OnSurface => "#452340";
    public string OnSurfaceVariant => "#764F6F";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFEBF7";
    public string SurfaceContainer => "#FFDFF5";
    public string SurfaceContainerHigh => "#FFD7F4";
    public string SurfaceContainerHighest => "#FFCEF3";
}
