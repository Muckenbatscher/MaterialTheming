using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class LightMode_NormalContrast_Spec2021_Cyan : ITestTheme
{
    public string SourceColor => "#00BCD1"; //Cyan
    public bool IsDark => false;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#755B00";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#FFDF90";
    public string OnPrimaryContainer => "#584400";

    public string Secondary => "#64597C";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#EADDFF";
    public string OnSecondaryContainer => "#4C4163";

    public string Tertiary => "#25667C";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#BAEAFF";
    public string OnTertiaryContainer => "#004D62";

    public string Error => "#BA1A1A";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#FFDAD6";
    public string OnErrorContainer => "#93000A";

    public string Surface => "#F3FAFF";
    public string OnSurface => "#151D20";
    public string OnSurfaceVariant => "#3B494F";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#EDF5FA";
    public string SurfaceContainer => "#E7EFF4";
    public string SurfaceContainerHigh => "#E1E9EE";
    public string SurfaceContainerHighest => "#DCE4E8";
}
