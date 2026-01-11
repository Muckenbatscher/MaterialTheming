using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Content;

internal class DarkMode_HighContrast_Spec2021 : ITestTheme
{
    public string SourceColor => "#B2B037"; //yellow
    public bool IsDark => true;
    public Variant Variant => Variant.Content;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#F8F675";
    public string OnPrimary => "#000000";
    public string PrimaryContainer => "#CAC84D";
    public string OnPrimaryContainer => "#0C0C00";

    public string Secondary => "#F6F3B6";
    public string OnSecondary => "#000000";
    public string SecondaryContainer => "#C8C58C";
    public string OnSecondaryContainer => "#0C0C00";

    public string Tertiary => "#C7FFB6";
    public string OnTertiary => "#000000";
    public string TertiaryContainer => "#8DD47E";
    public string OnTertiaryContainer => "#000F00";

    public string Error => "#FFECE9";
    public string OnError => "#000000";
    public string ErrorContainer => "#FFAEA4";
    public string OnErrorContainer => "#220001";

    public string Surface => "#14140C";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#FFFFFF";

    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#202017";
    public string SurfaceContainer => "#323127";
    public string SurfaceContainerHigh => "#3D3C32";
    public string SurfaceContainerHighest => "#48473D";
}
