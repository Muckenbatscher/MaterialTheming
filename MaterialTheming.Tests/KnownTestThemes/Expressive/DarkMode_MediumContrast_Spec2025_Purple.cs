using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class DarkMode_MediumContrast_Spec2025_Purple : ITestTheme
{
    public string SourceColor => "#945CCD"; //Purple
    public bool IsDark => true;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#E8CDFF";
    public string OnPrimary => "#50356B";
    public string PrimaryContainer => "#DDBCFC";
    public string OnPrimaryContainer => "#462C61";

    public string Secondary => "#BACCB3";
    public string OnSecondary => "#2B3A28";
    public string SecondaryContainer => "#697964";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#EDFFE0";
    public string OnTertiary => "#2B6119";
    public string TertiaryContainer => "#BDFCA2";
    public string OnTertiaryContainer => "#225811";

    public string Error => "#FF9DA8";
    public string OnError => "#5F001C";
    public string ErrorContainer => "#C8475D";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#120B19";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#C5B1D5";

    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#181021";
    public string SurfaceContainer => "#1F152A";
    public string SurfaceContainerHigh => "#261A32";
    public string SurfaceContainerHighest => "#2E203B";
}
