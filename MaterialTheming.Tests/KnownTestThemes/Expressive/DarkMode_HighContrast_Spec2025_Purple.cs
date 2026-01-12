using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class DarkMode_HighContrast_Spec2025_Purple : ITestTheme
{
    public string SourceColor => "#945CCD"; //Purple
    public bool IsDark => true;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#F2DFFF";
    public string OnPrimary => "#391F54";
    public string PrimaryContainer => "#DDBCFC";
    public string OnPrimaryContainer => "#21043B";

    public string Secondary => "#D9EBD1";
    public string OnSecondary => "#21301F";
    public string SecondaryContainer => "#97A991";
    public string OnSecondaryContainer => "#000000";

    public string Tertiary => "#EDFFE0";
    public string OnTertiary => "#0D4200";
    public string TertiaryContainer => "#BDFCA2";
    public string OnTertiaryContainer => "#0A3800";

    public string Error => "#FFDDDF";
    public string OnError => "#5F001C";
    public string ErrorContainer => "#FF798C";
    public string OnErrorContainer => "#000000";

    public string Surface => "#120B19";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#F2DFFF";

    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#181021";
    public string SurfaceContainer => "#1F152A";
    public string SurfaceContainerHigh => "#261A32";
    public string SurfaceContainerHighest => "#2E203B";
}
