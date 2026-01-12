using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class DarkMode_MediumContrast_Spec2021_Red : ITestTheme
{
    public string SourceColor => "#D2463D"; //Red
    public bool IsDark => true;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#FFD2CD";
    public string OnPrimary => "#540003";
    public string PrimaryContainer => "#FF544A";
    public string OnPrimaryContainer => "#000000";

    public string Secondary => "#FFD3C1";
    public string OnSecondary => "#3E1C0C";
    public string SecondaryContainer => "#B9856E";
    public string OnSecondaryContainer => "#000000";

    public string Tertiary => "#FFD4B3";
    public string OnTertiary => "#3D1E00";
    public string TertiaryContainer => "#BE8452";
    public string OnTertiaryContainer => "#000000";

    public string Error => "#FFD2CC";
    public string OnError => "#540003";
    public string ErrorContainer => "#FF5449";
    public string OnErrorContainer => "#000000";

    public string Surface => "#1E100E";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#F6D5D1";

    public string SurfaceContainerLowest => "#100504";
    public string SurfaceContainerLow => "#291A18";
    public string SurfaceContainer => "#342422";
    public string SurfaceContainerHigh => "#402E2C";
    public string SurfaceContainerHighest => "#4C3937";
}
