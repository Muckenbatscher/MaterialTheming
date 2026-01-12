using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class LightMode_HighContrast_Spec2021_Cyan : ITestTheme
{
    public string SourceColor => "#00BCD1"; //Cyan
    public bool IsDark => false;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#003138";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#00515B";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#173034";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#354D51";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#202B48";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#3E4867";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#600004";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#98000A";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#F5FAFC";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#000000";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#ECF2F3";
    public string SurfaceContainer => "#DEE3E5";
    public string SurfaceContainerHigh => "#D0D5D7";
    public string SurfaceContainerHighest => "#C2C7C9";
}
