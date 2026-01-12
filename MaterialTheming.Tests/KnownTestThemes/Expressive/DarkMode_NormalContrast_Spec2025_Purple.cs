using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class DarkMode_NormalContrast_Spec2025_Purple : ITestTheme
{
    public string SourceColor => "#945CCD"; //Purple
    public bool IsDark => true;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#E8CDFF";
    public string OnPrimary => "#5A3F75";
    public string PrimaryContainer => "#DDBCFC";
    public string OnPrimaryContainer => "#51366C";

    public string Secondary => "#BACCB3";
    public string OnSecondary => "#354432";
    public string SecondaryContainer => "#1B2919";
    public string OnSecondaryContainer => "#97A991";

    public string Tertiary => "#EDFFE0";
    public string OnTertiary => "#356B23";
    public string TertiaryContainer => "#BDFCA2";
    public string OnTertiaryContainer => "#2C621B";

    public string Error => "#FD6F85";
    public string OnError => "#490013";
    public string ErrorContainer => "#8A1632";
    public string OnErrorContainer => "#FF97A3";

    public string Surface => "#120B19";
    public string OnSurface => "#F2DFFF";
    public string OnSurfaceVariant => "#B7A4C7";

    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#181021";
    public string SurfaceContainer => "#1F152A";
    public string SurfaceContainerHigh => "#261A32";
    public string SurfaceContainerHighest => "#2E203B";
}
