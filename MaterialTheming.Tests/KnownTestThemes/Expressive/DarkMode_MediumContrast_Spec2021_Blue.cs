using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class DarkMode_MediumContrast_Spec2021_Blue : ITestTheme
{
    public string SourceColor => "#185FAA"; //Blue
    public bool IsDark => true;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#B9EAA1";
    public string OnPrimary => "#082D00";
    public string PrimaryContainer => "#6F9D5B";
    public string OnPrimaryContainer => "#000000";

    public string Secondary => "#FFCFE4";
    public string OnSecondary => "#3B1B2C";
    public string SecondaryContainer => "#B18499";
    public string OnSecondaryContainer => "#000000";

    public string Tertiary => "#D4DBFF";
    public string OnTertiary => "#16234E";
    public string TertiaryContainer => "#838EC1";
    public string OnTertiaryContainer => "#000000";

    public string Error => "#FFD2CC";
    public string OnError => "#540003";
    public string ErrorContainer => "#FF5449";
    public string OnErrorContainer => "#000000";

    public string Surface => "#11131A";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#DADBEC";

    public string SurfaceContainerLowest => "#06070E";
    public string SurfaceContainerLow => "#1C1D25";
    public string SurfaceContainer => "#26272F";
    public string SurfaceContainerHigh => "#31323A";
    public string SurfaceContainerHighest => "#3C3D45";
}
