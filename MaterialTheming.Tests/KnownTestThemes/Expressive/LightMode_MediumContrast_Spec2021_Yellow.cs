using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class LightMode_MediumContrast_Spec2021_Yellow : ITestTheme
{
    public string SourceColor => "#B2B037"; //Yellow
    public bool IsDark => false;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#5C2043";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#9D567B";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#1D3D26";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#53755A";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#293C0B";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#5E743E";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#740006";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#CF2C27";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#FAFBEA";
    public string OnSurface => "#101209";
    public string OnSurfaceVariant => "#343827";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F4F5E4";
    public string SurfaceContainer => "#E8E9D9";
    public string SurfaceContainerHigh => "#DDDECE";
    public string SurfaceContainerHighest => "#D1D3C3";
}
