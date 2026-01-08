using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class DarkMode_MediumContrast_Spec2025 : ITestTheme
{
    public string SourceColor => "#B2B037"; //yellow
    public bool IsDark => true;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#CCC98D";
    public string OnPrimary => "#39380A";
    public string PrimaryContainer => "#787743";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#CBC8A4";
    public string OnSecondary => "#38371D";
    public string SecondaryContainer => "#777657";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#FFE4C0";
    public string OnTertiary => "#624614";
    public string TertiaryContainer => "#FED494";
    public string OnTertiaryContainer => "#593E0C";

    public string Error => "#FFA089";
    public string OnError => "#5A0E00";
    public string ErrorContainer => "#C44F34";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#0F0E08";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#BCB9A7";

    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#14140C";
    public string SurfaceContainer => "#1A1A11";
    public string SurfaceContainerHigh => "#212016";
    public string SurfaceContainerHighest => "#27261A";
}
