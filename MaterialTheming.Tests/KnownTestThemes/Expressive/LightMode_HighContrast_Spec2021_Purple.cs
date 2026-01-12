using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class LightMode_HighContrast_Spec2021_Purple : ITestTheme
{
    public string SourceColor => "#945CCD"; //Purple
    public bool IsDark => false;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#00322F";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#00534E";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#442130";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#653D4D";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#421E44";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#623B63";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#600004";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#98000A";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#FFF7FA";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#000000";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FAEDF7";
    public string SurfaceContainer => "#ECDFE9";
    public string SurfaceContainerHigh => "#DED1DB";
    public string SurfaceContainerHighest => "#CFC3CD";
}
