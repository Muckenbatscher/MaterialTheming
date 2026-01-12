using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class LightMode_MediumContrast_Spec2025_Purple : ITestTheme
{
    public string SourceColor => "#945CCD"; //Purple
    public bool IsDark => false;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#46414A";
    public string OnPrimary => "#E0D7E2";
    public string PrimaryContainer => "#79727C";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#454246";
    public string OnSecondary => "#DED8DD";
    public string SecondaryContainer => "#777377";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#453F5A";
    public string OnTertiary => "#DED5F6";
    public string TertiaryContainer => "#77718E";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#7A2333";
    public string OnError => "#FFCDD1";
    public string ErrorContainer => "#B95463";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#FDF8F9";
    public string OnSurface => "#252326";
    public string OnSurfaceVariant => "#454245";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F7F2F4";
    public string SurfaceContainer => "#F2ECEF";
    public string SurfaceContainerHigh => "#ECE7E9";
    public string SurfaceContainerHighest => "#E7E1E4";
}
