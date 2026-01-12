using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class DarkMode_HighContrast_Spec2025_Red : ITestTheme
{
    public string SourceColor => "#D2463D"; //Red
    public bool IsDark => true;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#FFDEDA";
    public string OnPrimary => "#511915";
    public string PrimaryContainer => "#FDA49A";
    public string OnPrimaryContainer => "#000000";

    public string Secondary => "#D2E9F4";
    public string OnSecondary => "#192F37";
    public string SecondaryContainer => "#91A7B1";
    public string OnSecondaryContainer => "#000000";

    public string Tertiary => "#BAEEFF";
    public string OnTertiary => "#00313C";
    public string TertiaryContainer => "#58D6F7";
    public string OnTertiaryContainer => "#00141A";

    public string Error => "#FFDDDF";
    public string OnError => "#5F001C";
    public string ErrorContainer => "#FF798C";
    public string OnErrorContainer => "#000000";

    public string Surface => "#1B0905";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#FFDED6";

    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#230D07";
    public string SurfaceContainer => "#2C130B";
    public string SurfaceContainerHigh => "#35170F";
    public string SurfaceContainerHighest => "#3E1C12";
}
