using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.FruitSalad;

internal class DarkMode_HighContrast_Spec2021_Purple : ITestTheme
{
    public string SourceColor => "#945CCD"; //Purple
    public bool IsDark => true;
    public Variant Variant => Variant.FruitSalad;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#EAF0FF";
    public string OnPrimary => "#000000";
    public string PrimaryContainer => "#A0C4FF";
    public string OnPrimaryContainer => "#000B1E";

    public string Secondary => "#EAF0FF";
    public string OnSecondary => "#000000";
    public string SecondaryContainer => "#A3C4FB";
    public string OnSecondaryContainer => "#000B1E";

    public string Tertiary => "#F9EBFF";
    public string OnTertiary => "#000000";
    public string TertiaryContainer => "#D7B6F5";
    public string OnTertiaryContainer => "#15002C";

    public string Error => "#FFECE9";
    public string OnError => "#000000";
    public string ErrorContainer => "#FFAEA4";
    public string OnErrorContainer => "#220001";

    public string Surface => "#16111B";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#FFFFFF";

    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#231D28";
    public string SurfaceContainer => "#342E39";
    public string SurfaceContainerHigh => "#3F3944";
    public string SurfaceContainerHighest => "#4B4450";
}
