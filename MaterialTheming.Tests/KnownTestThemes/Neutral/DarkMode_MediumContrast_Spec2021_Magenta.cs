using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class DarkMode_MediumContrast_Spec2021_Magenta : ITestTheme
{
    public string SourceColor => "#E85DAE"; //Magenta
    public bool IsDark => true;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#F0D5E0";
    public string OnPrimary => "#312129";
    public string PrimaryContainer => "#A28B94";
    public string OnPrimaryContainer => "#000000";

    public string Secondary => "#EAD8DE";
    public string OnSecondary => "#2D2327";
    public string SecondaryContainer => "#9C8D92";
    public string OnSecondaryContainer => "#000000";

    public string Tertiary => "#F6D3E1";
    public string OnTertiary => "#351F2A";
    public string TertiaryContainer => "#A78896";
    public string OnTertiaryContainer => "#000000";

    public string Error => "#FFD2CC";
    public string OnError => "#540003";
    public string ErrorContainer => "#FF5449";
    public string OnErrorContainer => "#000000";

    public string Surface => "#151314";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#E2DBDB";

    public string SurfaceContainerLowest => "#090708";
    public string SurfaceContainerLow => "#201D1E";
    public string SurfaceContainer => "#2A2728";
    public string SurfaceContainerHigh => "#353233";
    public string SurfaceContainerHighest => "#403D3E";
}
