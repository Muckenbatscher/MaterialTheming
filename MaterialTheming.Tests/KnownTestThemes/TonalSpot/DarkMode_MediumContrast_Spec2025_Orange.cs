using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class DarkMode_MediumContrast_Spec2025_Orange : ITestTheme
{
    public string SourceColor => "#D77837"; //Orange
    public bool IsDark => true;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#F6BA96";
    public string OnPrimary => "#522C13";
    public string PrimaryContainer => "#9B694B";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#E5BFA9";
    public string OnSecondary => "#493121";
    public string SecondaryContainer => "#8E6E5C";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#FFF6DE";
    public string OnTertiary => "#5F531C";
    public string TertiaryContainer => "#FAE8A2";
    public string OnTertiaryContainer => "#574B15";

    public string Error => "#FFA089";
    public string OnError => "#5A0E00";
    public string ErrorContainer => "#C44F34";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#130D09";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#CAB5AA";

    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#1A120D";
    public string SurfaceContainer => "#211812";
    public string SurfaceContainerHigh => "#281D17";
    public string SurfaceContainerHighest => "#30231C";
}
