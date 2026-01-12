using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class LightMode_MediumContrast_Spec2021_Purple : ITestTheme
{
    public string SourceColor => "#945CCD"; //Purple
    public bool IsDark => false;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#3B3341";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#736A79";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#39343D";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#716B74";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#3C3245";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#75697E";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#740006";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#CF2C27";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#FDF8FA";
    public string OnSurface => "#121112";
    public string OnSurfaceVariant => "#373637";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F8F2F4";
    public string SurfaceContainer => "#ECE7E9";
    public string SurfaceContainerHigh => "#E0DBDD";
    public string SurfaceContainerHighest => "#D5D0D2";
}
