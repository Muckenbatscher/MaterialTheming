using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class DarkMode_HighContrast_Spec2021_Blue : ITestTheme
{
    public string SourceColor => "#185FAA"; //Blue
    public bool IsDark => true;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#CCFEB3";
    public string OnPrimary => "#000000";
    public string PrimaryContainer => "#A0D089";
    public string OnPrimaryContainer => "#010F00";

    public string Secondary => "#FFEBF2";
    public string OnSecondary => "#000000";
    public string SecondaryContainer => "#E7B5CB";
    public string OnSecondaryContainer => "#1C0311";

    public string Tertiary => "#EEEFFF";
    public string OnTertiary => "#000000";
    public string TertiaryContainer => "#B4C0F6";
    public string OnTertiaryContainer => "#00082B";

    public string Error => "#FFECE9";
    public string OnError => "#000000";
    public string ErrorContainer => "#FFAEA4";
    public string OnErrorContainer => "#220001";

    public string Surface => "#11131A";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#FFFFFF";

    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#1E1F27";
    public string SurfaceContainer => "#2F3038";
    public string SurfaceContainerHigh => "#3A3B43";
    public string SurfaceContainerHighest => "#45464F";
}
